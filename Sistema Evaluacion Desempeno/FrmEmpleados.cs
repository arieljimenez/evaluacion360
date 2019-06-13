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
    public partial class FrmEmpleados : Form
    {

        DataGeneral ds = new DataGeneral();
        DataGeneralTableAdapters.departamentosTableAdapter consulta = new DataGeneralTableAdapters.departamentosTableAdapter();
       


        public FrmEmpleados()
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

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDireccion.Text) && !string.IsNullOrWhiteSpace(txtCedula.Text) && txtContrasena.Text != txtContrasena2.Text)
            {
                valor = true;
            }
            return valor;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmBusqueda irBusqueda = new FrmBusqueda();
            irBusqueda.valorBuscar = "Empleado";
            irBusqueda.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(txtCodigo, txtNombre, txtApellido, txtCedula, txtDireccion, txtUsuario, txtContrasena, txtContrasena2);

            ckEncargado.Checked = false;
            cbDepartamento2.Checked = false;
            cbEmpleado.Checked = false;
            cbPerfil.Checked = false;
            cbClasificacion.Checked = false;
            cbCompetencia.Checked = false;
            cbEvaluacion.Checked = false;
            cbFrecuencia.Checked = false;

            txtNombre.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID < 1)
                {
                    MessageBox.Show("Debe seleccionar un registro valido antes de eliminar." +
                    " Por favor seleccione un registro en la pestaña de busqueda que desea eliminar "
                      + "y vuelva a intentarlo.", "Error de eliminación",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Realmente desea eliminar el registro de nombre: " + txtNombre.Text + "?",
                                      "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    //if (resultado == DialogResult.Yes)
                    //{

                    //    Clientes entidad = new Clientes();
                    //    entidad.ID = ID;
                    //    ClientesBL eliminar = new ClientesBL();

                    //    eliminar.EliminarClientes(entidad);
                    //    dgvClientes.Update();
                    //    LlenarGrid();
                    //    MessageBox.Show("Registro Eliminado.", "Eliminación", MessageBoxButtons.OK,
                    // MessageBoxIcon.Information);
                    //    BtnNuevo.PerformClick();
                    //    tabControl1.SelectedIndex = 1;
                    //}
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        Boolean encargado = false;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    EmpleadosBL EMP = new EmpleadosBL();
                    Empleados entidades = new Empleados();


                    if (txtNombre.Text == string.Empty)
                        txtNombre.Text = null;


                    entidades.nombre_empleado = txtNombre.Text;
                    entidades.apellido_empleado = txtApellido.Text;
                    entidades.cedula_empleado = txtCedula.Text;
                    entidades.fecha_empleado = dtFecha.Text;
                    if (ckEncargado.Checked == true) {
                        encargado = true;
                    }
                    entidades.encargado_empleado = encargado;
                    entidades.codigo_Departamento = Convert.ToUInt16 (valorCbDeparmanto);

                    entidades.usuario = txtUsuario.Text;
                    entidades.passwor = txtContrasena.Text;

                    entidades.ManejarDepartamento = CbDepartamentoCk;
                    entidades.ManejarEmpleado = CbEmpleadoCk;
                    entidades.ManejarPerfil = CbPerfilCk;
                    entidades.ManejarClasificacion = CbClasificacionCk;
                    entidades.ManejarCompetencia = CbCompetenciaCk;
                    entidades.ManejarEvaluacion = CbEvaluacionCk;
                    entidades.ManejarFrecuencia = CbFrecuenciaCk;

                    EMP.RegEmpleados(entidades);


                    
                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    btnNuevo.PerformClick();
                    tabControl1.SelectedIndex = 1;
                    txtNombre.Focus();
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


        string valorCbDeparmanto;
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            consulta.Fill(ds.departamentos);
            cbDepartamento.DataSource = ds.departamentos;
            cbDepartamento.DisplayMember = "descripcion_departamento";
            cbDepartamento.ValueMember = "codigo_departamento";
            valorCbDeparmanto = (cbDepartamento.SelectedValue.ToString());

           

        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        Boolean CbDepartamentoCk;
        private void cbDepartamento2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDepartamento2.Checked == true)
            {
                CbDepartamentoCk = true;
            }
            else {
                CbDepartamentoCk = false;
            }
        }
        Boolean CbEmpleadoCk;
        private void cbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmpleado.Checked == true)
            {
                CbEmpleadoCk = true;
            }
            else
            {
                CbEmpleadoCk = false;
            }
        }
        Boolean CbPerfilCk;
        private void cbPerfil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerfil.Checked == true)
            {
                CbPerfilCk = true;
            }
            else
            {
                CbPerfilCk = false;
            }
        }
        Boolean CbClasificacionCk;
        private void cbClasificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClasificacion.Checked == true)
            {
                CbClasificacionCk = true;
            }
            else
            {
                CbClasificacionCk = false;
            }
        }
        Boolean CbCompetenciaCk;
        private void cbCompetencia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCompetencia.Checked == true)
            {
                CbCompetenciaCk = true;
            }
            else
            {
                CbCompetenciaCk = false;
            }
        }
        Boolean CbEvaluacionCk;
        private void cbEvaluacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvaluacion.Checked == true)
            {
                CbEvaluacionCk = true;
            }
            else
            {
                CbEvaluacionCk = false;
            }
        }
        Boolean CbFrecuenciaCk;
         private void cbFrecuencia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFrecuencia.Checked == true)
            {
                CbFrecuenciaCk = true;
            }
            else
            {
                CbFrecuenciaCk = false;
            }
        }
    }
}
