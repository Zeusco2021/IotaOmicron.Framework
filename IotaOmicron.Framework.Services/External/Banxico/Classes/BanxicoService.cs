using IotaOmicron.Framework.Data.Models.Banxico;
using IotaOmicron.Framework.Repositories.External.Banxico.Interfaces;
using IotaOmicron.Framework.Services.External.Banxico.Interfaces;
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

        public async Task<BanxicoSeriesBmx> GetSerieById(string IdSerie)
        {
            return await _banxicoRepository.GetSerieById(IdSerie);
        }

        public async Task<BanxicoSeriesBmx> GetAllSeriesBancoDeMexicoSection(int bancoDeMexicoSectionNumber)
        {
            return await _banxicoRepository.GetAllSeriesBancoDeMexicoSection(bancoDeMexicoSectionNumber);
        }
    }
}
