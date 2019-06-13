using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrLogin : Form
    {
       Conectar  conectar = new Conectar();

        public FrLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", " Aviso ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cerrar Formulario
                Application.Exit();
            }
        }

        public static string nombre_usu;
        public static string usuario;
        public static int id_usu;
        public static Boolean status;
        private void button2_Click(object sender, EventArgs e)
        {
            conectar.abrir_conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado WHERE usuario='" + txtUsuario.Text + "' AND passwor='" + txtPassword.Text + "'", conectar.conectarsql);
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_usu = Convert.ToInt16(leer.GetValue(0));
                nombre_usu = Convert.ToString(leer.GetValue(1));
                usuario = Convert.ToString(leer.GetValue(6));
                
                 Boolean ManejarDepartamento = Convert.ToBoolean(leer.GetValue(10));
                 Boolean ManejarEmpleado = Convert.ToBoolean(leer.GetValue(11));
                //Boolean Parametro3 = Convert.ToBoolean(leer.GetValue(10));
                //Boolean Parametro4 = Convert.ToBoolean(leer.GetValue(11));
                //Boolean Parametro5 = Convert.ToBoolean(leer.GetValue(12));
                //Boolean Parametro6 = Convert.ToBoolean(leer.GetValue(13));
                //Boolean Parametro7 = Convert.ToBoolean(leer.GetValue(14));
                //Boolean Parametro8 = Convert.ToBoolean(leer.GetValue(15));
                //Boolean Parametro9 = Convert.ToBoolean(leer.GetValue(16));
                //Boolean Parametro10 = Convert.ToBoolean(leer.GetValue(17));
                //Boolean Parametro11 = Convert.ToBoolean(leer.GetValue(18));
                //Boolean Parametro12 = Convert.ToBoolean(leer.GetValue(19));
                //Boolean Parametro13 = Convert.ToBoolean(leer.GetValue(20));
                if (usuario == txtUsuario.Text)
                {
                    MessageBox.Show("Bienvenid@" + ' ' + nombre_usu);

                    FrmMenuPrincipal IrMenu = new FrmMenuPrincipal();

                     IrMenu.btnManejarDepartamento.Enabled = ManejarDepartamento;
                     IrMenu.btnManejarEmpleado.Enabled = ManejarEmpleado;
                    // IrMenu.btnCrearCitas.Enabled = Parametro3;
                    //IrMenu.btnConsulta.Enabled = Parametro4;
                    //IrMenu.btnBuscarOdontolog.Enabled = Parametro5;
                    //IrMenu.btnAgregarOdontologo.Enabled = Parametro6;
                    //IrMenu.btnAgregarOdontologo.Enabled = Parametro7;
                    //IrMenu.btnBuscarOdontolog.Enabled = Parametro8;
                    //IrMenu.btnCaja.Enabled = Parametro9;
                    //IrMenu.btnAdministracion.Enabled = Parametro10;
                    //IrMenu.btnMantenimiento.Enabled = Parametro11;
                    //IrMenu.btnBuscaOdontograma.Enabled = Parametro12;
                    //IrMenu.btnAgregarOdontograma.Enabled = Parametro13;

                    this.Hide();
                    IrMenu.Show();

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            conectar.Cerrar_conectar();


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
