using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEntregaClub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void controlUsuario()
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtUsuario, "");
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "Debe introducir su usuario");
                
                btnIngresar.Enabled = false;
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            controlUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Menu ventanaMenu = new Menu();
            ventanaMenu.ShowDialog();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
