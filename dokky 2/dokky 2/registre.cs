using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class Registre : Form
    {
        // Lista estática para almacenar usuarios registrados
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
            int edad;

            // Calcular la edad
            edad = CalcularEdad(fechaNacimiento);

            // Validar campos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(lugar) || edad <= 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos correctamente.");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar el TextBox de Edad cada vez que cambia la fecha
            int edad = CalcularEdad(dateTimePicker1.Value);
            EdadTextBox.Text = edad.ToString();
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            // Resta un año si el cumpleaños no ha ocurrido aún este año
            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;

            return edad;
        }

        private bool ValidarContraseña(string contraseña)
        {
            // Verificar que la contraseña tenga al menos 6 caracteres
            if (contraseña.Length < 6) return false;

            bool tieneLetra = false;
            bool tieneNumero = false;

            // Recorrer cada carácter en la contraseña para validar
            foreach (char c in contraseña)
            {
                if (char.IsLetter(c))
                {
                    tieneLetra = true;
                }
                else if (char.IsDigit(c))
                {
                    tieneNumero = true;
                }
            }

            // La contraseña es válida si contiene al menos una letra y un número
            return tieneLetra && tieneNumero;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual de la cuenta
            this.Close();

            // Abrir el formulario principal (Form1)
            Form1 menuPrincipal = new Form1();
            menuPrincipal.Show();
        }

        private void GmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
