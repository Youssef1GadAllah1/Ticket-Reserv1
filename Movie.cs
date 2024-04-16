using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ticket_Reservation
{
    internal class Movie : Events
    {
        public void Film()
        {
            Console.WriteLine($"Name:{Name} Expiry time {Time} Srart Film: {Startevent} End Film {Endevent}");

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

