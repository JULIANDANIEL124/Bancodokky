using System.Collections.Generic;

namespace dokky_2
{
    // Clase para gestionar los usuarios
    public static class UsuarioManager
    {
        // Lista de usuarios registrados
        public static List<Usuario> usuariosRegistrados = new List<Usuario>();

        // Método para agregar un nuevo usuario
        public static void AgregarUsuario(Usuario nuevoUsuario)
        {
            usuariosRegistrados.Add(nuevoUsuario);
        }

        // Método para verificar si el usuario existe
        public static bool VerificarUsuario(string nombre, string contraseña)
        {
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.Nombre == nombre && usuario.Contraseña == contraseña)
                {
                    return true; // Usuario encontrado
                }
            }
            return false; // Usuario no encontrado
        }
    }
}
