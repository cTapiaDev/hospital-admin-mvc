using Microsoft.AspNetCore.Mvc;

namespace HospitalAdminMVC.Controllers
{
    public class PacientesController : Controller
    {
        public IActionResult VerFicha()
        {
            return View();
        }
    }
}
