using Factura.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class frmVisorFacturas : Form
    {
        public Cliente objClienteForm;
        public frmVisorFacturas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVisorFacturas_Load(object sender, EventArgs e)
        {
            lblCedula.Text = objClienteForm.Cedula;
        }
    }
}
