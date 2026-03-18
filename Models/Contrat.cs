using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("Contrat")]
public partial class Contrat
{
    [Key]
    [Column("ContratID")]
    public int ContratId { get; set; }

    [Column("SalarieID")]
    public int? SalarieId { get; set; }

    [StringLength(50)]
    public string? TypeContrat { get; set; }

    [StringLength(100)]
    public string? Poste { get; set; }

    [StringLength(100)]
    public string? Service { get; set; }

    public DateOnly? DateDebut { get; set; }

    public DateOnly? DateFin { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SalaireBase { get; set; }

    [StringLength(50)]
    public string? Statut { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreation { get; set; }

    [ForeignKey("SalarieId")]
    [InverseProperty("Contrats")]
    public virtual Salarie? Salarie { get; set; }
}
