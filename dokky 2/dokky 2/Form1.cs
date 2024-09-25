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
            Registre registroForm = new Registre();
            registroForm.Show();
          
        }

        // Evento del botón "Iniciar Sesión"
        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            // Aquí se crea una instancia del formulario de inicio de sesión
            Iniciarsesion iniciarSesionForm = new Iniciarsesion();
            iniciarSesionForm.Show();
        }
         //Cierra el programa
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario de registro
        }
    }
}
