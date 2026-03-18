using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("BulletinPaie")]
public partial class BulletinPaie
{
    [Key]
    [Column("BulletinID")]
    public int BulletinId { get; set; }

    [Column("SalarieID")]
    public int? SalarieId { get; set; }

    public short? Mois { get; set; }

    public short? Annee { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SalaireBrut { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Cotisations { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Prime { get; set; }

    [Column("NetAPayer", TypeName = "decimal(10, 2)")]
    public decimal? NetApayer { get; set; }

    [Column("PathPDF")]
    [StringLength(255)]
    public string? PathPdf { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreation { get; set; }

    [ForeignKey("SalarieId")]
    [InverseProperty("BulletinPaies")]
    public virtual Salarie? Salarie { get; set; }
}
