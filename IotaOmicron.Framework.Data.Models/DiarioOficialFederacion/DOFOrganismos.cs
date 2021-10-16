using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFOrganismos
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<Organismo> Organismos { get; set; }
    }

    public class Organismo
    {
        public double Orden { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string state { get; set; }
        public IEnumerable<Child> Children { get; set; }
    }

    public class Child
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public IEnumerable<Child> Children { get; set; }
    }
}
