using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Utilities.Common.Classes.HttpClient
{
    public class HttpRequestBuilder
    {
        private HttpMethod _method = null;
        private Dictionary<string, string> _headers = null;
        private StringContent _content = null;
        private Uri _requestUri = null;
        private HttpRequestMessage _requestMessage = new HttpRequestMessage();
        private HttpClientHandler _handler = new HttpClientHandler();
        private System.Net.Http.HttpClient _client = null;
        private TimeSpan _timeout = new TimeSpan(0, 2, 0);

        public bool UseDefaultCredentials { get; set; } = true;
        public bool AllowRedirect { get; set; } = true;
        public bool PreAuthentication { get; set; } = false;
        public string BearerToken { get; set; } = string.Empty;

        public HttpRequestBuilder(bool preAuthentication)
        {
            PreAuthentication = preAuthentication;
        }

        public HttpRequestBuilder AddMethod(HttpMethod method)
        {
            _method = method;
            return this;
        }

        public HttpRequestBuilder AddHeaders(Dictionary<string, string> headers)
        {
            _headers = headers;
            return this;
        }

        public HttpRequestBuilder AddContent(StringContent content)
        {
            _content = content;
            return this;
        }

        public HttpRequestBuilder AddRequestUri(string requestUri)
        {
            _requestUri = new Uri(requestUri);
            return this;
        }

        public HttpRequestBuilder AddBearerToken(string bearerToken)
        {
            BearerToken = bearerToken;
            return this;
        }

        public HttpRequestBuilder AddHandler(bool allowRedirect, bool useDefaultCredentials, bool preAuthentication, bool customSSLValidation, StoreName storeName, StoreLocation storeLocation)
        {
            if (customSSLValidation)
            {
                _handler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) =>
                {
                    if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.None)
                    {
                        return true;
                    }

                    if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors)
                    {
                        using (var certStore = new X509Store(storeName, storeLocation))
                        {
                            certStore.Open(OpenFlags.ReadOnly);
                            var validCert = certStore.Certificates.Find(X509FindType.FindByThumbprint, cert.Thumbprint, false);
                            certStore.Close();

                            if (validCert.Count > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            _handler.AllowAutoRedirect = allowRedirect;
            _handler.UseDefaultCredentials = useDefaultCredentials;
            _handler.PreAuthenticate = preAuthentication;
            return this;
        }

        public HttpRequestBuilder AddClient()
        {
            _client = new System.Net.Http.HttpClient(_handler);
            _client.Timeout = _timeout;
            if (BearerToken != string.Empty)
            {
                _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", BearerToken);
            }
            return this;
        }

        public HttpRequestBuilder AddRequestMessage()
        {
            _requestMessage.Method = _method;
            _requestMessage.RequestUri = _requestUri;
            if (_content != null)
            {
                _requestMessage.Content = _content;
            }
            if (_headers != null)
            {
                if (_headers.Count > 0)
                {
                    foreach (KeyValuePair<string, string> header in _headers)
                    {
                        _requestMessage.Headers.Add(header.Key, header.Value);
                    }
                }
            }
            return this;
        }

        private void ValidateArguments()
        {
            if (_method == null)
            {
                throw new ArgumentNullException("Request Method");
            }
            if (_requestUri == null)
            {
                throw new ArgumentNullException("Request Uri");
            }
        }

        public async Task<HttpResponseMessage> SendAsync()
        {
            ValidateArguments();
            return await _client.SendAsync(_requestMessage);
        }
    }
}