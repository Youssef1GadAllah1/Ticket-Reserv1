using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation
{
    internal class Concerts : Events
    {
        
        public override void SetTime(string time)
        {
            Time = time;
        }



        public override string GetTime()
        {
            return Time;
        }

        public override void SetName(string name)
        {
            Name = name;
        }


        public override string GetName()
        {
            return Name;
        }

        public override string GetStartEvent()
        {
            return Startevent;
        }
        public override void SetStartEvent(string strartEvent)
        {
            Startevent = strartEvent;
        }
        public override void SetEndEvent(string endEvent)
        {
            Endevent = endEvent;
        }
        public override string GetEndEvent()
        {
            return Endevent;
        }

        
    }
}

