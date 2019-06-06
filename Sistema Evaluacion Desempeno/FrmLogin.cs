using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Evaluacion_Desempeno
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmMenuPrincipal irLogin = new FrmMenuPrincipal();
          
            irLogin.Show();
            

        }
    }
}
