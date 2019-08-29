using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormsAPI.FormHelpers
{
    public class FormHelper
    {
        public async Task<List<object>> GetFieldsAsync(Dictionary<string, object> fields)
        {
            var list = new List<object>();
            foreach (var keyValuePair in fields)
            {
                var a = keyValuePair.Value.GetType().ToString();
                switch (keyValuePair.Value.GetType().ToString())
                {
                    case "System.Collections.ArrayList" :  //Enum
                        
                        break;
                }
                Console.WriteLine(keyValuePair);
            }

            return new List<object>();
        }
    }
}