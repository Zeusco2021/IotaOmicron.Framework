using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Utilities.Common.Enums
{
    [Serializable]
    public enum StandardResultResponse
    {
        Success,
        Redirection,
        Failure,
        Error,
        Unkown
    }
}