using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Intranet_APP.Models;

[Table("Document")]
public partial class Document
{
    [Key]
    [Column("DocumentID")]
    public int DocumentId { get; set; }

    [Column("SalarieID")]
    public int? SalarieId { get; set; }

    [StringLength(50)]
    public string? TypeDocument { get; set; }

    [StringLength(255)]
    public string? NomFichier { get; set; }

    [StringLength(255)]
    public string? PathFichier { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateAjout { get; set; }

    [ForeignKey("SalarieId")]
    [InverseProperty("Documents")]
    public virtual Salarie? Salarie { get; set; }
}
