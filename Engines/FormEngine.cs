using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FormsAPI.Engines
{
    public class FormEngine
    {
        public async Task<object> ProcessFormDataAsync(List<object> fields)
        {
            return Task.Run(() => "processed");
        }
    }
}