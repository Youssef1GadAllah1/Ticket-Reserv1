using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation
{
    internal class Admin
    {
        private string Name = "admin";
        private int ID = 102030;
        private string Password = "admin.10";


        public string GetNameADDMIN()
        {
            return Name;
        }
        public int GetID()
        {
            return ID;
        }
        public string GetPassword()
        {
            return Password;
        }

        public void AddTime_NameMovie(string time, string name)
        {
            Movie movie = new Movie();
            movie.SetTime(time);
            movie.SetName(name);
        }

        public void AddTime_NameConcert(string time, string name)
        {
            Concerts concert = new Concerts();
            concert.SetTime(time);
            concert.SetName(name);
        }


    }
}