using IotaOmicron.Framework.Data.Models.Banxico;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Repositories.External.Banxico.Interfaces
{
    public interface IBanxicoRepository
    {
        Task<BanxicoSeriesBmx> GetSerieById(string IdSerie);
        Task<BanxicoSeriesBmx> GetAllSeriesBancoDeMexicoSection(int BancoDeMexicoSectionNumber);
   }
}
