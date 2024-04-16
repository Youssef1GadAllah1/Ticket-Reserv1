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
        public void Concert()
        {
            Console.WriteLine($"Name:{Name} Expiry time {Time} Srat Film: {Startevent} End Film {Endevent}");

        }
        public override void SetTime(int time)
        {
            Time = time;
        }



        public override int GetTime()
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

        public override int GetStartEvent()
        {
            return Startevent;
        }
        public override int GetEndEvent()
        {
            return Endevent;
        }
        public override int StartEvent(int startevent)
        {
            Startevent = startevent;
            return Startevent;
        }

        public override int EndEvent(int endevent)
        {
            Endevent = endevent;
            return Endevent;
        }
    }
}

