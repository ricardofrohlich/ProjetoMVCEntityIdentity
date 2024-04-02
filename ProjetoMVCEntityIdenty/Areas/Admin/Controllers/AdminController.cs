using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVCEntityIdenty.Areas.Admin.Controllers
{
    [Area("Admin")] //para encontrar, precisamos colocar
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
