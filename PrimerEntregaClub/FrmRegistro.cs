using PrimerEntregaClub.Entidades;
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
    public partial class FrmRegistro : Form
    {

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cboTipoDoc.Items.Add("DNI");
            cboTipoDoc.Items.Add("Pasaporte");
            cboTipoDoc.Items.Add("Extranjero");

        }
        //permite regresar al formulario principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventanaPrincipal = new frmPrincipal();

            this.Hide(); //se oculta esta ventana
            ventanaPrincipal.Show();//Se llama al formulario anterior que era el principal

        }
        //Limpiamos los campos para un nuevo ingreso
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipoDoc.Text = "";
            txtDoc.Text = "";
            dtFechaNac.Value = DateTime.Today;
            txtTel.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtNombre.Focus();

        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipoDoc.Text == "" 
                || txtDoc.Text == "" || txtTel.Text == "" || txtDomicilio.Text == ""
                || txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*)", " AVISO DEL SISTEMA ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string respuesta;

                E_Cliente client = new E_Cliente(); //instancio un objeto de la clase E_Cliente
                client.NombreC = txtNombre.Text;
                client.ApellidoC = txtApellido.Text;
                client.TDocC = cboTipoDoc.Text;
                client.DocC = txtDoc.Text;
                client.FechaNacC = dtFechaNac.Value;
                client.TelC = txtTel.Text;
                client.DomicilioC = txtDomicilio.Text;
                client.EmailC = txtEmail.Text;
                client.EsSocio = radSocio.Checked;

                //instanciamos para usar el método dentro de clientes

                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(client);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", " AVISO DEL SISTEMA ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito con el n° " + respuesta, " AVISO DEL SISTEMA ",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }
    }
}
