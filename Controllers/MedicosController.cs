using HospitalAdminMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAdminMVC.Controllers
{
    public class MedicosController : Controller
    {
        private readonly IHospitalInfoService _hospitalInfoService;

        public MedicosController(IHospitalInfoService hospitalInfoService)
        {
            _hospitalInfoService = hospitalInfoService;
        }

        public IActionResult VerPerfil()
        {
            ViewBag.NombreHospital = _hospitalInfoService.ObtenerNombreHospital();
            return View();
        }
    }
}
