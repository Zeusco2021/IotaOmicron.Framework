using System.Net;
using IotaOmicron.Framework.Utilities.Common.Enums;

namespace IotaOmicron.Framework.Utilities.Common.Classes
{
    public static class ResponseExtensions
    {
        public static string ToResponseStatus(this HttpStatusCode httpStatusCode)
        {
            switch ((int)httpStatusCode) 
            {
                case int responseNumber when responseNumber >= (int)StatusCode.SuccessMin || responseNumber <= (int)StatusCode.SuccessMax: return StandardResultResponse.Success.ToString();
                case int responseNumber when responseNumber >= (int)StatusCode.RedirectionMin || responseNumber <= (int)StatusCode.RedirectionMax: return StandardResultResponse.Success.ToString();
                case int responseNumber when responseNumber >= (int)StatusCode.FailureMin || responseNumber <= (int)StatusCode.FailureMax: return StandardResultResponse.Success.ToString();
                case int responseNumber when responseNumber >= (int)StatusCode.ErrorMin || responseNumber <= (int)StatusCode.ErrorMax: return StandardResultResponse.Success.ToString();
                default: return StandardResultResponse.Unkown.ToString();
            }

        }
    }
}
