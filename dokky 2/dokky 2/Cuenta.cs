using System;
using System.Globalization;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class CuentaForm : Form
    {
        // Constructor que recibe el nombre del usuario y el saldo
        public CuentaForm(string nombreUsuario, decimal saldo)
        {
            InitializeComponent();

            // Mostrar el nombre y el saldo en las etiquetas
            nombreLabel.Text = $"Bienvenido, {nombreUsuario}";
            // Formato de pesos mexicanos
            saldoLabel.Text = $"Tu saldo es: {saldo.ToString("C", new CultureInfo("es-ARG"))}"; // Para pesos Argentino
        }

        private void CuentaForm_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario cuando el formulario se carga
        }

        private void saldoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de la cuenta
            this.Close();

            // Abrir el formulario de inicio de sesión
            Iniciarsesion loginForm = new Iniciarsesion();
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
