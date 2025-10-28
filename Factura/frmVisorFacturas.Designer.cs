namespace Factura
{
    partial class frmVisorFacturas
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
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            btnSalir = new Button();
            lblCedula = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 64);
            label1.TabIndex = 0;
            label1.Text = "Datos Cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(35, 197);
            label5.Name = "label5";
            label5.Size = new Size(85, 26);
            label5.TabIndex = 9;
            label5.Text = "Telefono:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(35, 230);
            label4.Name = "label4";
            label4.Size = new Size(85, 26);
            label4.TabIndex = 8;
            label4.Text = "Mail:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(35, 164);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 7;
            label3.Text = "Direccion:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 131);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 6;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 98);
            label6.Name = "label6";
            label6.Size = new Size(85, 26);
            label6.TabIndex = 5;
            label6.Text = "Cedula:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(137, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 27);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(126, 98);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(170, 25);
            lblCedula.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(141, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 25);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "label7";
            // 
            // frmVisorFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVisorFacturas";
            Text = "frmVisorFacturas";
            Load += frmVisorFacturas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnSalir;
        private Label lblCedula;
        private Label lblNombre;
    }
}