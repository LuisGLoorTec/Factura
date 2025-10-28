using Factura.Clases;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            bool esValido = true;
            if (string.IsNullOrWhiteSpace(txtCedula.Text) & (validarCedula()))
            {
                MessageBox.Show(txtCedula, "La cédula es obligatoria.");
                esValido = false;
                txtCedula.Focus();
            }
        }

        private bool validarCedula()
        {
            // 1. Verificar longitud
            if (txtCedula.Text.Length != 10)
            {
                MessageBox.Show("La cedula ingresada no tiene 10 digitos no es valida");
                txtCedula.Focus();
                return false;
            }

            // 2. Verificar que todos sean dígitos
            if (!txtCedula.Text.All(char.IsDigit))
            {
                MessageBox.Show("La cedula ingresada no contiene solo digitos no es valida");
                txtCedula.Focus();
                return false;
            }

            // 3. Verificar código de provincia
            int provincia = int.Parse(txtCedula.Text.Substring(0, 2));
            if (provincia < 1 || provincia > 24)
            {
                // Nota: Se puede permitir 30 para extranjeros, pero 1-24 es la regla general.
                MessageBox.Show("La cedula ingresada no contiene contiene el codigo provincial no es valida");
                txtCedula.Focus();

                return false;
            }

            // 4. Verificar tercer dígito
            int tercerDigito = int.Parse(txtCedula.Text[2].ToString());
            if (tercerDigito < 0 || tercerDigito > 5)
            {
                // Para RUC (sociedad pública o privada) sería 6 o 9, pero para cédula es < 6
                MessageBox.Show("La cedula ingresadano cumple el tercer digito no es valida");
                txtCedula.Focus();
                return false;
            }

            // 5. Aplicar Algoritmo Módulo 10
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int valor = int.Parse(txtCedula.Text[i].ToString()) * coeficientes[i];

                if (valor > 9)
                {
                    valor = valor - 9;
                }
                suma += valor;
            }

            // Cálculo del dígito verificador
            int digitoVerificadorCalculado = (suma % 10 == 0) ? 0 : 10 - (suma % 10);
            int digitoVerificadorReal = int.Parse(txtCedula.Text[9].ToString());

            // 6. Comparar

            bool esValido = (digitoVerificadorCalculado == digitoVerificadorReal);

            if (esValido)
            {
                return true; // La cédula es válida, no mostramos mensaje
            }
            else
            {
                // Aquí pones el mensaje de error para ESTE CASO
                MessageBox.Show("El dígito verificador no es correcto. La cédula no es válida.");
                txtCedula.Focus();
                return false; // La cédula es inválida
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            bool esValido2 = true;
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show(txtNombres, "El nombre es obligatorio.");
                esValido2 = false;
                txtNombres.Focus();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            bool esValido3 = true;
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show(txtDireccion, "La dirección es obligatoria.");
                esValido3 = false;
                txtDireccion.Focus();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            bool esValido4 = true;
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show(txtTelefono, "El teléfono es obligatorio.");
                esValido4 = false;
                txtTelefono.Focus();
            }

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            bool esValido5 = true;
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show(txtMail, "El correo es obligatorio.");
                esValido5 = false;
                txtMail.Focus();
            }
        }

        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            if (GetValidaDatosCliente())
            {
                Cliente objCliente =new Cliente(
                    txtCedula.Text,
                    txtNombres.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtMail.Text
                    );
                frmVisorFacturas objVisor = new frmVisorFacturas();
                objVisor.objClienteForm = objCliente;
                objVisor.ShowDialog();
                //MessageBox.Show($"Cliente {objCliente.Nombre} Grabado exitosamente");
            }
        }
        private bool GetValidaDatosCliente()
        {
            if (txtCedula.Text.Length != 10)
            {
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
