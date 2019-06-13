using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Logica;
using Entidades;

namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }
        int ID = 0;

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }

        public bool validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                valor = true;
            }
            return valor;
        }
      
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                   DepartamentosBL DEPA = new DepartamentosBL();
                    Departamentos entidades = new Departamentos();


                    //if (txtNombre.Text == string.Empty)
                    //    txtNombre.Text = null;
                    if (txtCodigo.Text.Equals("")) {

                        txtCodigo.Text = "0";
                    }
                    

                    entidades.codigo_departamento = Convert.ToInt16(txtCodigo.Text);
                    entidades.descripcion_departamento = txtNombre.Text;
                   

                    DEPA.RegDepartamentos(entidades);


                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtNombre.Clear();
                    btnNuevo.PerformClick();
                    

                 
                }
                else
                {
                    MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                throw;
            }

        }
        string ValorBuscar = "Departamento";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmBusqueda irBusqueda = new FrmBusqueda();
            irBusqueda.valorBuscar = ValorBuscar;
            irBusqueda.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
