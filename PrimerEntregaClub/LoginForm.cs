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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); //variable que contiene todas las características de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                 /*quiere decir que el resultado tiene 1 fila, por lo que el usuario EXISTE
                  LO INFORMAMOS CON UN MSJ AL USUARIO */
                 MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, 
                     MessageBoxIcon.Information);
                /*Una vez que tenemos la conexion establecida PASAMOS AL FORMULARIO PRINCIPAL
                 Se debe "instanciar" un objeto de la clase formulario principal*/

                frmPrincipal ventanaPrincipal = new frmPrincipal();
                /*La siguiente línea permite tomar el dominio de la primera columna, de la primera fila
                 del resultado de la ejecución de la query
                para hacer referencia a un objeto que se encuentra en otro formulario,
                se antepone al objeto el nombre del formulario que lo contiene*/
                ventanaPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                ventanaPrincipal.usuario = Convert.ToString(txtUsuario.Text);

                ventanaPrincipal.Show();//Se llama al formulario principal
                this.Hide(); //se oculta al formulario de Login 
            }
            else
            {
                MessageBox.Show("Usuario y/o Password incorrecto");
            }
        }
            

           

    }
}
