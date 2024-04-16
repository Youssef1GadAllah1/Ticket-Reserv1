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
        public int Time;
        protected int Startevent;
        protected int Endevent;
        // methods
        public abstract void SetTime(int time);



        public abstract int GetTime();

        public abstract void SetName(string name);


        public abstract string GetName();

        public virtual int GetStartEvent()
        {
            return Startevent;
        }
        public virtual int GetEndEvent()
        {
            return Endevent;
        }
        public abstract int StartEvent(int startevent);

        public abstract int EndEvent(int endevent);

    }
}
