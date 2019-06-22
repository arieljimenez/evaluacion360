using System;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrmPosiciones : Form
    {
        PosicionBL posBL = new PosicionBL();
        bool isEditing = false;
        Posicion currentPos = new Posicion("");

        public FrmPosiciones()
        {
            InitializeComponent();
            txtNombrePosicion.Focus();

            btnAceptar.Text = "Insertar";

        }

        private void FrmPosiciones_Load(object sender, EventArgs e)
        {

            refresDGV();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre_posicion = txtNombrePosicion.Text;
            string dynamicText = isEditing ? "Editada" : "Agregada";
            bool result = false;

            if (nombre_posicion != "")
            {
                Posicion pos = new Posicion(nombre_posicion);

                if (isEditing)
                {
                    if (currentPos.nombre_posicion != nombre_posicion)
                    {
                        currentPos.nombre_posicion = nombre_posicion;
                        result = posBL.editarPosicion(currentPos);
                    }
                    
                } else
                {
                    result = posBL.insertarPosicion(pos);
                }

                if (result){
                    MessageBox.Show("Posicion "+ dynamicText +" con exito.", 
                        "Posicion "+ dynamicText,
                        MessageBoxButtons.OK
                    );

                    
                } else
                {
                    MessageBox.Show("No se pudo " + dynamicText + " la posicion.",
                        "Hubo un Problema",
                        MessageBoxButtons.OK
                    );
                }

                
            }

            resetForm();
        }

        private void refresDGV()
        {
            dgvPosiciones.DataSource = posBL.DTPosiciones();
        }

        private void resetForm()
        {
            txtNombrePosicion.Clear();
            isEditing = false;
            btnAceptar.Text = "Insertar";
            refresDGV();

            //deselect the dgv
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombrePosicion.Clear();
            isEditing = false;
            btnAceptar.Text = "Insertar";
        }

        private void dgvPosiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvPosiciones[e.ColumnIndex, 0].Value.ToString() != "")
            {
                isEditing = true;
                btnAceptar.Text = "Editar";

                currentPos = new Posicion(
                    int.Parse(dgvPosiciones[0, e.RowIndex].Value.ToString()),
                    dgvPosiciones[1, e.RowIndex].Value.ToString(), 
                    Boolean.Parse(dgvPosiciones[2, e.RowIndex].Value.ToString())
                );

                txtNombrePosicion.Text = currentPos.nombre_posicion;
            } 
        }
    }
}
