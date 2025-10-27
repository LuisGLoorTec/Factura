namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            if (GetValidaDatosCliente()){
                MessageBox.Show($"Cliente {txtNombres.Text} Grabado exitosamente");
            }
        }

        private bool GetValidaDatosCliente()
        {
            if (txtCedula.Text.Length != 10){
                MessageBox.Show("La cedula ingresada no es valida");
                txtCedula.Focus();
                return false;
            }
            if (txtNombres.Text.Length == 0)
            {
                MessageBox.Show("El nombre ingresado no es valido");
                txtNombres.Focus();
                return false;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("La direccion ingresada no es valida");
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El telefono ingresado no es valido");
                txtTelefono.Focus();
                return false;
            }
            if (txtMail.Text.Length == 0)
            {
                MessageBox.Show("El mail ingresado no es valido");
                txtMail.Focus();
                return false;
            }
            return true;
        }
    }
}
