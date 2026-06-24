using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Areas.ApiKullanimi.Controllers
{
    public class MainController : Controller
    {
        [Area("ApiKullanimi")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
