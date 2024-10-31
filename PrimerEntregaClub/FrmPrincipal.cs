using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrimerEntregaClub
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro ventanaRegistro = new FrmRegistro();

            ventanaRegistro.Show();//Se llama al de registro
            this.Hide(); //se oculta al formulario principal
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagar ventanaDePago = new frmPagar();

            ventanaDePago.Show();
            this.Hide();
        }
    }
}
