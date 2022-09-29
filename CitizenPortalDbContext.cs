using Citizen_Portal.Models;
using Microsoft.EntityFrameworkCore;

public class CitizenPortalDbContext : DbContext
{
    public DbSet<Admin>? admin { get; set; }
    public DbSet<Complainant>? complainant { get; set; }
    public DbSet<Complainee>? complainee { get; set; }
    public DbSet<Complaint>? complaint { get; set; }
    //public CitizenPortalDbContext()
    //{

    //}

    //public CitizenPortalDbContext(DbContextOptions options) : base(options)
    //{
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CitiizenPortalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}