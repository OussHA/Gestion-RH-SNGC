using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("Salarie")]
public partial class Salarie
{
    [Key]
    [Column("SalarieID")]
    public int SalarieId { get; set; }

    [StringLength(100)]
    public string? Nom { get; set; }

    [StringLength(100)]
    public string? Prenom { get; set; }

    public DateOnly? DateNaissance { get; set; }

    [StringLength(255)]
    public string? Adresse { get; set; }

    [StringLength(10)]
    public string? CodePostal { get; set; }

    [StringLength(100)]
    public string? Ville { get; set; }

    [StringLength(20)]
    public string? Telephone { get; set; }

    [StringLength(150)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? NumSecu { get; set; }

    [StringLength(50)]
    public string? StatutFamilial { get; set; }

    [StringLength(255)]
    public string? PhotoPath { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreation { get; set; }

    public bool? Actif { get; set; }

    public int? JoursCongesAcquis { get; set; }

    [Column("JoursRTTAcquis")]
    public int? JoursRttacquis { get; set; }

    public DateOnly DateEmbauche { get; set; }

    [InverseProperty("Salarie")]
    public virtual ICollection<BulletinPaie> BulletinPaies { get; set; } = new List<BulletinPaie>();

    [InverseProperty("Salarie")]
    public virtual ICollection<Conge> Conges { get; set; } = new List<Conge>();

    [InverseProperty("Salarie")]
    public virtual ICollection<Contrat> Contrats { get; set; } = new List<Contrat>();

    [InverseProperty("Salarie")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("Salarie")]
    public virtual ICollection<Utilisateur> Utilisateurs { get; set; } = new List<Utilisateur>();
}
