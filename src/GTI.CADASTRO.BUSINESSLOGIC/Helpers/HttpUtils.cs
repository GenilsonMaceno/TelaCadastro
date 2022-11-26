using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace GTI.CADASTRO.BUSINESSLOGIC.Helpers
{
    public static class HttpUtils
    {
        public static async Task<HttpResponseMessage> ExecutePostAsync(string endpoint, object payload)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage result = await client.PostAsync(endpoint, content);

                    if (result.IsSuccessStatusCode)
                    {
                        return result;
                    }

                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
