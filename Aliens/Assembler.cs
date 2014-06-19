using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aliens
{
    public class Assembler
    {
        public async Task<dynamic> GetPageAsync(string url)
        {
            using (var client = new HttpClient())
            {
                //var response = await client.GetAsync(string.Concat("http://localhost:8006/assembler/json/pages/",url));
                var test = File.ReadAllText(HttpContext.Current.Server.MapPath("~/Content/test.json"));
                return JsonConvert.DeserializeObject<dynamic>(test);
            }
        }
         
    }
}