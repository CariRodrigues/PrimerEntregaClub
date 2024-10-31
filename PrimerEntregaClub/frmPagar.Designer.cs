namespace PrimerEntregaClub
{
    partial class frmPagar
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btnPagar = new System.Windows.Forms.Button();
            btnVolver2 = new System.Windows.Forms.Button();
            ctnComprobante = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(65, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese n° de Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(257, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(138, 23);
            textBox1.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPagar.ForeColor = System.Drawing.Color.DodgerBlue;
            btnPagar.Location = new System.Drawing.Point(276, 142);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(99, 48);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnVolver2
            // 
            btnVolver2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnVolver2.Location = new System.Drawing.Point(276, 217);
            btnVolver2.Name = "btnVolver2";
            btnVolver2.Size = new System.Drawing.Size(93, 42);
            btnVolver2.TabIndex = 3;
            btnVolver2.Text = "VOLVER";
            btnVolver2.UseVisualStyleBackColor = true;
            btnVolver2.Click += btnVolver2_Click;
            // 
            // ctnComprobante
            // 
            ctnComprobante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ctnComprobante.Location = new System.Drawing.Point(65, 217);
            ctnComprobante.Name = "ctnComprobante";
            ctnComprobante.Size = new System.Drawing.Size(149, 42);
            ctnComprobante.TabIndex = 4;
            ctnComprobante.Text = "VER COMPROBANTE";
            ctnComprobante.UseVisualStyleBackColor = true;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(449, 329);
            Controls.Add(ctnComprobante);
            Controls.Add(btnVolver2);
            Controls.Add(btnPagar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmPagar";
            Text = "PAGAR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Button ctnComprobante;
    }
}