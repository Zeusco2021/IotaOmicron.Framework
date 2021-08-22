using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IotaOmicron.Framework.Utilities.Common.Classes;
using Newtonsoft.Json;

namespace IotaOmicron.Framework.Utilities.Middleware
{
    public class ResponseBuilder
    {
        private readonly RequestDelegate _next;

        public ResponseBuilder(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Stream originalBody = context.Response.Body;
            Stream featureBody = null;
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    context.Response.Body = memoryStream;
                    await _next(context);
                    memoryStream.Position = 0;
                    string responseBody = new StreamReader(memoryStream).ReadToEnd();
                    memoryStream.Position = 0;
                    try
                    {
                        featureBody = RequestResponseHandler.ReplaceBody(context.Response, JsonConvert.SerializeObject(responseBody));
                    }
                    catch
                    {
                        featureBody = RequestResponseHandler.ReplaceBody(context.Response, responseBody);
                    }
                }
            }
            catch (Exception exception)
            {
                context.Response.StatusCode = 500;
                featureBody = RequestResponseHandler.ExceptionBody(exception);
            }
            finally
            {
                featureBody.Seek(0, SeekOrigin.Begin);
                await featureBody.CopyToAsync(originalBody);
                context.Response.Body = originalBody;
                originalBody = null;
                featureBody = null; 
            }
        }
    }
}
