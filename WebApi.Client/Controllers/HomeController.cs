using System.Diagnostics;
using System.Threading.Tasks;
using Api.ClientProxy.MyNamespace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Client.Models;

namespace WebApi.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDefaultClient _defaultClient;

        public HomeController(ILogger<HomeController> logger,IDefaultClient defaultClient)
        {
            _logger = logger;
            _defaultClient = defaultClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var temp = await _defaultClient.GetUserDetailsAsync();
            return View(temp);
        }

        public IActionResult Privacy()
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
