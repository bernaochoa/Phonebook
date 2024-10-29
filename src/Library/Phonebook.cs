using System.Collections.Generic;
using System;
using System.Linq;

namespace Library;

public class Phonebook
{
    public Contact Dueño { get; private set; }
    private List<Contact> _contactos;
    private IMessageChannel _messageChannel;

    public Phonebook(Contact dueño, IMessageChannel messageChannel)
    {
        Dueño = dueño;
        this._messageChannel = messageChannel;
        _contactos = new List<Contact>();
    }

    public void AgregarContacto(Contact contacto)
    {
        _contactos.Add(contacto);
    }

    public void QuitarContacto(Contact contacto)
    {
        _contactos.Remove(contacto);
    }

    public Contact Search(string nombre)
    {
        return _contactos.FirstOrDefault(contacto => contacto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public void EnviarMensaje(string nombreDestinatario, string texto)
    {
        Contact destinatario = Search(nombreDestinatario);
        if (destinatario != null)
        {
            Message mensaje = new Message(texto, Dueño.Telefono, destinatario.Telefono);
            _messageChannel.Send(mensaje);
        }
    }
}
