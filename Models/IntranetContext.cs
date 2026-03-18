using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

public partial class IntranetContext : DbContext
{
    public IntranetContext()
    {
    }

    public IntranetContext(DbContextOptions<IntranetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BulletinPaie> BulletinPaies { get; set; }

    public virtual DbSet<Conge> Conges { get; set; }

    public virtual DbSet<Contrat> Contrats { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Salarie> Salaries { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=OUSS\\SQLEXPRESS;Database=Intranet_BDD;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BulletinPaie>(entity =>
        {
            entity.HasKey(e => e.BulletinId).HasName("PK__Bulletin__475B5173C5664640");

            entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Salarie).WithMany(p => p.BulletinPaies).HasConstraintName("FK__BulletinP__Salar__4316F928");
        });

        modelBuilder.Entity<Conge>(entity =>
        {
            entity.HasKey(e => e.CongeId).HasName("PK__Conge__3D850D741B6B4E3B");

            entity.Property(e => e.DateDemande).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Salarie).WithMany(p => p.Conges).HasConstraintName("FK__Conge__SalarieID__3F466844");
        });

        modelBuilder.Entity<Contrat>(entity =>
        {
            entity.HasKey(e => e.ContratId).HasName("PK__Contrat__65C1D96CDBE0E55A");

            entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Salarie).WithMany(p => p.Contrats).HasConstraintName("FK__Contrat__Salarie__3B75D760");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__Document__1ABEEF6F34A8F685");

            entity.Property(e => e.DateAjout).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Salarie).WithMany(p => p.Documents).HasConstraintName("FK__Document__Salari__46E78A0C");
        });

        modelBuilder.Entity<Salarie>(entity =>
        {
            entity.HasKey(e => e.SalarieId).HasName("PK__Salarie__56E28297B1DD0875");

            entity.Property(e => e.Actif).HasDefaultValue(true);
            entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.UtilisateurId).HasName("PK__Utilisat__6CB6AE1F9211B3BA");

            entity.Property(e => e.Actif).HasDefaultValue(true);

            entity.HasOne(d => d.Salarie).WithMany(p => p.Utilisateurs).HasConstraintName("FK__Utilisate__Salar__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
