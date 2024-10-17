using System;
using System.ComponentModel.DataAnnotations;

public class Pedido
{
    public int Id { get; set; }  // Clave primaria

    // Otras propiedades
    public DateTime FechaPedido { get; set; }
    public int ClienteId { get; set; }
    public decimal Total { get; set; }

    // Relación con los detalles del pedido
    public ICollection<DetallePedido> DetallesPedido { get; set; }
    
    // Relación con cliente
    public class Cliente { 
    }
}
