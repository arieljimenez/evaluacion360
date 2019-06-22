using System;
using Logica;
using Entidades;
using System.Windows.Forms;

namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrmFactoresDescripcion : Form
    {
        FactoresDescripcionBL fdBL = new FactoresDescripcionBL();
        bool isEditing = false;
        FactoresDescripcion currentFD = null;

        public FrmFactoresDescripcion()
        {
            InitializeComponent();
            resetFrm();
        }

        private void resetFrm()
        {
            isEditing = false;
            btnAceptar.Text = "Insertar";

            refreshDGV();
            txtFactorDescripcion.Text = "";
        }

        private void refreshDGV()
        {
            dgvFactoresDescripciones.DataSource = fdBL.DTFactoresDescripciones();
        }

        private void llenarFactores()
        {
            FactorBL factBL = new FactorBL();

            cbFactores.DataSource = factBL.DTFactores();

            cbFactores.DisplayMember = "nombre_factor";
            cbFactores.ValueMember = "id_factor";
            cbFactores.DropDownStyle = ComboBoxStyle.DropDownList;
        }                
      
        private void FrmFactoresDescripcion_Load(object sender, EventArgs e)
        {
            llenarFactores();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtFactorDescripcion.TextLength > 0)
            {
                bool result = false;
                string dynamicText = isEditing ? "Editada" : "Agregada";

                if (isEditing)
                {
                    result = fdBL.editarDescripcionFactor(currentFD);

                } else
                {
                    FactoresDescripcion fd = new FactoresDescripcion(
                        txtFactorDescripcion.Text,
                        int.Parse(cbFactores.SelectedValue.ToString())
                    );

                    result = fdBL.insertarDescripcionFactor(fd);
                }
               

                if (result)
                {
                    MessageBox.Show("Descripcion " + dynamicText + " con exito.",
                        "Factor " + dynamicText,
                        MessageBoxButtons.OK
                    );

                    resetFrm();
                }
                else
                {
                    MessageBox.Show("No se pudo " + dynamicText + " la descripcion.",
                        "Hubo un Problema",
                        MessageBoxButtons.OK
                    );
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetFrm();
        }

        private void dgvFactoresDescripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactoresDescripciones[e.ColumnIndex, 0].Value.ToString() != "")
            {                

                currentFD = new FactoresDescripcion(
                    int.Parse(dgvFactoresDescripciones[0, e.RowIndex].Value.ToString()),
                    dgvFactoresDescripciones[1, e.RowIndex].Value.ToString(),
                    int.Parse(dgvFactoresDescripciones[2, e.RowIndex].Value.ToString())
                );

                isEditing = true;
                btnAceptar.Text = "Editar";

                txtFactorDescripcion.Text = currentFD.descripcion;
                cbFactores.SelectedValue = currentFD.factor;

            }
        }
    }
}
