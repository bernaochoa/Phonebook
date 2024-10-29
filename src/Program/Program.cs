using System;
using Library;
using WhatsAppApiUCU;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Contact dueño = new Contact("Juan", "12345678", "juan@ucu.edu.uy");
            Phonebook agenda = new Phonebook(dueño, new WhatsAppChannel());
            
            Contact contacto = new Contact("Berna", "+59891447188", "bernaochoa06@gmail.com");
            agenda.AgregarContacto(contacto);
            agenda.EnviarMensaje(contacto.Nombre,"Hola, ¿Todo bien?");
            
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59891447188", "Hey! I'm using WhatsApp");
        }
    }
}