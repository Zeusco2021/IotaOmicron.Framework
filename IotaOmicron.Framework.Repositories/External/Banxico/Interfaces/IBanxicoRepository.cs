using IotaOmicron.Framework.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Repositories.External.Banxico.Interfaces
{
    public interface IBanxicoRepository
    {
        public Task<BanxicoSeriesBmx> GetSerieById(string IdSerie);
   }
}
