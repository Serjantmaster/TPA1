using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public delegate void EventNotification(string mesaj);

    public class EventManager
    {
        public List<EventNotification> ListaAbonati = new List<EventNotification>();

        public void Add(EventNotification abonat)
        {
            ListaAbonati.Add(abonat);
        }
        public void Eliminate(EventNotification abonat)
        {
            ListaAbonati.Remove(abonat);
        }
        public void NotificationGenerator()
        {
            foreach (var abonat in ListaAbonati) 
            {
               abonat("Notificare");
            }
        }
        public void CreateNewEvent()
        {
            NotificationGenerator();
        }
        public void EventActualization()
        {
            NotificationGenerator();
        }
    }



}
