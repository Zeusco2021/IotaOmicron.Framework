using IotaOmicron.Framework.Data.Models.DiarioOficialFederacion;
using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Interfaces
{
    public interface IDOFService
    {
        Task<DOFDistribuidores> GetDistribuidores();
        Task<DOFOrganismos> GetOrganismos();
        Task<IEnumerable<DOFEjemplares>> GetEjemplares(int year);
        Task<DOFTiposIndicadores> GetCatalogoTiposIndicadores();
        Task<DOFPreguntasFrecuentes> GetPreguntasFrecuentes();
        Task<DOFCatalogoPreguntasFrecuentes> GetCatalogoPreguntasFrecuentes();
        Task<DOFCatalogoQuejasContacto> GetCatalogoQuejasContacto();
        Task<DOFCatalogoEstados> GetCatalogoEstados();
        Task<DOFCatalogoAreas> GetCatalogoAreas();
        Task<DOFCatalogoTopicos> GetCatalogoTopicos();
        Task<DOFNotasTopico> GetNotasTopico(int notaId);
        Task<DOFTopNotasRecursos> GetTopNotasRecurso(DOFPeriodosTiempo periodoTiempo);
        Task<DOFNotas> GetNotaByNotaId(int notaId);
        Task<DOFNotasFecha> GetNotaByFecha(DateTime fechaDiario);
        Task<DOFNotasDiario> GetNotaByDiarioId(int diarioId);
        Task<DOFIndicadores> GetIndicadoresDelDia();
        Task<DOFIndicadores> GetIndicadoresByFecha(DateTime fechaDiario);
        Task<DOFIndicadores> GetIndicadoresIndicadorIdRangoFechas(int indicadorId, DateTime fechaInicio, DateTime fechaFinal);
        Task<DOFDiarioFechaPeriodo> GetDiariosByFecha(DateTime fechaDiario);
        Task<DOFDiarioEjercicio> GetDiariosByEjercicio(int ejercicioPublicacion);
        Task<DOFDiarioFechaEdicion> GetDiariosByFechaEdicion(DateTime fechaDiario, DOFEdiciones edicionDiario);
        Task<string> GetDiarioAsPDF(int diarioId);
        Task<string> GetNotaAsMSWordDocument(int notaId);
    }
}
