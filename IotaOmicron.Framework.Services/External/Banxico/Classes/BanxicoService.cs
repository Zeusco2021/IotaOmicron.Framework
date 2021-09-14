using IotaOmicron.Framework.Data.Models;
using IotaOmicron.Framework.Repositories.External.Banxico.Interfaces;
using IotaOmicron.Framework.Services.External.Banxico.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.External.Banxico.Classes
{
    public class BanxicoService : IBanxicoService
    {
        private IBanxicoRepository _banxicoRepository;

        public BanxicoService(IBanxicoRepository banxicoRepository)
        {
            _banxicoRepository = banxicoRepository;
        }

        public Task<BanxicoSeriesBmx> GetSerieById(string IdSerie)
        {
            return _banxicoRepository.GetSerieById(IdSerie);
        }
    }
}
