namespace PrimerEntregaClub
{
    partial class Menu
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
            btnRegistrar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            lblNombre = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            txtNumDoc = new System.Windows.Forms.TextBox();
            lblNumDoc = new System.Windows.Forms.Label();
            lblTipoDoc = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            lblDatos = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegistrar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnRegistrar.Location = new System.Drawing.Point(644, 110);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(107, 41);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            btnVolver.Location = new System.Drawing.Point(644, 226);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(107, 38);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(31, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 14);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDni.Location = new System.Drawing.Point(31, 79);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(55, 14);
            lblDni.TabIndex = 3;
            lblDni.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(126, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(188, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(126, 33);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(188, 23);
            txtApellido.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(txtNumDoc);
            panel1.Controls.Add(lblNumDoc);
            panel1.Controls.Add(lblTipoDoc);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new System.Drawing.Point(32, 58);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(588, 272);
            panel1.TabIndex = 6;
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new System.Drawing.Point(126, 183);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new System.Drawing.Size(188, 23);
            txtNumDoc.TabIndex = 9;
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumDoc.Location = new System.Drawing.Point(31, 187);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new System.Drawing.Size(56, 14);
            lblNumDoc.TabIndex = 8;
            lblNumDoc.Text = "Número ";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipoDoc.Location = new System.Drawing.Point(31, 134);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new System.Drawing.Size(120, 14);
            lblTipoDoc.TabIndex = 7;
            lblTipoDoc.Text = "Tipo de Documento";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(166, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(128, 23);
            comboBox1.TabIndex = 6;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDatos.ForeColor = System.Drawing.Color.DodgerBlue;
            lblDatos.Location = new System.Drawing.Point(158, 28);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new System.Drawing.Size(149, 18);
            lblDatos.TabIndex = 6;
            lblDatos.Text = "Datos Personales";
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblDatos);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}