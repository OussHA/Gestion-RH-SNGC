using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("Utilisateur")]
[Index("NomUtilisateur", Name = "UQ__Utilisat__49EDB0E53CF0B2F6", IsUnique = true)]
public partial class Utilisateur
{
    [Key]
    [Column("UtilisateurID")]
    public int UtilisateurId { get; set; }

    [StringLength(50)]
    public string? NomUtilisateur { get; set; }

    [StringLength(255)]
    public string? MotDePasseHash { get; set; }

    [StringLength(50)]
    public string? Role { get; set; }

    [Column("SalarieID")]
    public int? SalarieId { get; set; }

    public bool? Actif { get; set; }

    [ForeignKey("SalarieId")]
    [InverseProperty("Utilisateurs")]
    public virtual Salarie? Salarie { get; set; }
}
