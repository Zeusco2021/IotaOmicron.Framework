using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Data.Models
{
    public class TokenAuth
    {
        public string Token { get; set; }
        public long ExpiresAt { get; set; }
        public long Audience { get; set; }

    }
}
