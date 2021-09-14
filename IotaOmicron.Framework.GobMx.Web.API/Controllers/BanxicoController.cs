using IotaOmicron.Framework.Data.Models;
using IotaOmicron.Framework.Services.External.Banxico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.GobMx.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanxicoController : ControllerBase
    {
        private IBanxicoService _banxicoService;

        public BanxicoController(IBanxicoService banxicoService)
        {
            _banxicoService = banxicoService;
        }

        /// <summary>
        ///  Creation of the instance that will represent the application that will be managed by this API.
        /// </summary>
        /// <param name="SerieId">The serie identificator to use later on for ask for economic indicators.</param>
        /// <returns>A JSON Object with the basic data of the serie [Type is BanxicoSeriesBmx]</returns>
        [HttpGet("/Banxico/GetBySerieId/{SerieId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BanxicoSeriesBmx))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetSerieById(string SerieId)
        {
            try
            { 
                var serie = await _banxicoService.GetSerieById(SerieId);
                if(serie == null)
                    return NotFound();
                return Ok(serie);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
