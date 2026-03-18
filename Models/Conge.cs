using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("Conge")]
public partial class Conge
{
    [Key]
    [Column("CongeID")]
    public int CongeId { get; set; }

    [Column("SalarieID")]
    public int? SalarieId { get; set; }

    [StringLength(50)]
    public string? TypeConge { get; set; }

    public DateOnly? DateDebut { get; set; }

    public DateOnly? DateFin { get; set; }

    [StringLength(50)]
    public string? Statut { get; set; }

    [StringLength(255)]
    public string? Commentaire { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateDemande { get; set; }

    [StringLength(50)]
    public string? Motif { get; set; }

    [ForeignKey("SalarieId")]
    [InverseProperty("Conges")]
    public virtual Salarie? Salarie { get; set; }
}
