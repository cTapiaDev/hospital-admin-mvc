namespace HospitalAdminMVC.Middleware
{
    public class RegistroDeActividadMiddleware
    {
        private readonly RequestDelegate _next;

        public RegistroDeActividadMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"[INFO] Solicitud entrante: {context.Request.Path}");

            await _next(context);

            Console.WriteLine($"[INFO] Solicitud saliente: {context.Response.StatusCode}");
        }
    }
}
