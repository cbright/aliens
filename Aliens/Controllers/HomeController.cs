using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Aliens.Models;
using Newtonsoft.Json.Linq;

namespace Aliens.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public async Task<ActionResult> Index()
        {
            var assembler = new Assembler();

            var result = await assembler.GetPageAsync("trade-center");

            ViewBag.Layout = result["@type"];
            ViewBag.Root = result;

            return View();

        }

        [ChildActionOnly]
        public PartialViewResult ContentSlotHeader(JObject model){
            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult SearchBox(JObject inptModel)
        {
            var model =  inptModel.ToObject<SearchBox>();
            model.RandomInt = new Random().Next(100);

            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult HorizontalRecordSpotlight(JObject model)
        {
            return PartialView(model);
        }

    }
}
