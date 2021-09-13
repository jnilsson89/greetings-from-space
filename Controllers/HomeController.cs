using GreetingsFromSpace.Api;
using GreetingsFromSpace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GreetingsFromSpace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();

            var details = await ImageProcessor.GetImage();

            ViewBag.Date = details.Date.ToShortDateString();
            ViewBag.Url = details.Url;
            ViewBag.Copyright = details.Copyright;
            ViewBag.Explanation = details.Explanation;

            return View(details);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
