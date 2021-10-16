using System;

namespace IotaOmicron.Framework.Utilities.Common.Enums
{
    [Serializable]
    public enum StatusCode
    {
        SuccessMin     = 200,
        SuccessMax     = 299,
        RedirectionMin = 300,
        RedirectionMax = 399,
        FailureMin     = 400,
        FailureMax     = 499,
        ErrorMin       = 500,
        ErrorMax       = 599
    }
}
