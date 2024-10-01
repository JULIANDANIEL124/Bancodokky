using System;
using System.Windows.Forms;

namespace dokky_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón "Registrarse"
        private void Registrarse_Click(object sender, EventArgs e)
        {
            // Ocultar Form1 antes de abrir el registro
            this.Hide();

            // Crear el formulario de registro
            Registre registroForm = new Registre();

            // Cuando se cierra el formulario de registro, vuelve a mostrar Form1
            registroForm.FormClosed += (s, args) => this.Show();

            // Mostrar el formulario de registro
            registroForm.Show();
        }

        // Evento del botón "Iniciar Sesión"
        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            Iniciarsesion iniciarSesionForm = new Iniciarsesion();
            this.Hide(); // Oculta el formulario principal
            iniciarSesionForm.ShowDialog(); // Muestra el formulario de inicio de sesión
            this.Show(); // Muestra el formulario principal de nuevo después de cerrar el inicio de sesión
        }

        // Cierra el programa
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el programa completamente
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

