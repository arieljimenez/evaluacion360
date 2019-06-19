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
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        public void LlenarGridDepartamento()
        {
            DepartamentosBL Depart = new DepartamentosBL();

            dgvBusqueda.DataSource = Depart.LlenarDepartamento();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public  string valorBuscar;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (valorBuscar == "Departamentos")
            {

                DepartamentosBL busqueda = new DepartamentosBL();
                dgvBusqueda.DataSource = busqueda.BusquedaDepartamento(comboBox1.Text, "Nombre");
           
            }
            else if (valorBuscar == "Empleado") {
                
            }
        }
        public void LlenarGrid()
        {
            EmpleadosBL cli = new EmpleadosBL();

            dgvBusqueda.DataSource = cli.LlenarEmpleados();
        }
        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (valorBuscar == "Empleados")
            {

            }
            else if (valorBuscar == "Departamento")
            {

            }
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            footer.Text = (valorBuscar);
            if (valorBuscar == "Empleado"){
                LlenarGrid();
            }
            else if (valorBuscar == "Departamento"){
                LlenarGridDepartamento();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
