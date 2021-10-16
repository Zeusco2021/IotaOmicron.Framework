using System;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace IotaOmicron.Framework.Utilities.Common.Classes
{
    public  static class RequestResponseHandler
    {
        public static Stream ReplaceBody(HttpResponse response, object originalBody)
        {
            ResponseBuilder responseBuilder = new ResponseBuilder((HttpStatusCode)response.StatusCode);
            try
            {
                responseBuilder.WithData(originalBody);
                responseBuilder.Build();
                MemoryStream newBuilder = SerializeToStream(responseBuilder);
                return newBuilder;
            }
            catch (Exception exception)
            {
                return ExceptionBody(exception);
            }
        }

        public static MemoryStream SerializeToStream(object objectBuilder)
        {
            JsonSerializer serializer = new JsonSerializer();
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(memoryStream);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            serializer.Serialize(jsonWriter, objectBuilder, typeof(ResponseBuilder));
            jsonWriter.Flush();
            memoryStream.Position = 0;
            return memoryStream;
        }

        public static MemoryStream ExceptionBody(Exception exception)
        {
            ResponseBuilder responseBuilder = new ResponseBuilder(HttpStatusCode.InternalServerError);
            responseBuilder.WithError(exception);
            responseBuilder.WithMessage(exception.Message);
            responseBuilder.Build();
            return SerializeToStream(responseBuilder);
        }
    }
}
