using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Data.Models.DiarioOficialFederacion;
using IotaOmicron.Framework.Repositories.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;
using IotaOmicron.Framework.Utilities.Common.Classes.External.DiarioOficialFederacion;
using System.IO;

namespace IotaOmicron.Framework.Repositories.External.DiarioOficialFederacion.Classes
{
    public class DOFRepository : IDOFRepository
    {
        private readonly IDiarioOficialFederacionConfig _diarioOficialFederacionConfig;
        private readonly IHttpCustomClient _client;

        public DOFRepository(IDiarioOficialFederacionConfig diarioOficialFederacionConfig, IHttpCustomClient httpCustomClient)
        {
            _diarioOficialFederacionConfig = diarioOficialFederacionConfig;
            _client = httpCustomClient;
        }

        public async Task<DOFDistribuidores> GetDistribuidores()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/distribuidores";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFDistribuidores>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFOrganismos> GetOrganismos()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/organismos";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFOrganismos>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<IEnumerable<DOFEjemplares>> GetEjemplares(int year)
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/ejemplares/{year}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<DOFEjemplares>>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFTiposIndicadores> GetCatalogoTiposIndicadores()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_tipos_indicadores";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFTiposIndicadores>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFPreguntasFrecuentes> GetPreguntasFrecuentes()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/preguntasFrecuentes/consultaPreguntasFrecuentes";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFPreguntasFrecuentes>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFCatalogoPreguntasFrecuentes> GetCatalogoPreguntasFrecuentes()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_preguntas_frecuentes";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFCatalogoPreguntasFrecuentes>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFCatalogoQuejasContacto> GetCatalogoQuejasContacto()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_quejas_contacto";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFCatalogoQuejasContacto>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFCatalogoEstados> GetCatalogoEstados()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_estados";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFCatalogoEstados>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFCatalogoAreas> GetCatalogoAreas()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_areas";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFCatalogoAreas>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFCatalogoTopicos> GetCatalogoTopicos()
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/catalogos/cat_topicos";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFCatalogoTopicos>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFNotasTopico> GetNotasTopico(int notaId)
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/notasTopicos/{notaId}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFNotasTopico>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFTopNotasRecursos> GetTopNotasRecurso(DOFPeriodosTiempo periodoTiempo)
        {
            string periodoTiempoRequest  = DOFStringManipulator.PeriodoDeTiempo(periodoTiempo);
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/topNotasRecurso/{periodoTiempoRequest}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFTopNotasRecursos>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFNotas> GetNotaByNotaId(int notaId)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/notas/nota/{notaId}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFNotas>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFNotasFecha> GetNotaByFecha(DateTime fechaDiario)
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/notas/{String.Format("{0:dd-MM-yyyy}", fechaDiario)}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFNotasFecha>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFNotasDiario> GetNotaByDiarioId(int diarioId)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/notas/obtenerNotasPorDiario/{diarioId}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFNotasDiario>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }


        public async Task<DOFIndicadores> GetIndicadoresDelDia()
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/indicadores";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFIndicadores>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }


        public async Task<DOFIndicadores> GetIndicadoresByFecha(DateTime fechaDiario)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/indicadores/{String.Format("{0:dd-MM-yyyy}", fechaDiario)}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFIndicadores>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFIndicadores> GetIndicadoresIndicadorIdRangoFechas(int indicadorId, DateTime fechaInicio, DateTime fechaFinal)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/indicadores/{indicadorId}/{String.Format("{0:dd-MM-yyyy}", fechaInicio)}/{String.Format("{0:dd-MM-yyyy}", fechaFinal)}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFIndicadores>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFDiarioFechaPeriodo> GetDiariosByFecha(DateTime fechaDiario)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/diarios/porFecha/{String.Format("{0:dd-MM-yyyy}", fechaDiario)}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFDiarioFechaPeriodo>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<DOFDiarioEjercicio> GetDiariosByEjercicio(int ejercicioPublicacion)
        {

            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/diarios/{ejercicioPublicacion}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFDiarioEjercicio>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }


        public async Task<DOFDiarioFechaEdicion> GetDiariosByFechaEdicion(DateTime fechaDiario, DOFEdiciones edicionDiario)
        {
            string edicionPublicacion = DOFStringManipulator.EdicionDelDOF(edicionDiario);
            string workingUri         = $"{_diarioOficialFederacionConfig.BaseUri}/diarios/{String.Format("{0:dd-MM-yyyy}", fechaDiario)}/{edicionPublicacion}";
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<DOFDiarioFechaEdicion>();
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<string> GetDiarioAsPDF(int diarioId)
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/documentos/pdf/{diarioId}";
            var fileInfo                 = new FileInfo($"{diarioId}.pdf");
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);
            if (response.IsSuccessStatusCode)
            {
                await using Stream memoryStream   = await response.Content.ReadAsStreamAsync();
                await using FileStream fileStream = File.Create(fileInfo.FullName);
                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.CopyTo(fileStream);
                return fileInfo.FullName;
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }

        public async Task<string> GetNotaAsMSWordDocument(int notaId)
        {
            string workingUri            = $"{_diarioOficialFederacionConfig.BaseUri}/documentos/doc/{notaId}";
            var fileInfo                 = new FileInfo($"{notaId}.docx");
            HttpResponseMessage response = await _client.Get(workingUri, true, true, true, null, null);
            if (response.IsSuccessStatusCode)
            {
                await using Stream memoryStream   = await response.Content.ReadAsStreamAsync();
                await using FileStream fileStream = File.Create(fileInfo.FullName);
                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.CopyTo(fileStream);
                return fileInfo.FullName;
            }

            throw new Exception($"The call to the Diario Oficial de la Federacion service {workingUri} returned a status code of {response.StatusCode}");
        }
    }
}