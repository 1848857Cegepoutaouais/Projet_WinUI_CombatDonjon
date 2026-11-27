using Microsoft.EntityFrameworkCore;
using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_WinUI_CombatDonjon.Data
{
    public class CombatDonjonDbContext : DbContext
    {
        public CombatDonjonDbContext(DbContextOptions<CombatDonjonDbContext> options) : base(options)
        {
        }

        public CombatDonjonDbContext() : base()
        {
        }

        public DbSet<Partie> Parties { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Donjon> Donjons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                //Chemin C:\Users\<nom>\CombatDonjon\combatDonjon.db
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "CombatDonjon", "combatDonjon.db");

                // Crée le fichier si nécessaire
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

                // Configure SQLite avec le chemin
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relation Partie-Donjon
            modelBuilder.Entity<Partie>()
                .HasOne<Donjon>(p => p.PartieDonjon)
                .WithOne(d => d.Partie)
                .HasForeignKey<Donjon>(p => p.DonjonId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relation Partie-Joueurs
            modelBuilder.Entity<Partie>()
                .HasMany<Joueur>(p => p.Joueurs)
                .WithOne(j => j.Partie)
                .HasForeignKey(j => j.PartieId)
                .OnDelete(DeleteBehavior.Cascade);

            // TODO À continuer
        }
    }
}
