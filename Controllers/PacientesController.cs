using HospitalAdminMVC.Models;
using HospitalAdminMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAdminMVC.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IServicioDeAuditoria _servicioAuditoria;

        private static List<Paciente> _pacientes = new List<Paciente>
        {
            new Paciente { Id = 1, Nombre = "Juan Pérez", Rut = "11-1", FechaNacimiento = new DateTime(1980, 5, 20)},
            new Paciente { Id = 2, Nombre = "Ana Maria", Rut = "22-2", FechaNacimiento = new DateTime(1992, 8, 15)}
        };

        public PacientesController(IServicioDeAuditoria servicioAuditoria)
        {
            _servicioAuditoria = servicioAuditoria;
        }

        public IActionResult Index()
        {
            return View(_pacientes);
        }

        public IActionResult VerFicha()
        {
            _servicioAuditoria.RegistrarAccion($"Consulta de ficha para paciente.");
            return View();
        }

        // GET: /Pacientes/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Pacientes/Crear
        [HttpPost]
        public IActionResult Crear(Paciente nuevoPaciente)
        {
            if (ModelState.IsValid)
            {
                nuevoPaciente.Id = _pacientes.Max(p => p.Id) + 1;
                _pacientes.Add(nuevoPaciente);
                return RedirectToAction("Index");
            }
            return View(nuevoPaciente);
        }
    }
}
