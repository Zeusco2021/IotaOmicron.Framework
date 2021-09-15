using IotaOmicron.Framework.Data.Models.Banxico;
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
        ///  Retrieve serie data by its Id in order to query further data.
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

        /// <summary>
        ///  Retrieve all series data that belong to the "Banco de Mexico" section .
        /// <param name="bancoDeMexicoSectionNumber">The number of section for "Banco de Mexico" series section that will be retrieved. For this API purpose, there are 13 sections.</param>
        /// </summary>
        /// <returns>A JSON Object with the basic data of the serie collection that belongs to the "Banco de Mexico" section [Type is BanxicoSeriesBmx]</returns>
        [HttpGet("/Banxico/GetAllSeriesBancoDeMexicoSection/{bancoDeMexicoSectionNumber}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BanxicoSeriesBmx))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllSeriesBancoDeMexicoSection(int bancoDeMexicoSectionNumber)
        {
            if (!(bancoDeMexicoSectionNumber >= 1) || !(bancoDeMexicoSectionNumber <= 13))
            {
                return NotFound();
            }
            try
            {
                var serie = await _banxicoService.GetAllSeriesBancoDeMexicoSection(bancoDeMexicoSectionNumber);
                if (serie == null)
                    return NotFound();
                return Ok(serie);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieve all series data that belong to the "Banco de Mexico" section .
        /// <param name="bancoDeMexicoSectionNumber">The number of section for "Banco de Mexico" series section that will be retrieved. For this API purpose, there are 13 sections.</param>
        /// </summary>
        /// <returns>A JSON Object with the basic data of the serie collection that belongs to the "Banco de Mexico" section [Type is BanxicoSeriesBmx]</returns>
        [HttpGet("/Banxico/GetAllSeriesBancoDeMexicoSection/{bancoDeMexicoSectionNumber}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BanxicoSeriesBmx))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllSeriesBancoDeMexicoSection(int bancoDeMexicoSectionNumber)
        {
            if (!(bancoDeMexicoSectionNumber >= 1) || !(bancoDeMexicoSectionNumber <= 13))
            {
                return NotFound();
            }

            try
            {
                var serie = await _banxicoService.GetAllSeriesBancoDeMexicoSection(bancoDeMexicoSectionNumber);
                if (serie == null)
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
