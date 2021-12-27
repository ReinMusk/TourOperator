using System;
using static Core.DataAccess;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {

            DeleteFlight(1);
            //while (true)
            //{
            //    var command = Console.ReadLine();
            //    Execute(command);
            //}
        }

        private static void Execute(string command)
        {
            switch (command)
            {
                case "put":
                    Add(command);
                    break;
                case "get":
                    Get(command);
                    break;
                case "update":
                    Update(command);
                    break;
                case "delete":
                    Remove(command);
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }

        private static void Add(string com)
        {
            string[] temp = Console.ReadLine().Trim().Split(' ');
            bool t = false;
            switch (com)
            {
                case "Airlines":
                    t = AddNewAirline(temp[0]);
                    break;
                case "Airplane":
                    t = AddNewAirplane(temp[0]);
                    break;
                case "City":
                    t = AddNewCity(temp[0]);
                    break;
                case "Clients":
                    t = AddNewClient(temp[0], temp[1]);
                    break;
                case "Ticket":
                    t = AddNewTicket(int.Parse(temp[0]), int.Parse(temp[1]));
                    break;
                case "Tours":
                    t = AddNewTour(temp[0], int.Parse(temp[1]), int.Parse(temp[2]),
                        int.Parse(temp[3]), int.Parse(temp[4]));
                    break;
                case "Flight":

                    t = AddNewFlight(int.Parse(temp[0]), DateTime.Parse(temp[1]), TimeSpan.Parse(temp[2]),
                        TimeSpan.Parse(temp[3]), int.Parse(temp[4]), decimal.Parse(temp[5]));
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }

            Output(t);
        }
        private static void Get(string com)
        {
            switch (com)
            {
                case "Airlines":
                    foreach (var a in GetAirlines())
                        Console.WriteLine($"{a.Name}");
                    break;
                case "Airplane":
                    foreach (var a in GetAirlines())
                        Console.WriteLine($"{a.Name}");
                    break;
                case "City":
                    foreach (var a in GetCities())
                        Console.WriteLine($"{a.Name}");
                    break;
                case "Client":
                    foreach (var a in GetClients())
                        Console.WriteLine($"{a.Name} {a.Surname}");
                    break;
                case "Ticket":
                    foreach (var a in GetTickets())
                        Console.WriteLine($"{a.Id_Flight} {a.Id_Client}");
                    break;
                case "Tours":
                    foreach (var a in GetTours())
                        Console.WriteLine($"{a.Name} {a.Id_DepartureCity}" +
                            $" {a.Id_LandingCity} {a.CountDays}");
                    break;
                case "Flight":
                    foreach (var a in GetFlights())
                        Console.WriteLine($"{a.Id_Tour} {a.DateFlight}" +
                            $" {a.DepartureTime} {a.FlightTime} {a.Id_Airplane} {a.Price_ticket}");
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }
        private static void Remove(string com)
        {
            int n = int.Parse(Console.ReadLine());
            switch (com)
            {
                case "Ticket":
                    DeleteTicket(n);
                    break;
                case "Flight":
                    DeleteFlight(n);
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }

        private static void Update(string com)
        {
            string[] temp = Console.ReadLine().Split(' ');
            switch (com)
            {
                case "Client":
                    UpdateClient(int.Parse(temp[0]), GetClient(temp[0]));
                    break;
            }
        }

        public static void Output(bool t)
        {
            Console.WriteLine(t ? "OK" : "NOT OK");
        }
    }
}
