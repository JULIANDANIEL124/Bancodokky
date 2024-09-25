using System;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class Registre : Form
    {

        public static List<Usuario> usuariosRegistrados = new List<Usuario>();
        public Registre()
        {
            InitializeComponent();
            // Establecer el evento para el DateTimePicker
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string nombre = nombreTextBox.Text;
            string contraseña = ContraseñaTextBox.Text;
            string correo = GmailTextBox.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string lugar = LugarTextBox.Text;

            // Validar campos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(lugar))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            // Validar formato del correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validar la contraseña
            if (!ValidarContraseña(contraseña))
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres, y contener tanto letras como números.");
                return;
            }

            // Agregar el nuevo usuario a la lista
            usuariosRegistrados.Add(new Usuario(nombre, contraseña, correo, fechaNacimiento, lugar));

            MessageBox.Show($"Registro exitoso, bienvenido {nombre}!");
            this.Close(); // Cierra el formulario después de un registro exitoso
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int edad = CalcularEdad(dateTimePicker1.Value);
            EdadTextBox.Text = edad.ToString();
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;

            return edad;
        }

        private bool ValidarContraseña(string contraseña)
        {
            if (contraseña.Length < 6) return false;

            bool tieneLetra = false;
            bool tieneNumero = false;

            foreach (char c in contraseña)
            {
                if (char.IsLetter(c)) tieneLetra = true;
                if (char.IsDigit(c)) tieneNumero = true;
            }

            return tieneLetra && tieneNumero;
        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
