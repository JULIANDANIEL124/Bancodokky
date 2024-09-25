using System;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class Iniciarsesion : Form
    {
        // Lista estática de usuarios registrados
        public static List<Usuario> usuariosRegistrados = Registre.usuariosRegistrados; // Obtener la lista de usuarios desde el formulario de registro

        public Iniciarsesion()
        {
            InitializeComponent();
        }

        private void inisiarsecion_Click_1(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            string nombreIngresado = usuariotextBox.Text;
            string contraseñaIngresada = ContraseñatextBox.Text;

            // Buscar al usuario en la lista de registrados
            Usuario usuarioEncontrado = usuariosRegistrados
                .FirstOrDefault(u => u.Nombre == nombreIngresado && u.Contraseña == contraseñaIngresada);

            if (usuarioEncontrado != null)
            {
                // Si el usuario es encontrado, mostrar el formulario con su información
                decimal saldoInicial = 1000; // Ejemplo: establecer saldo inicial (puedes modificarlo según tu lógica)
                CuentaForm cuentaForm = new CuentaForm(usuarioEncontrado.Nombre, saldoInicial);
                cuentaForm.Show();

                this.Close(); // Cerrar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
