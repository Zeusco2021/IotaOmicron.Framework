using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Data.Models
{
    public class MiddlewareResponse<T>
    {
        public int HttpStatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class MiddlewareResponseListOf<T> : MiddlewareResponse<T>
    {
        public new IEnumerable<T> Data { get; set; }
    }
}
