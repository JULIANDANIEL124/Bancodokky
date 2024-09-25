using System;
using System.Globalization;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class CuentaForm : Form
    {
        private string nombreUsuario;
        private decimal saldoUsuario;

        public CuentaForm(string nombre, decimal saldo)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            saldoUsuario = saldo;

            // Mostrar el nombre y saldo en los controles del formulario
            nombreLabel.Text = $"Bienvenido, {nombreUsuario}";
            saldoLabel.Text = $"Tu saldo es: {saldo.ToString("C", new CultureInfo("es-ARG"))}"; // Para pesos Argentino
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // Al hacer clic en "Salir", cerramos este formulario y mostramos el formulario de inicio de sesión
            this.Close();
        }
    }
}
