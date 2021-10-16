using System;
using System.Net;
using System.Threading.Tasks;
using IotaOmicron.Framework.Utilities.Common.Classes;
using Microsoft.AspNetCore.Mvc;

namespace IotaOmicron.Framework.Utilities.Common.Interfaces
{
    public interface IResponseBuilder
    {
        ResponseBuilder WithStatusCode(HttpStatusCode httpStatusCode);
        ResponseBuilder WithMessage(string message);
        ResponseBuilder WithData(object data);
        ResponseBuilder WithError(Exception exception);
        IActionResult Build();
        Task<IActionResult> BuildAsync();
        StandardResult<object> BuildStandardResult();
    }
}
