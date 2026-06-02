using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVCRazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
