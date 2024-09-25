public class Usuario
{
    public string Nombre { get; set; }
    public string Contraseña { get; set; }
    public string Correo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Lugar { get; set; }
    public decimal Saldo { get; set; }  // Propiedad para el saldo

    public Usuario(string nombre, string contraseña, string correo, DateTime fechaNacimiento, string lugar)
    {
        Nombre = nombre;
        Contraseña = contraseña;
        Correo = correo;
        FechaNacimiento = fechaNacimiento;
        Lugar = lugar;
        Saldo = 10000;  // Establecer un saldo inicial (puedes modificar esto más adelante)
    }
}
