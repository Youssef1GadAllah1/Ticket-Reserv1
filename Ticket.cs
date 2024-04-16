using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation
{
    internal class Ticket
    {
        public string Name;
        // methods 
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void AddReservationTicket()
        {
            Console.WriteLine("Successfully Ticket Reservation");
        }
        public void CancelReservationTicket()
        {
            Console.WriteLine("Successfully Cancel Ticket Reservation");
        }

    }
}