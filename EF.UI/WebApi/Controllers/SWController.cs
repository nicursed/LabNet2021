using System;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Http;
using System.Net.Http.Json;

namespace WebApi.Controllers
{
    public class SWController : Controller
    {
        // GET: SW
        string url = "https://swapi.dev/api/";
        public async Task<ActionResult> Index()
        {
            Models.SWView view = new Models.SWView();
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Models.SWView swview = await client.GetFromJsonAsync<Models.SWView>("people/1/");
                view.birth_year = swview.birth_year;
                view.eye_color = swview.eye_color;
                view.gender = swview.gender;
                view.hair_color = swview.hair_color;
                view.height = swview.height;
                view.mass = swview.mass;
                view.name = swview.name;
                view.skin_color = swview.skin_color;

            }
            return View(view);
        }
    }
}