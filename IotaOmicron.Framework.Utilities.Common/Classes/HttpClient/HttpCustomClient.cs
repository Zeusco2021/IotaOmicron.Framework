using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IotaOmicron.Framework.Utilities.Common.Interfaces;

namespace IotaOmicron.Framework.Utilities.Common.Classes.HttpClient
{
    public class HttpCustomClient : IHttpCustomClient
    {
        public Task<HttpResponseMessage> Connect(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, 
                                                 Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false,  
                                                 StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> Delete(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, 
                                                      string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                      StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Delete)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Get(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null,
                                                   Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                   StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Get)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Head(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null,
                                                    Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                    StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Head)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Options(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, 
                                                       string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                       StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Options)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Patch(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, 
                                                     string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                     StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Patch)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Post(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, 
                                                    string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                    StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Post)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Put(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null,
                                                   Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                   StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Put)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }

        public async Task<HttpResponseMessage> Trace(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, 
                                                     string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, 
                                                     StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            HttpRequestBuilder httpBuilder = new HttpRequestBuilder(preAuthentication)
                .AddRequestUri(requestUri)
                .AddMethod(HttpMethod.Trace)
                .AddBearerToken(bearerToken)
                .AddHeaders(headers)
                .AddContent(content)
                .AddHandler(allowRedirect, useDefaultCredetials, preAuthentication, customSSLValidation, storeName, storeLocation)
                .AddClient()
                .AddRequestMessage();
            return await httpBuilder.SendAsync();
        }
    }
}