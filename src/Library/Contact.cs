namespace Library;

public class Contact
{
    public string Nombre { get; private set; }
    public string Telefono { get; private set; }
    public string Correo { get; private set; }

    public Contact(string nombre, string telefono, string correo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
    }
}