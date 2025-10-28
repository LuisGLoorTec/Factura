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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 191);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 0;
            label1.Text = "Cedula:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 224);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(23, 257);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(23, 323);
            label4.Name = "label4";
            label4.Size = new Size(85, 26);
            label4.TabIndex = 3;
            label4.Text = "Mail:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(23, 290);
            label5.Name = "label5";
            label5.Size = new Size(85, 26);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.Window;
            txtCedula.Location = new Point(114, 191);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 0;
            txtCedula.Leave += txtCedula_Leave;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(114, 224);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(309, 27);
            txtNombres.TabIndex = 1;
            txtNombres.Leave += txtNombres_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(114, 257);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(309, 27);
            txtDireccion.TabIndex = 2;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(114, 290);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(114, 323);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(309, 27);
            txtMail.TabIndex = 4;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // btnGrabarCliente
            // 
            btnGrabarCliente.BackColor = Color.Indigo;
            btnGrabarCliente.ForeColor = SystemColors.ButtonFace;
            btnGrabarCliente.Location = new Point(141, 374);
            btnGrabarCliente.Name = "btnGrabarCliente";
            btnGrabarCliente.Size = new Size(157, 29);
            btnGrabarCliente.TabIndex = 5;
            btnGrabarCliente.Text = "Grabar Cliente";
            btnGrabarCliente.UseVisualStyleBackColor = false;
            btnGrabarCliente.Click += btnGrabarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, -76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 258);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(23, 78);
            label6.Name = "label6";
            label6.Size = new Size(297, 36);
            label6.TabIndex = 7;
            label6.Text = "Facturador Gengar";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(365, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(514, 503);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturador PKM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
    }
}
