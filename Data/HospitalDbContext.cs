using HospitalAdminMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAdminMVC.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }

    }
}
