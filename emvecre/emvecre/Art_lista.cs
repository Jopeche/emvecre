
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace emvecre
{
    public partial class Art_lista : Form
    {
        //variable de instancia para acceder a la clase donde se realiza las conexiones a la base de datos
        ConexTablas ct = new ConexTablas();

        public Art_lista()
        {
            InitializeComponent();

            //conecta a la base de datos
            ConexSQL.conectar();
        }


        //metodo para darle color al boton cuando el cursor esta sobre él
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }
        ////metodo para darle color al boton cuando el cursor  NO esta sobre él
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
        }

      
        //metodo para darle color al boton cuando el cursor esta sobre él
        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.LightBlue;
        }
        //metodo para darle color al boton cuando el cursor NO esta sobre él
        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.White;
        }
    
        //cargar los articulos guardados en la base de datos
        private void Art_lista_Load(object sender, EventArgs e)
        {

            ct.MostrarDatos(dgvArticulos);

        }

        //busca el articulo en la base de datos por nombre y lo carga en el datagridview
        private void txtArticulo_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                ConexTablas ct = new ConexTablas();
                bool resulta = ct.buscarArticulos(dgvArticulos, txtArticulo.Text);


                if (txtArticulo.Text == "")
                {

                    ct.buscarArticulos(dgvArticulos, txtArticulo.Text);
                }

            }
            catch { }
        }

        //Se toma el articulo de la lista deseado y se guarda para el otro formulario(COMPRAS).
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Ingresar_compra f1 = Application.OpenForms.OfType<Ingresar_compra>().SingleOrDefault();

                if (f1 != null)
                {

                    f1.txtArticulo.Text = dgvArticulos.CurrentRow.Cells["Codigo 1"].Value.ToString();
                    f1.txtPrecio.Text = dgvArticulos.CurrentRow.Cells["costo"].Value.ToString();
                    f1.txtCantidad.Select();
                    txtArticulo.Text = "";
                    this.Close(); //Cierro el form2
                }
            }
            catch { }
        }

        //cierra el formulario
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Se toma el articulo de la lista deseado y se guarda para el otro formulario (Facturacion).
        private void btnArtFactu_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();

                if (f1 != null)
                {

                    f1.txtArticulo.Text = dgvArticulos.CurrentRow.Cells["Codigo 1"].Value.ToString();
                    f1.txtArticulo.Select();
                    txtArticulo.Text = "";
                    this.Close(); //Cierro el form2
                }
            }
            catch { }
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
    }

