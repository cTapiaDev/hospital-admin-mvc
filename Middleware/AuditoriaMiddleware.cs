using HospitalAdminMVC.Services;

namespace HospitalAdminMVC.Middleware
{
    public class AuditoriaMiddleware
    {
        private readonly RequestDelegate _next;

        public AuditoriaMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IServicioDeAuditoria auditoria)
        {
            if (context.Request.Path.ToString().ToLower().Contains("/pacientes"))
            {
                auditoria.RegistrarAccion($"Acceso detectado a la sección pacientes. Ruta: {context.Request.Path}");
            }

            await _next(context);
        }
    }
}
