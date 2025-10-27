namespace Factura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            btnGrabarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 0;
            label1.Text = "Cedula:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(23, 55);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            label3.TextAlign = ContentAlignment.TopCenter;

            // 
            // label4
            // 
            label4.Location = new Point(23, 186);
            label4.Name = "label4";
            label4.Size = new Size(85, 26);
            label4.TabIndex = 3;
            label4.Text = "Mail:";
            label4.TextAlign = ContentAlignment.TopCenter;

            // 
            // label5
            // 
            label5.Location = new Point(23, 140);
            label5.Name = "label5";
            label5.Size = new Size(85, 26);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            label5.TextAlign = ContentAlignment.TopCenter;

            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(114, 19);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 0;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(114, 55);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(309, 27);
            txtNombres.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(114, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(309, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(114, 140);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(114, 186);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(309, 27);
            txtMail.TabIndex = 4;
            // 
            // btnGrabarCliente
            // 
            btnGrabarCliente.Location = new Point(137, 253);
            btnGrabarCliente.Name = "btnGrabarCliente";
            btnGrabarCliente.Size = new Size(157, 29);
            btnGrabarCliente.TabIndex = 5;
            btnGrabarCliente.Text = "Grabar Cliente";
            btnGrabarCliente.UseVisualStyleBackColor = true;
            btnGrabarCliente.Click += btnGrabarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 614);
            Controls.Add(btnGrabarCliente);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombres);
            Controls.Add(txtCedula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturador ISTLC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCedula;
        private TextBox txtNombres;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private Button btnGrabarCliente;
    }
}
