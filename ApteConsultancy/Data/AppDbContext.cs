using ApteConsultancy.Models.Master;
using ApteConsultancy.Models;
using ApteConsultancyWEB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ApteConsultancy.Model.Master;

namespace ApteConsultancy.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //  public DbSet<ApplicationUser> applicationUsers { get; set; }
  
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        //end master
        public DbSet<Associate_Fee> Associate_Fees { get; set; }
        public DbSet<AssociateWorkerOrders> AssociateWorkerOrders { get; set; }
        public DbSet<Drawing> Drawings { get; set; }
        public DbSet<DrawingRevision> DrawingRevisions { get; set; }
        public DbSet<Employee_Attendance> Employee_Attendances { get; set; }
        public DbSet<EmployeeTimeSheet> EmployeeTimeSheets { get; set; }
        public DbSet<GSTInvoice> GSTInvoices { get; set; }
        public DbSet<OwnCarLocalAndOutStation> OwnCarLocalAndOutStations { get; set; }
        public DbSet<ProformaInvoice> ProformaInvoices { get; set; }
        public DbSet<ProjectFees> ProjectFees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
