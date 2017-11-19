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
            Logger.Log.Instance.Error($"{context.Exception.StackTrace}{Environment.NewLine}{context.Exception.Message}");

            if (context.Exception is InvalidOperationException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message
                };
                return;
            }

            if (context.Exception is System.IO.IOException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message
                };
                return;
            }
            if (context.Exception is SqlException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.Forbidden)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message.Replace("\r\n", "")//текст не может содержать симввола переноса строки!! ??
                };
                return;
            }
            if (context.Exception is ArgumentException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format(context.Exception.Message)),
                    ReasonPhrase = context.Exception.Message
                };
                return;
            }
         



            context.Response = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent(string.Format(context.Exception.Message)),
                ReasonPhrase = context.Exception.Message
            };



        }
    }
}