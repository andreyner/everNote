using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.ModelBinding;

namespace Evernote.API.Helper
{
    public static class ModelValidator
    {
        public static string Validate(ModelStateDictionary modelState)
        {
            if (modelState.IsValid) return null;
            StringBuilder stringBuilder = new StringBuilder("Ошибка: ");

            foreach (var value in modelState.Values)
            {
                foreach (var error in value.Errors)
                {
                    stringBuilder.Append(error.ErrorMessage);
                }
            }
            return stringBuilder.ToString();
        }

    }
}