namespace HospitalAdminMVC.Services
{
    public class ServicioDeAuditoria : IServicioDeAuditoria
    {
        public void RegistrarAccion(string mensaje)
        {
            Console.WriteLine($"[AUDITORIA] {mensaje} | {DateTime.Now}");
        }
    }
}
