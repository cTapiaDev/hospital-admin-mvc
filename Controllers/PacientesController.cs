using HospitalAdminMVC.Data;
using HospitalAdminMVC.Models;
using HospitalAdminMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAdminMVC.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IServicioDeAuditoria _servicioAuditoria;

        //private static List<Paciente> _pacientes = new List<Paciente>
        //{
        //    new Paciente { Id = 1, Nombre = "Juan Pérez", Rut = "11-1", FechaNacimiento = new DateTime(1980, 5, 20)},
        //    new Paciente { Id = 2, Nombre = "Ana Maria", Rut = "22-2", FechaNacimiento = new DateTime(1992, 8, 15)}
        //};

        private readonly HospitalDbContext _context;

        public PacientesController(IServicioDeAuditoria servicioAuditoria, HospitalDbContext context)
        {
            _servicioAuditoria = servicioAuditoria;
            _context = context;
        }

        public IActionResult Index()
        {
            var pacientes = _context.Pacientes.ToList();
            return View(pacientes);
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
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Paciente nuevoPaciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Add(nuevoPaciente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nuevoPaciente);
        }

        // GET: /Pacientes/Detalles/5
        public IActionResult Detalles(int id)
        {
            var paciente = _context.Pacientes.Find(id);

            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: /Pacientes/Editar/5
        public IActionResult Editar(int id)
        {
            var paciente = _context.Pacientes.Find(id);

            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: /Pacientes/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Paciente pacienteEditado)
        {
            if (id != pacienteEditado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(pacienteEditado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pacienteEditado);
        }

        // GET: /Pacientes/Eliminar/5
        public IActionResult Eliminar(int id)
        {
            var paciente = _context.Pacientes.Find(id);

            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: /Pacientes/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarConfirmado(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
