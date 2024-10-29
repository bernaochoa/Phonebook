using System;
using WhatsAppApiUCU;

namespace Library;

public class WhatsAppChannel : IMessageChannel
{
    private WhatsAppApi api;

    public WhatsAppChannel()
    {
        api = new WhatsAppApi();
    }

    public void Send(Message message)
    {
        // Aquí se utiliza el método Send de WhatsAppApi para enviar el mensaje
        api.Send(message.Destinatario, message.Texto);
        Console.WriteLine($"Mensaje enviado a {message.Destinatario} por WhatsApp: {message.Texto}");
    }
}