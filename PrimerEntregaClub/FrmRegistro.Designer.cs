namespace PrimerEntregaClub
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistroCliente = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            cboTipoDoc = new System.Windows.Forms.ComboBox();
            lblTipo = new System.Windows.Forms.Label();
            lblDocumento = new System.Windows.Forms.Label();
            btnIngresarCliente = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            txtDoc = new System.Windows.Forms.TextBox();
            lblDomicilio = new System.Windows.Forms.Label();
            txtDomicilio = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblFechaNac = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtTel = new System.Windows.Forms.TextBox();
            dtFechaNac = new System.Windows.Forms.DateTimePicker();
            radSocio = new System.Windows.Forms.RadioButton();
            radNoSocio = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            lblTipoCliente = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            lblRegistroCliente.AutoSize = true;
            lblRegistroCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRegistroCliente.ForeColor = System.Drawing.Color.Blue;
            lblRegistroCliente.Location = new System.Drawing.Point(295, 44);
            lblRegistroCliente.Name = "lblRegistroCliente";
            lblRegistroCliente.Size = new System.Drawing.Size(245, 22);
            lblRegistroCliente.TabIndex = 0;
            lblRegistroCliente.Text = "REGISTRO DE CLIENTES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(169, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.Location = new System.Drawing.Point(256, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(239, 26);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellido.Location = new System.Drawing.Point(169, 157);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(69, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellido.Location = new System.Drawing.Point(256, 155);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(239, 26);
            txtApellido.TabIndex = 4;
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new System.Drawing.Point(256, 205);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new System.Drawing.Size(121, 26);
            cboTipoDoc.TabIndex = 5;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipo.Location = new System.Drawing.Point(194, 207);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(42, 20);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDocumento.Location = new System.Drawing.Point(391, 207);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(90, 20);
            lblDocumento.TabIndex = 7;
            lblDocumento.Text = "Documento:";
            // 
            // btnIngresarCliente
            // 
            btnIngresarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnIngresarCliente.ForeColor = System.Drawing.Color.DodgerBlue;
            btnIngresarCliente.Location = new System.Drawing.Point(86, 455);
            btnIngresarCliente.Name = "btnIngresarCliente";
            btnIngresarCliente.Size = new System.Drawing.Size(142, 44);
            btnIngresarCliente.TabIndex = 8;
            btnIngresarCliente.Text = "INGRESAR";
            btnIngresarCliente.UseVisualStyleBackColor = true;
            btnIngresarCliente.Click += btnIngresarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLimpiar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnLimpiar.Location = new System.Drawing.Point(327, 455);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(142, 44);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            btnVolver.Location = new System.Drawing.Point(546, 455);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(142, 44);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDoc
            // 
            txtDoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDoc.Location = new System.Drawing.Point(487, 207);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new System.Drawing.Size(239, 26);
            txtDoc.TabIndex = 11;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDomicilio.Location = new System.Drawing.Point(161, 349);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new System.Drawing.Size(77, 20);
            lblDomicilio.TabIndex = 12;
            lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDomicilio.Location = new System.Drawing.Point(256, 349);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new System.Drawing.Size(239, 26);
            txtDomicilio.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(189, 398);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(49, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(256, 396);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(239, 26);
            txtEmail.TabIndex = 15;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechaNac.Location = new System.Drawing.Point(86, 253);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new System.Drawing.Size(152, 20);
            lblFechaNac.TabIndex = 16;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(166, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 17;
            label2.Text = "Teléfono:";
            // 
            // txtTel
            // 
            txtTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTel.Location = new System.Drawing.Point(255, 298);
            txtTel.Name = "txtTel";
            txtTel.Size = new System.Drawing.Size(239, 26);
            txtTel.TabIndex = 18;
            // 
            // dtFechaNac
            // 
            dtFechaNac.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtFechaNac.Location = new System.Drawing.Point(255, 253);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new System.Drawing.Size(240, 23);
            dtFechaNac.TabIndex = 19;
            // 
            // radSocio
            // 
            radSocio.AutoSize = true;
            radSocio.Location = new System.Drawing.Point(32, 58);
            radSocio.Name = "radSocio";
            radSocio.Size = new System.Drawing.Size(54, 19);
            radSocio.TabIndex = 20;
            radSocio.TabStop = true;
            radSocio.Text = "Socio";
            radSocio.UseVisualStyleBackColor = true;
            // 
            // radNoSocio
            // 
            radNoSocio.AutoSize = true;
            radNoSocio.Location = new System.Drawing.Point(139, 58);
            radNoSocio.Name = "radNoSocio";
            radNoSocio.Size = new System.Drawing.Size(73, 19);
            radNoSocio.TabIndex = 21;
            radNoSocio.TabStop = true;
            radNoSocio.Text = "No Socio";
            radNoSocio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTipoCliente);
            panel1.Controls.Add(radSocio);
            panel1.Controls.Add(radNoSocio);
            panel1.Location = new System.Drawing.Point(519, 323);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 99);
            panel1.TabIndex = 22;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipoCliente.Location = new System.Drawing.Point(32, 18);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new System.Drawing.Size(161, 20);
            lblTipoCliente.TabIndex = 23;
            lblTipoCliente.Text = "Seleccione una opción:";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(773, 524);
            Controls.Add(panel1);
            Controls.Add(dtFechaNac);
            Controls.Add(txtTel);
            Controls.Add(label2);
            Controls.Add(lblFechaNac);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(txtDoc);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarCliente);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(cboTipoDoc);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblRegistroCliente);
            Name = "FrmRegistro";
            Text = "REGISTRO DE CLIENTES";
            Load += FrmRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRegistroCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.RadioButton radSocio;
        private System.Windows.Forms.RadioButton radNoSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoCliente;
    }
}