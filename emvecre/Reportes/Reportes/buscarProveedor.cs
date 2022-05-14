using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class buscarProveedor : Form
    {
        //crear variable de instancia para acceder a la case CONEXTABLAS
        ConexTablas ct = new ConexTablas();
        public buscarProveedor()
        {
            InitializeComponent();
        }

        //boton para buscar proveedores en la base de datos
        private void buscarProveedor_Load(object sender, EventArgs e)
        {
            //metodo para cargar metodos en el datagridview
            ct.cargarProveedores(dgvProveedores);
        }

        //casa de texto para buscar los proveedores
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            try {
                //llamado al metodo para buscar los proveedores
                bool resulta = ct.buscarProveedores(dgvProveedores, txtProveedor.Text);

                if (txtProveedor.Text == "")//si la caja de texto proveedores esta vacia se cargan todos los proveedores
                {

                    ct.cargarProveedores(dgvProveedores);//carga de todos los proveedores
                }
            }
            catch { }
        }

        //boton para selecionar el proveedor selecionado en el fdatagridview
        private void bntSelecionar_Click(object sender, EventArgs e)
        {

            Compras f1 = Application.OpenForms.OfType<Compras>().SingleOrDefault();//contiene el formulario abierto de la aplicacion

            if (f1 != null)
            {

                f1.txtProveedor.Text = dgvProveedores.CurrentRow.Cells["RAZON SOCIAL"].Value.ToString();//llena la caja de texto en el formulario abierto con el valor en el compo razon social selecionado
                this.Close(); //Cierro el form2
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Silver;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Compras f1 = Application.OpenForms.OfType<Compras>().SingleOrDefault();//contiene el formulario abierto de la aplicacion

            if (f1 != null)
            {

                f1.txtProveedor.Text = dgvProveedores.CurrentRow.Cells["RAZON SOCIAL"].Value.ToString();//llena la caja de texto en el formulario abierto con el valor en el compo razon social selecionado
                this.Close(); //Cierro el form2
                     
            }
            
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {

            btnAceptar.BackColor = Color.LightBlue;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Silver;
        }
    }
}
