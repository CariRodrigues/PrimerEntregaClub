namespace PrimerEntregaClub
{
    partial class frmPrincipal
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
            lblIngreso = new System.Windows.Forms.Label();
            btnPagar = new System.Windows.Forms.Button();
            btnListar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnActividad = new System.Windows.Forms.Button();
            btnDetallar = new System.Windows.Forms.Button();
            btnAsociar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegistrar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnRegistrar.Location = new System.Drawing.Point(104, 89);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(200, 76);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR CLIENTE";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIngreso.ForeColor = System.Drawing.Color.MidnightBlue;
            lblIngreso.Location = new System.Drawing.Point(104, 33);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new System.Drawing.Size(0, 21);
            lblIngreso.TabIndex = 6;
            // 
            // btnPagar
            // 
            btnPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPagar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnPagar.Location = new System.Drawing.Point(104, 218);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(200, 76);
            btnPagar.TabIndex = 7;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnListar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnListar.Location = new System.Drawing.Point(367, 89);
            btnListar.Name = "btnListar";
            btnListar.Size = new System.Drawing.Size(200, 76);
            btnListar.TabIndex = 8;
            btnListar.Text = "EMITIR LISTADO DEUDAS";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSalir.Location = new System.Drawing.Point(551, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(83, 36);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActividad
            // 
            btnActividad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnActividad.ForeColor = System.Drawing.Color.DodgerBlue;
            btnActividad.Location = new System.Drawing.Point(367, 334);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new System.Drawing.Size(200, 76);
            btnActividad.TabIndex = 10;
            btnActividad.Text = "INSCRIBIR EN ACTIVIDAD";
            btnActividad.UseVisualStyleBackColor = true;
            // 
            // btnDetallar
            // 
            btnDetallar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDetallar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnDetallar.Location = new System.Drawing.Point(367, 218);
            btnDetallar.Name = "btnDetallar";
            btnDetallar.Size = new System.Drawing.Size(200, 76);
            btnDetallar.TabIndex = 11;
            btnDetallar.Text = "EMITIR DATOS CLIENTE";
            btnDetallar.UseVisualStyleBackColor = true;
            // 
            // btnAsociar
            // 
            btnAsociar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAsociar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnAsociar.Location = new System.Drawing.Point(104, 334);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new System.Drawing.Size(200, 76);
            btnAsociar.TabIndex = 12;
            btnAsociar.Text = "ASOCIAR CLIENTE";
            btnAsociar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(671, 473);
            Controls.Add(btnAsociar);
            Controls.Add(btnDetallar);
            Controls.Add(btnActividad);
            Controls.Add(btnSalir);
            Controls.Add(btnListar);
            Controls.Add(btnPagar);
            Controls.Add(lblIngreso);
            Controls.Add(btnRegistrar);
            Name = "frmPrincipal";
            Text = "Ventana Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActividad;
        private System.Windows.Forms.Button btnDetallar;
        private System.Windows.Forms.Button btnAsociar;
    }
}