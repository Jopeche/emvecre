using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            //conexion a la base de datos
            ConexSQL.conectar();

            //crea las tablas en la base de datos en caso de que no existan

            crearTablas.crear_tabla_articulos(); //creacion de la tabla Articulos
            crearTablas.crear_tabla_clientes(); //creacion de la tabla Clientes
            crearTablas.crear_tabla_departamentos(); //creacion de la tabla Departamento
            crearTablas.crear_tabla_detalle_compra(); //creacion de la tabla detalle_Compras
            crearTablas.crear_tabla_compra(); //creacion de la tabla Compra
            crearTablas.crear_tabla_proveedor(); //creacion de la tabla Proveedor
            crearTablas.crear_tabla_vendedor(); //creacion de la tabla Vendedor
            crearTablas.crear_tabla_ventas(); //creacion de la tabla Ventas
            crearTablas.crear_tabla_detalle_ventas(); //creacion de la tabla Detalle ventas
            crearTablas.crearusuarios(); //creacion de la tabla usuarios                              
            crearTablas.crear_tabla_cierre_caja(); //Creacion de la tabla cierre de caja
            crearTablas.crear_tabla_retiros(); //Creacion de la tabla de retiros de efectivo
            crearVistas.crearVistas1(); //creacion de las vistas para los reportes

            iniciarProyecto();
        }
        public void iniciarProyecto()
        {
            ConexTablas ct = new ConexTablas();
            DateTime dateTime = DateTime.Now;
            string sql = "select * from clientes";
            SqlDataReader miDr;
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows == false)
            {
                ct.guardarCliente("CLIENTE CONTADO", dateTime, "000000000", "", "", "");
                sql = "";
                miDr.Dispose();
            }

            sql = "select * from usuarios";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows == false)
            {
                ct.guardarUsuario("admin", "123", "Si");
                sql = "";
                miDr.Dispose();
            }

            sql = "select * from vendedor";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows == false)
            {
                ct.guardarVend("SISTEMA");
                sql = "";
                miDr.Dispose();
            }
            sql = "select * from departamento";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows == false)
            {
                ct.guardarDep("GENERAL", "Departamento general de articulos");
                sql = "";
                miDr.Dispose();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
    }

