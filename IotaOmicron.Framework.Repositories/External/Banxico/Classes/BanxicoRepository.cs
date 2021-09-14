using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Data.Models;
using IotaOmicron.Framework.Utilities.Common.Classes.HttpClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using IotaOmicron.Framework.Repositories.External.Banxico.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Interfaces;
using System;


namespace IotaOmicron.Framework.Repositories.External.Banxico.Classes
{
    public class BanxicoRepository : IBanxicoRepository
    {
        private readonly IBanxicoConfig _banxicoConfig;
        private readonly IHttpCustomClient _client;

        public BanxicoRepository(IBanxicoConfig banxicoConfig, IHttpCustomClient httpCustomClient)
        {
            _banxicoConfig = banxicoConfig;
            _client        = httpCustomClient;
        }

        public async Task<BanxicoSeriesBmx> GetSerieById(string IdSerie)
        {
            string workingUri                  = $"{_banxicoConfig.BaseUri}/{IdSerie}";
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add(_banxicoConfig.ApiTokenHeader.HeaderName, _banxicoConfig.ApiTokenHeader.APIKey);
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, headers);

            if (response.IsSuccessStatusCode)
            {
                return (await response.Content.ReadAsAsync<BanxicoSeriesBmx>());
            }

            throw new Exception($"The call to the Banxico service {workingUri} returned a status code of {response.StatusCode}");
        }
    }
}
