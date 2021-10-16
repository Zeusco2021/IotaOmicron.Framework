using IotaOmicron.Framework.Data.Models.DiarioOficialFederacion;
using IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.GobMx.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DOFController : ControllerBase
    {
        private IDOFService _dofService;

        public DOFController(IDOFService dofService)
        {
            _dofService = dofService;
        }

        /// <summary>
        ///  Retrieve Dairy Distributor data across Mexico.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFDistribuidores]</returns>
        [HttpGet("/DiarioOficialFederacion/GetDistribuidores")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFDistribuidores))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDistribuidores()
        {
            try
            {
                var listaDistribuidores = await _dofService.GetDistribuidores();
                if (listaDistribuidores == null)
                    return NotFound();
                return Ok(listaDistribuidores);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieve Mexican government office data that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFOrganismos]</returns>
        [HttpGet("/DiarioOficialFederacion/GetOrganismos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFOrganismos))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetOrganismos()
        {
            try
            {
                var listaOrganismos = await _dofService.GetOrganismos();
                if (listaOrganismos == null)
                    return NotFound();
                return Ok(listaOrganismos);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieve a list of the printed diaries published by the Mexican DOF agency.
        /// </summary>
        /// <param name="year">The Year in which the diaries were published</param>
        /// <returns>A JSON Object with the basic data of the [Type is IEnumerable<DOFEjemplares>]</returns>
        [HttpGet("/DiarioOficialFederacion/GetEjemplares")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DOFEjemplares>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetEjemplares(int year)
        {
            try
            {
                var listaEjemplares = await _dofService.GetEjemplares(year);
                if (listaEjemplares == null)
                    return NotFound();
                return Ok(listaEjemplares);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Tipo de Indicadores" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFTiposIndicadores]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoTiposIndicadores")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFTiposIndicadores))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoTiposIndicadores()
        {
            try
            {
                var listaCatalogoTiposIndicadores = await _dofService.GetCatalogoTiposIndicadores();
                if (listaCatalogoTiposIndicadores  == null)
                    return NotFound();
                return Ok(listaCatalogoTiposIndicadores);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Preguntas Frecuentes" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFPreguntasFrecuentes]</returns>
        [HttpGet("/DiarioOficialFederacion/GetPreguntasFrecuentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFPreguntasFrecuentes))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetPreguntasFrecuentes()
        {
            try
            {
                var listaPreguntasFrecuentes = await _dofService.GetPreguntasFrecuentes();
                if (listaPreguntasFrecuentes == null)
                    return NotFound();
                return Ok(listaPreguntasFrecuentes);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Preguntas Frecuentes Catalogadas" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFCatalogoPreguntasFrecuentes]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoPreguntasFrecuentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFCatalogoPreguntasFrecuentes))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoPreguntasFrecuentes()
        {
            try
            {
                var listaCatalogoPreguntasFrecuentes = await _dofService.GetCatalogoPreguntasFrecuentes();
                if (listaCatalogoPreguntasFrecuentes == null)
                    return NotFound();
                return Ok(listaCatalogoPreguntasFrecuentes);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Quejas Catalogadas" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFCatalogoQuejasContacto]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoQuejasContacto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFCatalogoQuejasContacto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoQuejasContacto()
        {
            try
            {
                var listaCatalogoQuejasContacto = await _dofService.GetCatalogoQuejasContacto();
                if (listaCatalogoQuejasContacto == null)
                    return NotFound();
                return Ok(listaCatalogoQuejasContacto);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Entidades Federativas Catalogadas" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFCatalogoEstados]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoEstados")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFCatalogoEstados))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoEstados()
        {
            try
            {
                var listaCatalogoEstados = await _dofService.GetCatalogoEstados();
                if (listaCatalogoEstados == null)
                    return NotFound();
                return Ok(listaCatalogoEstados);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Areas Catalogadas" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFCatalogoAreas]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoAreas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFCatalogoAreas))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoAreas()
        {
            try
            {
                var listaCatalogoAreas = await _dofService.GetCatalogoAreas();
                if (listaCatalogoAreas == null)
                    return NotFound();
                return Ok(listaCatalogoAreas);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a catalog of "Tópicos Catalogados" that publishes the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFCatalogoTopicos]</returns>
        [HttpGet("/DiarioOficialFederacion/Catalogos/GetCatalogoTopicos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFCatalogoTopicos))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCatalogoTopicos()
        {
            try
            {
                var listaCatalogoTopicos = await _dofService.GetCatalogoTopicos();
                if (listaCatalogoTopicos == null)
                    return NotFound();
                return Ok(listaCatalogoTopicos);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a list of notes from a topic specified in the Oficial Diary.
        /// </summary>
        /// <param name="notaId">The ID code of the diary note</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFNotasTopico]</returns>
        [HttpGet("/DiarioOficialFederacion/GetNotasTopico")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFNotasTopico))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetNotasTopico(int notaId)
        {
            try
            {
                var listaNotasTopico = await _dofService.GetNotasTopico(notaId);
                if (listaNotasTopico == null)
                    return NotFound();
                return Ok(listaNotasTopico);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves a list of top notes for a resource specified in the Oficial Diary.
        /// </summary>
        /// <param name="periodoTiempo">The time frame in which the notes are being published</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFTopNotasRecursos]</returns>
        [HttpGet("/DiarioOficialFederacion/GetTopNotasRecurso")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFTopNotasRecursos))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetTopNotasRecurso(DOFPeriodosTiempo periodoTiempo)
        {
            try
            {
                var listaTopNotasRecurso = await _dofService.GetTopNotasRecurso(periodoTiempo);
                if (listaTopNotasRecurso == null)
                    return NotFound();
                return Ok(listaTopNotasRecurso);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves the notes of Oficial Diary.
        /// </summary>
        /// <param name="notaId">The ID code of the diary note</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFNotas]</returns>
        [HttpGet("/DiarioOficialFederacion/Notas/GetNotaByNotaId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFNotas))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetNotaByNotaId(int notaId)
        {
            try
            {
                var listaNotas = await _dofService.GetNotaByNotaId(notaId);
                if (listaNotas == null)
                    return NotFound();
                return Ok(listaNotas);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


        /// <summary>
        ///  Retrieves the notes of Oficial Diary.
        /// </summary>
        /// <param name="fechaDiario">The date of release of the diary publication</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFNotasFecha]</returns>
        [HttpGet("/DiarioOficialFederacion/Notas/GetNotaByFecha")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFNotas))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetNotaByFecha(DateTime fechaDiario)
        {
            try
            {
                var listaNotas = await _dofService.GetNotaByFecha(fechaDiario);
                if (listaNotas == null)
                    return NotFound();
                return Ok(listaNotas);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves the notes of Oficial Diary.
        /// </summary>
        /// <param name="diarioId">The ID code of the diary publication</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFNotasDiario]</returns>
        [HttpGet("/DiarioOficialFederacion/Notas/GetNotaByDiarioId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFNotasDiario))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetNotaByDiarioId(int diarioId)
        {
            try
            {
                var listaNotas = await _dofService.GetNotaByDiarioId(diarioId);
                if (listaNotas == null)
                    return NotFound();
                return Ok(listaNotas);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves daily indicators of the Oficial Diary.
        /// </summary>
        /// <returns>A JSON Object with the basic data of the [Type is DOFIndicadores]</returns>
        [HttpGet("/DiarioOficialFederacion/Indicadores/GetIndicadoresDelDia")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFIndicadores))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetIndicadoresDelDia()
        {
            try
            {
                var listaIndicadores = await _dofService.GetIndicadoresDelDia();
                if (listaIndicadores == null)
                    return NotFound();
                return Ok(listaIndicadores);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves daily indicators of the Oficial Diary.
        /// </summary>
        /// <param name="fechaDiario">The date of release of the diary publication</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFIndicadores]</returns>
        [HttpGet("/DiarioOficialFederacion/Indicadores/GetIndicadoresByFecha")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFIndicadores))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetIndicadoresByFecha(DateTime fechaDiario)
        {
            try
            {
                var listaIndicadores = await _dofService.GetIndicadoresByFecha(fechaDiario);
                if (listaIndicadores == null)
                    return NotFound();
                return Ok(listaIndicadores);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves daily indicators of the Oficial Diary.
        /// </summary>
        /// <param name="indicadorId">The id code of the indicator to query</param>
        /// <param name="fechaInicio">The initial date of release of the diary publication</param>
        /// <param name="fechaFinal">The final date of release of the diary publication</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFIndicadores]</returns>
        [HttpGet("/DiarioOficialFederacion/Indicadores/GetIndicadoresIndicadorIdRangoFechas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFIndicadores))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetIndicadoresIndicadorIdRangoFechas(int indicadorId, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                var listaIndicadores = await _dofService.GetIndicadoresIndicadorIdRangoFechas(indicadorId, fechaInicio, fechaFinal);
                if (listaIndicadores == null)
                    return NotFound();
                return Ok(listaIndicadores);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves day publications of the Oficial Diary.
        /// </summary>
        /// <param name="fechaDiario">The date of release of the diary publication</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFDiarioFechaPeriodo]</returns>
        [HttpGet("/DiarioOficialFederacion/Diarios/GetDiariosByFecha")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFDiarioFechaPeriodo))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDiariosPorFecha(DateTime fechaDiario)
        {
            try
            {
                var listaDiarios = await _dofService.GetDiariosByFecha(fechaDiario);
                if (listaDiarios  == null)
                    return NotFound();
                return Ok(listaDiarios);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Retrieves the diaries published by the Oficial Diary in a given year.
        /// </summary>
        /// <param name="ejercicioPublicacion">The year in which diary publication released the publications</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFDiarioEjercicio]</returns>
        [HttpGet("/DiarioOficialFederacion/Diarios/GetDiariosByEjercicio")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFDiarioEjercicio))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDiariosByEjercicio(int ejercicioPublicacion)
        {
            try
            {
                var listaDiarios = await _dofService.GetDiariosByEjercicio(ejercicioPublicacion);
                if (listaDiarios == null)
                    return NotFound();
                return Ok(listaDiarios);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


        /// <summary>
        ///  Retrieves the diaries published by the Oficial Diary in a given day and edition.
        /// </summary>
        /// <param name="fechaDiario">The date in which diary publication released the publication</param>
        /// <param name="edicionDiario">The publication edition (schedule) in which diary publication released the publication in the given date</param>
        /// <returns>A JSON Object with the basic data of the [Type is DOFDiarioFechaEdicio]</returns>
        [HttpGet("/DiarioOficialFederacion/Diarios/GetDiariosByFechaEdicion")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DOFDiarioFechaEdicion))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDiariosByFechaEdicion(DateTime fechaDiario, DOFEdiciones edicionDiario)
        {
            try
            {
                var listaDiarios = await _dofService.GetDiariosByFechaEdicion(fechaDiario, edicionDiario);
                if (listaDiarios == null)
                    return NotFound();
                return Ok(listaDiarios);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Download a full diary publication as a PDF file.
        /// </summary>
        /// <param name"diarioId">The diary Id which will be used to identify the diary publication and download it.</param>
        /// <returns>A PDF File downloaded to the local machine of the user that calls this method.</returns>
        [HttpGet("/DiarioOficialFederacion/Diarios/GetDiariosAsPDF")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDiarioAsPDF(int diarioId)
        {
            try
            {
                var pdfPublicacion = await _dofService.GetDiarioAsPDF(diarioId);
                if (pdfPublicacion == null)
                    return NotFound();
                return Ok(pdfPublicacion);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        ///  Download a full nota publication as a DOCX file.
        /// </summary>
        /// <param name"notaId">The nota Id which will be used to identify the diary publication note and download it.</param>
        /// <returns>A DOCX File downloaded to the local machine of the user that calls this method.</returns>
        [HttpGet("/DiarioOficialFederacion/Notas/GetNotasAsMSWordDocument")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetNotasAsMSWordDocument(int notaId)
        {
            try
            {
                var pdfPublicacion = await _dofService.GetNotaAsMSWordDocument(notaId);
                if (pdfPublicacion == null)
                    return NotFound();
                return Ok(pdfPublicacion);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
