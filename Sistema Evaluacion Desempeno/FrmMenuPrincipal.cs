﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEmpleados irEmpleados = new FrmEmpleados();
            gbPerfil.Visible = false;
            irEmpleados.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            FrmDepartamento irDepartamentos = new FrmDepartamento();
            irDepartamentos.Show();
        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            FrmPosiciones frm = new FrmPosiciones();
            frm.Show();
        }

        private void btnFactores_Click(object sender, EventArgs e)
        {
            FactoresFrm frm = new FactoresFrm();
            frm.Show();
        }

        private void btnFactoresDescripcion_Click(object sender, EventArgs e)
        {
            FrmFactoresDescripcion frm = new FrmFactoresDescripcion();
            frm.Show();
        }

        private void btnManejarEvaluacion_Click(object sender, EventArgs e)
        {

        }

        private void btnManejarPerfil_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void btnManejarPerfil_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnManejarPerfil_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        private void btnManejarPerfil_Click(object sender, EventArgs e)
        {
            gbPerfil.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmPerfil irPerfil = new FrmPerfil();
            irPerfil.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLlenarPerfil irperfilllenar = new FrmLlenarPerfil();
            irperfilllenar.ShowDialog();
        }
    }
}
