namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFNotasData
    {
        public int CodNota { get; set; }
        public string Titulo { get; set; }
        public string CodSeccion { get; set; }
        public string Fecha { get; set; }
        public int CodDiario { get; set; }
        public string CadenaContenido { get; set; }
        public string ExisteDoc { get; set; }
        public string ExisteImagen { get; set; }
        public int Estado { get; set; }
        public int Pagina { get; set; }
        public int PaginaHasta { get; set; }
        public string CodOrgaUno { get; set; }
        public string CodOrgaDos { get; set; }
        public string CodOrgaTres { get; set; }
        public string CodOrgaCuatro { get; set; }
        public string NombOrganismo { get; set; }
        public double Orden { get; set; }
        public string CodEdicion { get; set; }
        public int TamanioContenido { get; set; }
        public int OrdenSeccion { get; set; }
        public string ExistePdf { get; set; }
    }

    public class DOFNotas
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public DOFNotasData Nota { get; set; }
        public bool TamanioExcesivo { get; set; }
    }


}
