using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laboratorio_19_3.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string BaseUrl = "https://localhost:44312/";
            string ApiEndpoint = "api/values/Get/2";

            string value =  "Error al llamar API" ;
            string status = "SIN CONEXIÓN";

            using (var client = new HttpClient(GetHttpClientHandler()))
            {

                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync(ApiEndpoint);

                status = Res.StatusCode.ToString();

                if (Res.IsSuccessStatusCode)
                {
                    var ResponseContent = await Res.Content.ReadAsStringAsync();
                    value = JsonConvert.DeserializeObject<string>(ResponseContent);
                }

            }
            ViewBag.Value = value;
            ViewBag.Status = status;
            ViewBag.ApiEndpoint = ApiEndpoint;

            return View();
        }
        private HttpClientHandler GetHttpClientHandler()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            return handler;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}