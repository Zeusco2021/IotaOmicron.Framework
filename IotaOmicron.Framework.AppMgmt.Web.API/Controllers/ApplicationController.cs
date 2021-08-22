using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Net;
using IotaOmicron.Framework.Services.Application.Interfaces;

namespace IotaOmicron.Framework.AppMgmt.Web.API.Controllers
{
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService appService)
        {
            _applicationService = appService;
        }


        /// <summary>
        ///  Creation of the instance that will represent the application that will be managed by this API.
        /// </summary>
        /// <param name="appName">The name of the application that will be created in order to be managed by this API.</param>
        /// <param name="userName">The name of the user that is recording the application data to be managed by this API.</param>
        /// <returns>An Integer which is either the number of rows affected by this new change (successfully, 1) or the error code sent by the database server on failure.</returns>
        [HttpPost]
        //[Authorize]
        [Route("api/[controller]")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateApplication(string appName, string userName)
        {
            try
            {
                var createdApplication = await _applicationService.CreateApplication(appName, userName);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
