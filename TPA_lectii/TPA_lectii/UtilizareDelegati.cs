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
        public List<EventNotification> Abonati = new List<EventNotification>();

        public void Add(EventNotification abonat)
        {
            Abonati.Add(abonat);
        }
        public void Eliminate(EventNotification abonat)
        {
            Abonati.Remove(abonat);
        }
        public void NotificationGenerator()
        {
            foreach (var abonat in Abonati) 
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
