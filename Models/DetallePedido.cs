using System.ComponentModel.DataAnnotations;

public class DetallePedido
{
    public int Id { get; set; }  // Clave primaria

    // Otras propiedades
    public int PedidoId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }

    // Relaciones (si las tienes definidas)
    public Pedido Pedido { get; set; }
    public Producto Producto { get; set; }
}
