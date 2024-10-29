namespace Library;

public class Message
{
    public string Texto { get; private set; }
    public string Remitente { get; private set; }
    public string Destinatario { get; private set; }

    public Message(string texto, string remitente, string destinatario)
    {
        Texto = texto;
        Remitente = remitente;
        Destinatario = destinatario;
    }
}
