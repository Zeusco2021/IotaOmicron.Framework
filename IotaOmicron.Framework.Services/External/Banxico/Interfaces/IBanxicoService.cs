using IotaOmicron.Framework.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.External.Banxico.Interfaces
{
    public interface IBanxicoService
    {
        Task<BanxicoSeriesBmx> GetSerieById(string IdSerie);
        Task<BanxicoSeriesBmx> GetAllSeriesBancoDeMexicoSection(int bancoDeMexicoSectionNumber);
    }
}
