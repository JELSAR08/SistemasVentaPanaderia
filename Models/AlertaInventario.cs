using System;
using System.ComponentModel.DataAnnotations;

public class AlertaInventario
{
    public int Id { get; set; }  // Clave primaria

    // Otras propiedades
    public int ProductoId { get; set; }
    public int CantidadRestante { get; set; }
    public DateTime FechaAlerta { get; set; }
}