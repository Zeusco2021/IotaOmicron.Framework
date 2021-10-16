using System;
using System.Net;
using System.Threading.Tasks;
using IotaOmicron.Framework.Utilities.Common.Enums;
using IotaOmicron.Framework.Utilities.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IotaOmicron.Framework.Utilities.Common.Classes
{
    [Serializable]
    public class ResponseBuilder : IResponseBuilder
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public ResponseBuilder(HttpStatusCode httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
        }

        public ResponseBuilder(HttpStatusCode httpStatusCode, string message, object data)
        {
            HttpStatusCode = httpStatusCode;
            Message = message;
            Data = data;
        }


        public ResponseBuilder WithStatusCode(HttpStatusCode httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
            return this;
        }

        public ResponseBuilder WithMessage(string message)
        {
            Message = message;
            return this;
        }

        public ResponseBuilder WithDate(object data, string message)
        {
            Message = message;
            Data = data;
            return this;
        }

        public ResponseBuilder WithData(object data)
        {
            switch((int)HttpStatusCode)
            {
                case int responseNumber when responseNumber >= (int)StatusCode.SuccessMin || responseNumber <= (int)StatusCode.SuccessMax: return WithDate(data, StandardResultResponse.Success.ToString());
                case int responseNumber when responseNumber >= (int)StatusCode.RedirectionMin || responseNumber <= (int)StatusCode.RedirectionMax: return WithDate(data, StandardResultResponse.Success.ToString());
                case int responseNumber when responseNumber >= (int)StatusCode.FailureMin || responseNumber <= (int)StatusCode.FailureMax: return WithDate(data, StandardResultResponse.Success.ToString());
                case int responseNumber when responseNumber >= (int)StatusCode.ErrorMin || responseNumber <= (int)StatusCode.ErrorMax: return WithDate(data, StandardResultResponse.Success.ToString());
                default: return WithDate(data, StandardResultResponse.Unkown.ToString());
            }
        }

        public ResponseBuilder WithError(Exception exception)
        {
            return WithError(HttpStatusCode.InternalServerError, exception);  
        }

        public ResponseBuilder WithError(HttpStatusCode httpStatusCode, Exception exception)
        {
            return WithError(HttpStatusCode, exception?.Message, null);
        }

        public ResponseBuilder WithError(HttpStatusCode httpStatusCode, string error, object data)
        {
            HttpStatusCode = httpStatusCode;
            Message = Message;
            Data = data;
            return this;
        }


        public IActionResult Build()
        {
            var reply = BuildStandardResult();
            var result = new ObjectResult(reply)
            {
                StatusCode = (int)this.HttpStatusCode
            };
            return result;
        }
        
        public async Task<IActionResult> BuildAsync()
        {
            return await Task.FromResult(Build()).ConfigureAwait(false);
        }

        public StandardResult<object> BuildStandardResult()
        {
            return new StandardResult<object>()
            {
                Status = this.HttpStatusCode.ToResponseStatus(),
                Message = string.IsNullOrEmpty(Message) ? this.HttpStatusCode.ToString() : Message,
                Data = Data
            };
        }

        public static ResponseBuilder Create()
        {
            return new ResponseBuilder(HttpStatusCode.OK);
        }

        public static ResponseBuilder Create(HttpStatusCode httpStatusCode, string message, object data)
        {
            return new ResponseBuilder(httpStatusCode, message, data);
        }
    }
}
