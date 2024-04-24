using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation
{
    internal class Program
    {
        static public LinkedList<Movie> movies = new LinkedList<Movie>();

        static public LinkedList<Concerts> concerts = new LinkedList<Concerts>();

        static public LinkedList<Ticket> ticketsMovie = new LinkedList<Ticket>();

        static public LinkedList<Ticket> ticketsConcert = new LinkedList<Ticket>();

        static int ReservationTicket = 0;

        static int ReservationTicket1 = 0;

        static void Client()
        {
            Console.WriteLine("1:For Ticket Reservation Event ");
            Console.WriteLine("2:For Cancel Ticket Reservation Event ");

            Console.WriteLine("Enter 1 or 2 ");
            int Choose = int.Parse(Console.ReadLine());
            switch (Choose)
            {
                case 1:
                    Console.WriteLine("1:For Reservation Ticket Film");
                    Console.WriteLine("2:For Reservation Ticket Concert");

                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            foreach (Movie movie in movies)
                            {
                                Console.WriteLine($"Name Film:{movie.GetName()},Time:{movie.GetTime()},Start Film:{movie.GetStartEvent()},End Film:{movie.GetEndEvent()}");

                            }
                            Console.WriteLine("Enter Name Client");
                            string NameClient = Console.ReadLine();
                            Console.WriteLine("Enter Name Film");
                            string Name = Console.ReadLine();

                            Ticket ticket = new Ticket();
                            ticket.SetName(NameClient);
                            foreach (Movie movie1 in movies)
                            {
                                if (Name == movie1.GetName())
                                {
                                    ticketsMovie.AddFirst(ticket);
                                    int b = 0;
                                    bool IsFull = false;
                                    if (IsFull == false)
                                    {
                                        b++;
                                    }
                                    ReservationTicket = b;
                                    ticket.AddReservationTicket();
                                    Console.WriteLine($"The Max in the Hall :(100) The Number of Hall :{ReservationTicket}");


                                    if (ReservationTicket == 100)
                                    {
                                        IsFull = true;
                                    }
                                    if (IsFull == true)
                                    {
                                        Console.WriteLine("The Room is Full");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Failed Reservation Ticket");
                                }
                            }
                            break;
                        case 2:



                            foreach (Concerts concert in concerts)
                            {
                                Console.WriteLine($"Name Concert:{concert.GetName()},Time:{concert.GetTime()},Start Film:{concert.GetStartEvent()},End Film:{concert.GetEndEvent()}");

                            }
                            Console.WriteLine("Enter Name Client");
                            string NameClient1 = Console.ReadLine();
                            Console.WriteLine("Enter Name Concert");
                            string Name1 = Console.ReadLine();

                            Ticket ticket1 = new Ticket();
                            ticket1.SetName(NameClient1);
                            foreach (Concerts concert1 in concerts)
                            {
                                if (Name1 == concert1.GetName())
                                {
                                    
                                    ticketsConcert.AddFirst(ticket1);

                                    int c = 0;
                                    bool IsFull = false;
                                    if (IsFull == false)
                                    {
                                        c++;
                                    }
                                    ReservationTicket1 = c;
                                    ticket1.AddReservationTicket();
                                    Console.WriteLine($"The Max in the Hall :(100) The Number of Hall :{ReservationTicket1}");


                                    if (ReservationTicket1 == 100)
                                    {
                                        IsFull = true;
                                    }
                                    if (IsFull == true)
                                    {
                                        Console.WriteLine("The Room is Full");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Failed Reservation Ticket");
                                }
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1:For Delete Reservation Ticket  Film");
                    Console.WriteLine("2:For Delete Reservation Ticket Concert");
                    int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            foreach (Movie movie in movies)
                            {
                                Console.WriteLine($"Name Film:{movie.GetName()},Time:{movie.GetTime()},Start Film:{movie.GetStartEvent()},End Film:{movie.GetEndEvent()}");
                                
                            }
                            ReservationTicket--;
                            bool ist = false;
                            Ticket ticket = new Ticket();
                            Console.WriteLine("Enter Name");
                            string NameCl = Console.ReadLine();
                            Console.WriteLine("Enter Name Film");
                            string Name = Console.ReadLine();
                            foreach (Movie movie1 in movies)
                            {
                                foreach (Ticket tickets in ticketsMovie)
                                {
                                    if (NameCl == tickets.GetName() && Name == movie1.GetName())
                                    {

                                        ticket = tickets;
                                        ist = true;
                                    }
                                }
                            }

                            if (ist == true)
                            {
                                ticket.CancelReservationTicket();
                                ticketsMovie.Remove(ticket);
                            }
                            else
                            {
                                Console.WriteLine("Failed Reservation Ticket");
                            }
                            
                            break;
                        case 2:
                            foreach (Concerts concert in concerts)
                            {
                                Console.WriteLine($"Name Concert:{concert.GetName()},Time Concert:{concert.GetTime()},Start Concert:{concert.GetStartEvent()},End Concert:{concert.GetEndEvent()}");

                            }
                            ReservationTicket1--;
                            bool isF = false;
                            Console.WriteLine("Enter Name ");
                            string NameC = Console.ReadLine();
                            Console.WriteLine("Enter Name Concert");
                            string Name1 = Console.ReadLine();
                            Ticket ticket1 = new Ticket();
                            foreach (Concerts concert1 in concerts)
                            {
                                foreach (Ticket tickets in ticketsConcert) {
                                    if (NameC == tickets.GetName() && Name1 == concert1.GetName())
                                    {
                                        isF = true;
                                        ticket1 = tickets;
                                        
                                        
                                    }
                                }
                            }
                            if(isF == true )
                            {
                                ticket1.AddReservationTicket();
                                ticketsConcert.Remove(ticket1);
                            }
                                else
                                {
                                    Console.WriteLine("Failed Reservation Ticket");
                                }
                            
                            
                            break;

                    }


                    break;
            }
        }

        static void Admin()
        {

            Admin admin = new Admin();
            Console.WriteLine("welcome admin,..... LogIn");
            Console.WriteLine("Enter Your Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your ID ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter You Password");
            string password = Console.ReadLine();
            bool IsFound = false;

            if (admin.GetNameADDMIN() == name && admin.GetPassword() == password && admin.GetID() == id)
            {

                Console.WriteLine("Login successfully");

                IsFound = true;

            }

            else
            {
                Console.WriteLine("Failed");
            }
            if (IsFound == true)
            {
                Console.WriteLine("1:For Add Event ");
                Console.WriteLine("2:For Delete Event ");

                Console.WriteLine("Enter 1 or 2 ");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        Console.WriteLine("1:For Add Film");
                        Console.WriteLine("2:For Add Concent");
                        int i = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                Console.WriteLine("Enter Name Film");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Enter Time of Film");
                                string time = Console.ReadLine();
                                Console.WriteLine("Enter Start Time Film");
                                string Start = Console.ReadLine();
                                Console.WriteLine("Enter End Time Film");
                                string end = Console.ReadLine();
                                Movie movie = new Movie();
                                movie.SetName(Name);
                                movie.SetTime(time);
                                movie.SetStartEvent(Start);
                                movie.SetEndEvent(end);
                                movies.AddLast(movie);
                                break;
                            case 2:
                                Console.WriteLine("Enter Name Concert");
                                string Name1 = Console.ReadLine();
                                Console.WriteLine("Enter Time of Concert");
                                string time1 = Console.ReadLine();
                                Console.WriteLine("Enter Start Time Concert");
                                string Start1 = Console.ReadLine();
                                Console.WriteLine("Enter End Time Concert");
                                string end1 = Console.ReadLine();
                                Concerts concert = new Concerts();
                                concert.SetName(Name1);
                                concert.SetTime(time1);
                                concert.SetStartEvent(Start1);
                                concert.SetEndEvent(end1);
                                concerts.AddLast(concert);
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("1:For Delete Film");
                        Console.WriteLine("2:For Delete Concert");
                        int x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                foreach (Movie movie1 in movies)
                                {
                                    Console.WriteLine($"Name Film:{movie1.GetName()},Time:{movie1.GetTime()},Start Film:{movie1.GetStartEvent()},End Film:{movie1.GetEndEvent()}");

                                }
                                Console.WriteLine("Enter Name Film");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Enter Time of Film");
                                string time = Console.ReadLine();
                                Console.WriteLine("Enter Start Time Film");
                                string Start = Console.ReadLine();
                                Console.WriteLine("Enter End Time Film");
                                string end = Console.ReadLine();
                                bool IsF = false;
                                Movie movie = new Movie();

                                foreach (Movie movie2 in movies)
                                {

                                    if (Name == movie2.GetName() && time == movie2.GetTime() && Start == movie2.GetStartEvent() && end == movie2.GetEndEvent())
                                    {
                                        IsF = true;
                                        movie = movie2;
                                    }
                                }
                                if (IsF == true)
                                {
                                    movie.SetName(Name);
                                    movie.SetTime(time);
                                    movie.SetStartEvent(Start);
                                    movie.EndEvent(end);
                                    movies.Remove(movie);
                                    Console.WriteLine("Successfully Remove");
                                }
                                else
                                {
                                    Console.WriteLine("Failed Film");
                                }
                                break;
                            case 2:
                                foreach (Concerts concert1 in concerts)
                                {
                                    Console.WriteLine($"Name Concert:{concert1.GetName()},Time Concert:{concert1.GetTime()},Start Concert:{concert1.GetStartEvent()},End Concert:{concert1.GetEndEvent()}");

                                }
                                Console.WriteLine("Enter Name Concert");
                                string Name1 = Console.ReadLine();
                                Console.WriteLine("Enter Time of Concert");
                                string time1 = Console.ReadLine();
                                Console.WriteLine("Enter Start Time Concert");
                                string Start1 = Console.ReadLine();
                                Console.WriteLine("Enter End Time Concert");
                                string end1 = Console.ReadLine();
                                bool IsC = false;
                                Concerts concert = new Concerts();

                                foreach (Concerts concert2 in concerts)
                                {
                                    if (Name1 == concert2.GetName() && time1 == concert2.GetTime() && Start1 == concert2.GetStartEvent() && end1 == concert2.GetEndEvent())
                                    {
                                        IsC = true;
                                        concert = concert2;
                                    }
                                }
                                if (IsC == true)
                                {
                                    concert.SetName(Name1);
                                    concert.SetTime(time1);
                                    concert.SetStartEvent(Start1);
                                    concert.SetEndEvent(end1);
                                    concerts.Remove(concert);
                                    Console.WriteLine("Successfully Remove");
                                }
                                else
                                {
                                    Console.WriteLine("Failed Concert");
                                }
                                break;
                        }
                        break;



                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1:For Admin");
                Console.WriteLine("2:For Client");
                Console.WriteLine("3:For Exit");
                Console.WriteLine("Enter Number 1,2 or 3");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        Admin();
                        break;
                    case 2:
                        Client();
                        foreach (Ticket t in ticketsMovie)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }

        } 
    }
}
