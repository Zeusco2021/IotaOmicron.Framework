using IotaOmicron.Framework.Data.Models.DiarioOficialFederacion;
using IotaOmicron.Framework.Repositories.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Classes
{
    public class DOFService : IDOFService
    {
        private IDOFRepository _dofRepository;

        public DOFService(IDOFRepository dofRepository)
        {
            _dofRepository = dofRepository;
        }

        public async Task<DOFDistribuidores> GetDistribuidores()
        {
            return await _dofRepository.GetDistribuidores();
        }

        public async Task<DOFOrganismos> GetOrganismos()
        {
            return await _dofRepository.GetOrganismos();
        }

        public async Task<IEnumerable<DOFEjemplares>> GetEjemplares(int year)
        {
            return await _dofRepository.GetEjemplares(year);
        }
        public async Task<DOFTiposIndicadores> GetCatalogoTiposIndicadores()
        {
            return await _dofRepository.GetCatalogoTiposIndicadores();
        }

        public async Task<DOFPreguntasFrecuentes> GetPreguntasFrecuentes()
        {
            return await _dofRepository.GetPreguntasFrecuentes();
        }

        public async Task<DOFCatalogoPreguntasFrecuentes> GetCatalogoPreguntasFrecuentes()
        {
            return await _dofRepository.GetCatalogoPreguntasFrecuentes();
        }

        public async Task<DOFCatalogoQuejasContacto> GetCatalogoQuejasContacto()
        {
            return await _dofRepository.GetCatalogoQuejasContacto();
        }

        public async Task<DOFCatalogoEstados> GetCatalogoEstados()
        {
            return await _dofRepository.GetCatalogoEstados();
        }

        public async Task<DOFCatalogoAreas> GetCatalogoAreas()
        {
            return await _dofRepository.GetCatalogoAreas();
        }

        public async Task<DOFCatalogoTopicos> GetCatalogoTopicos()
        {
            return await _dofRepository.GetCatalogoTopicos();
        }

        public async Task<DOFNotasTopico> GetNotasTopico(int notaId)
        {
            return await _dofRepository.GetNotasTopico(notaId);
        }

        public async Task<DOFTopNotasRecursos> GetTopNotasRecurso(DOFPeriodosTiempo periodoTiempo)
        {
            return await _dofRepository.GetTopNotasRecurso(periodoTiempo);
        }

        public async Task<DOFNotas> GetNotaByNotaId(int notaId)
        {
            return await _dofRepository.GetNotaByNotaId(notaId);
        }

        public async Task<DOFNotasFecha> GetNotaByFecha(DateTime fechaDiario)
        {
            return await _dofRepository.GetNotaByFecha(fechaDiario);
        }

        public async Task<DOFNotasDiario> GetNotaByDiarioId(int diarioId)
        {
            return await _dofRepository.GetNotaByDiarioId(diarioId);
        }

        public async Task<DOFIndicadores> GetIndicadoresDelDia()
        {
            return await _dofRepository.GetIndicadoresDelDia();
        }

        public async Task<DOFIndicadores> GetIndicadoresByFecha(DateTime fechaDiario)
        {
            return await _dofRepository.GetIndicadoresByFecha(fechaDiario);
        }

        public async Task<DOFIndicadores> GetIndicadoresIndicadorIdRangoFechas(int indicadorId, DateTime fechaInicio, DateTime fechaFinal)
        {
            return await _dofRepository.GetIndicadoresIndicadorIdRangoFechas(indicadorId, fechaInicio, fechaFinal);
        }

        public async Task<DOFDiarioFechaPeriodo> GetDiariosByFecha(DateTime fechaDiario)
        {
            return await _dofRepository.GetDiariosByFecha(fechaDiario);
        }
        public async Task<DOFDiarioEjercicio> GetDiariosByEjercicio(int ejercicioPublicacion)
        {
            return await _dofRepository.GetDiariosByEjercicio(ejercicioPublicacion);
        }

        public async Task<DOFDiarioFechaEdicion> GetDiariosByFechaEdicion(DateTime fechaDiario, DOFEdiciones edicionDiario)
        {
            return await _dofRepository.GetDiariosByFechaEdicion(fechaDiario, edicionDiario);
        }

        public async Task<string> GetDiarioAsPDF(int diarioId)
        {
            return await _dofRepository.GetDiarioAsPDF(diarioId);
        }

        public async Task<string> GetNotaAsMSWordDocument(int notaId)
        {
            return await _dofRepository.GetNotaAsMSWordDocument(notaId);
        }
    }
}