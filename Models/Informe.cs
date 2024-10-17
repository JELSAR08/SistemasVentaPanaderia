using System;
using System.ComponentModel.DataAnnotations;

public class Reporte
{
    public int IdReporte { get; set; }

    [Required]
    [StringLength(50)]
    public string TipoReporte { get; set; }

    public DateTime FechaGeneracion { get; set; } = DateTime.Now;

    public string ContenidoReporte { get; set; }
}
