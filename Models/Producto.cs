using System;
using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Key]  // Asegúrate de agregar el atributo [Key]
    public int IdProducto { get; set; }  // Clave primaria

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    public decimal Precio { get; set; }

    public int Stock { get; set; }  // Inventario actual del producto
}
