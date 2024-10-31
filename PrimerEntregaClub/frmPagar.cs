using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PrimerEntregaClub;
using PrimerEntregaClub.Datos;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEntregaClub
{
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            frmPrincipal ventanaPrincipal = new frmPrincipal();

            this.Hide(); //se oculta esta ventana
            ventanaPrincipal.Show();//Se llama al formulario anterior que era el principal
        }
    }
}
