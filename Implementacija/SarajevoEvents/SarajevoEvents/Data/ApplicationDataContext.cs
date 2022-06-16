using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SarajevoEvents.Models;

public class ApplicationDataContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
        : base(options)
    {
    }

    public DbSet<SarajevoEvents.Models.PoslovniKorisnik>? PoslovniKorisnik { get; set; }
    public DbSet<SarajevoEvents.Models.Feedback>? Feedback { get; set; }
    public DbSet<SarajevoEvents.Models.RegistrovaniKorisnik>? RegistrovaniKorisnik { get; set; }
    public DbSet<SarajevoEvents.Models.Dogadjaj>? Dogadjaj {get; set;}
    public DbSet<SarajevoEvents.Models.Placanje>? Placanje {get; set;}
    public DbSet<SarajevoEvents.Models.Popust>? Popust {get; set;}
    public DbSet<SarajevoEvents.Models.Karta>? Karta {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SarajevoEvents.Models.PoslovniKorisnik>().ToTable("PoslovniKorisnik");
        modelBuilder.Entity<SarajevoEvents.Models.Feedback>().ToTable("Feedback");
        modelBuilder.Entity<SarajevoEvents.Models.RegistrovaniKorisnik>().ToTable("RegistrovaniKorisnik");
        modelBuilder.Entity<SarajevoEvents.Models.Dogadjaj>().ToTable("Dogadjaj");
        modelBuilder.Entity<SarajevoEvents.Models.Placanje>().ToTable("Placanje");
        modelBuilder.Entity<SarajevoEvents.Models.Popust>().ToTable("Popust");
        modelBuilder.Entity<SarajevoEvents.Models.Karta>().ToTable("Karta");
        base.OnModelCreating(modelBuilder);
    }
}
