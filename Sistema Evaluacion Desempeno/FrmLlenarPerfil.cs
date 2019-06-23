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
    public partial class FrmLlenarPerfil : Form
    {
        DataGeneral ds = new DataGeneral();
        DataGeneralTableAdapters.posicionesTableAdapter consulta = new DataGeneralTableAdapters.posicionesTableAdapter();

        public FrmLlenarPerfil()
        {
            InitializeComponent();
        }
        public bool validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                valor = true;
            }
            return valor;
        }


       int codigo_posicion;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    PerfilBL EMP = new PerfilBL();
                    Perfil entidades = new Perfil();



                    entidades.codigo_perfil= Convert.ToInt32( textBox2.Text);
                    entidades.codigo_posicion = codigo_posicion;
                    entidades.descripcion_competencia = textBox1.Text;
                   

                    EMP.RegPerfil(entidades);



                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    textBox1.Focus();
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

        private void FrmLlenarPerfil_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            consulta.Fill(ds.posiciones);
            cbPosiciones.DataSource = ds.posiciones;
            cbPosiciones.DisplayMember = "nombre_posicion";
            cbPosiciones.ValueMember = "id_posicion";
            codigo_posicion = int.Parse(cbPosiciones.SelectedValue.ToString());

        }

        private void cbPosiciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
