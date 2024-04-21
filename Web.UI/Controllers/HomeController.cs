using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebFramework.Api;
using WebFramework.Configuration;

namespace Web.UI.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseMvcController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}