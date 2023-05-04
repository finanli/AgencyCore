using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using AgencyCore.Models;

namespace AgencyCore.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
        }
        public virtual DbSet<Calisanlar> Calisanlars { get; set;}
        public virtual DbSet<Hizmetler> Hizmetlers { get; set;}
        public virtual DbSet<Musteriler> Musterlers { get; set;}
        public virtual DbSet<Projeler> Projelers { get; set;}

    }
}
