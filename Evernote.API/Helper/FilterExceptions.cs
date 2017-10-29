using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Evernote.API.Helper
{
    public class FilterExceptions : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext context)
        {
            Logger.Log.Instance.Error(context.Exception.Message);
            if (context.Exception is SqlException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message
                };
            }
            else
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message
                };
            }
            Logger.Log.Instance.Error($"{context.Exception.StackTrace}{Environment.NewLine}{context.Exception.Message}");
            
        }
    }
}