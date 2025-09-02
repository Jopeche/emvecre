

namespace emvecre
{
    internal class ElemenFactura
    {
       private string cliente;
       private string vendedor;
       private double subtotal;
       private double impuesto;
       private double total;
 

        public string Cliente { get => cliente; set => cliente = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
        public double Total { get => total; set => total = value; }
    }
}
