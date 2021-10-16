using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Utilities.Common.Interfaces
{
    public interface IHttpCustomClient
    {
        Task<HttpResponseMessage> Get(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Head(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Post(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Put(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Delete(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Connect(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Options(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Trace(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
        Task<HttpResponseMessage> Patch(string requestUri, bool preAuthentication = false, bool useDefaultCredetials = true, bool allowRedirect = true, string bearerToken = null, Dictionary<string, string> headers = null, StringContent content = null, bool customSSLValidation = false, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocation.CurrentUser);
    }
}
