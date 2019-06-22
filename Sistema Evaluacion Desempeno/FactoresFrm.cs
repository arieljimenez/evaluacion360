using System;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Sistema_Evaluacion_Desempeno
{
    public partial class FactoresFrm : Form
    {
        FactorBL factBL = new FactorBL();
        bool isEditing = false;
        Factor currentfact = new Factor("");

        public FactoresFrm()
        {
            InitializeComponent();

            txtNombreFactor.Focus();
            btnAceptar.Text = "Insertar";
        }

        private void FrmFactores_Load(object sender, EventArgs e)
        {

            refresDGV();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre_factor = txtNombreFactor.Text;
            string dynamicText = isEditing ? "Editada" : "Agregada";
            bool result = false;

            if (nombre_factor != "")
            {
                Factor fact = new Factor(nombre_factor);

                if (isEditing)
                {
                    if (currentfact.nombre_factor != nombre_factor)
                    {
                        currentfact.nombre_factor = nombre_factor;
                        result = factBL.editarFactor(currentfact);
                    }

                }
                else
                {
                    result = factBL.insertarFactor(fact);
                }

                if (result)
                {
                    MessageBox.Show("Factor " + dynamicText + " con exito.",
                        "Factor " + dynamicText,
                        MessageBoxButtons.OK
                    );


                }
                else
                {
                    MessageBox.Show("No se pudo " + dynamicText + " la Factor.",
                        "Hubo un Problema",
                        MessageBoxButtons.OK
                    );
                }


            }

            resetForm();
        }

        private void refresDGV()
        {
            dgvFactores.DataSource = factBL.DTFactores();
        }

        private void resetForm()
        {
            txtNombreFactor.Clear();
            isEditing = false;
            btnAceptar.Text = "Insertar";
            refresDGV();

            //deselect the dgv
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dgvFactores_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvFactores[e.ColumnIndex, 0].Value.ToString() != "")
            {
                isEditing = true;
                btnAceptar.Text = "Editar";

                currentfact = new Factor(
                    int.Parse(dgvFactores[0, e.RowIndex].Value.ToString()),
                    dgvFactores[1, e.RowIndex].Value.ToString(),
                    Boolean.Parse(dgvFactores[2, e.RowIndex].Value.ToString())
                );

                txtNombreFactor.Text = currentfact.nombre_factor;
            }
        }
    }
}
