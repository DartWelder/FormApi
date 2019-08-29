using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using Antlr.Runtime;
using FormsAPI.Engines;
using FormsAPI.FormHelpers;
using Nancy;
using Nancy.Extensions;
using Nancy.ModelBinding;
using Newtonsoft.Json;

namespace FormsAPI
{
    public class FormModule: NancyModule
    {
        private FormEngine _formEngine;
        private FormHelper _formHelper;
        public FormModule(FormEngine formEngine, FormHelper formHelper)
        {
            _formEngine = formEngine ?? throw new NotImplementedException();
            _formHelper = formHelper ?? throw new NotImplementedException();
            
            Get("/", _ => { return "HELLO!"; });
            Get("/form/{id}", _ => { return "HELLO!"; });
            Post("/form", PostFormHandlerAsync);
        }
        
        public async Task<object> PostFormHandlerAsync(dynamic args, CancellationToken cancellationToken)
        {
            var serializer = new JavaScriptSerializer();
            var t = serializer.Deserialize<Dictionary<string, object>>(Context.Request.Body.AsString());
            List<object> fields = await _formHelper.GetFieldsAsync(t);
            return _formEngine.ProcessFormDataAsync(fields);
        }
    }
}