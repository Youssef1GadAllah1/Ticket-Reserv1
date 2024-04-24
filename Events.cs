using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation
{
    abstract internal class Events
    {
        public string Name;
        public string Time;
        protected string Startevent;
        protected string Endevent;
        // methods
        public abstract void SetTime(string time);



        public abstract string GetTime();

        public abstract void SetName(string name);


        public abstract string GetName();

        public virtual string GetStartEvent()
        {
            return Startevent;
        }
        public virtual void SetStartEvent(string strartEvent)
        {
            Startevent = strartEvent;
        }
        public virtual void SetEndEvent(string endEvent)
        {
            Endevent = endEvent;
        }
        public virtual string GetEndEvent()
        {
            return Endevent;
        }
        

    }
}
