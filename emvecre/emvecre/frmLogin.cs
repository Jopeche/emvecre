using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emvecre
{
    
    public partial class frmLogin : Form
    {
        //variable de instancia para acceder a la clase de tablas
        ConexTablas ct = new ConexTablas();
        frmMenuPrincipal mp = new frmMenuPrincipal();
        public frmLogin()
        {
            InitializeComponent();
            //abre la coneccion a la base de datos
            ConexSQL.conectar();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.DarkGray;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.LightBlue;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.DarkGray;
        }

        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //verifica si el usuario es de tipo administrador
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           bool resulta = ct.loguear(txtUsuario.Text, txtContrasena.Text);

            if (resulta==true) {
                if (ConexTablas.admin=="Si")
                {
                    mp.btnUsuarios.Visible = true;

                }
                else
                {
                    mp.btnUsuarios.Visible = false;
                }
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña es incorrecto...!!!");

            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        //cambia el foco a la caja de texto de contraseña
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtContrasena.Focus();
            }

        }

        //verifica la informacion para el acceso del usuario (usuario, contraseña)
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                bool resulta = ct.loguear(txtUsuario.Text, txtContrasena.Text);

                if (resulta == true)
                {
                    mp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña es incorrecto...!!!");
                    txtContrasena.Text = "";
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                }
            }
        }
    }
    }

