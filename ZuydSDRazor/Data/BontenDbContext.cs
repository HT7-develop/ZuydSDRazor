using System;
using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Models;

namespace ZuydSDRazor.Data
{
    public class BontenDbContext : DbContext
    {
        public BontenDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Video> Videos { get; set; } = default!;
        public DbSet<Onderwerp> Onderwerpen { get; set; } = default!;
        public DbSet<Koppel> Koppels { get; set; } = default!;
    }
}

