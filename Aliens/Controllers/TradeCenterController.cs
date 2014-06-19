using System.Threading.Tasks;
using System.Web.Mvc;

namespace Aliens.Controllers
{
    public class TradeCenterController : Controller
    {
        //
        // GET: /TradeCenter/

        public async Task<ActionResult> Index()
        {
            var assembler = new Assembler();
            
            var result = await assembler.GetPageAsync("trade-center");
            ViewBag.Layout = result["@type"];
            ViewBag.Root = result;

            return View();

        }

    }
}
