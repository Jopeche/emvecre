using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emvecre;

namespace emvecre
{
    internal class Facturas 
    {
        ElemenFactura elemnFact = new ElemenFactura();

        Dictionary<string, string> factura = new Dictionary<string, string>();


        public bool llenarFactura(ElemenFactura elementos, DataGridView datos)
        {
           
            bool estado = false;

            if (factura!=null)
            {
                factura.Add("cliente", elementos.Cliente);
                factura.Add("Vendedor", elementos.Vendedor);
                factura.Add("subtotal", elementos.Subtotal.ToString());
                factura.Add("impuesto", elementos.Impuesto.ToString());
                factura.Add("total", elementos.Total.ToString());

                foreach (DataGridViewRow items in datos.Rows)
                {
                    factura.Add("codigo",items.Cells["Codigo"].ToString());
                    factura.Add("descripcion", items.Cells["Descripcion"].ToString());
                    factura.Add("precio", items.Cells["Precio"].ToString());
                    factura.Add("cantidad", items.Cells["Cantidad"].ToString());
                    factura.Add("descuento", items.Cells["Descuento"].ToString());
                    factura.Add("stotal", items.Cells["Subtotal"].ToString());

                }
                estado = true;
            }
           

            return estado;
        }

        public void obtenerFactura(ElemenFactura elementos, TextBox cliente)
        {
            factura.TryGetValue("cliente", cliente.Text);

        }

    }

    
   

}
