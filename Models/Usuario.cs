using System;
using System.ComponentModel.DataAnnotations;

public class Usuario
{
    public int IdUsuario { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [EmailAddress]
    public string CorreoElectronico { get; set; }

    [Required]
    public string Contraseña { get; set; }

    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
}
