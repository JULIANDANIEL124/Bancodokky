using System;
using System.Linq;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class Iniciarsesion : Form
    {
        public Iniciarsesion()
        {
            InitializeComponent();
        }

        private void inisiarsecion_Click_1(object sender, EventArgs e)
        {
            string usuario = usuariotextBox.Text;
            string contraseña = ContraseñatextBox.Text;

            // Buscar al usuario en la lista de usuarios registrados
            var usuarioEncontrado = Registre.usuariosRegistrados
                .FirstOrDefault(u => u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase) && u.Contraseña == contraseña);

            if (usuarioEncontrado != null)
            {
                // Si se encuentra el usuario, abrir el formulario de cuenta y pasarle el nombre y saldo
                CuentaForm cuentaForm = new CuentaForm(usuarioEncontrado.Nombre, usuarioEncontrado.Saldo);
                cuentaForm.Show();
                //this.Hide(); // Ocultar el formulario de iniciar sesión
                this.Show(); // Muestra el formulario principal de nuevo después de cerrar el inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.");
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
