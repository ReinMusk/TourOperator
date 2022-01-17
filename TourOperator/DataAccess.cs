using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace Core
{
    public static class DataAccess
    {// хорошее использование регионов
        // Airplane
        #region
        public static ObservableCollection<Airplane> GetAirplanes()
        {
            ObservableCollection<Airplane> airplaness = new ObservableCollection<Airplane>(DBconnection.connection.Airplane);
            return airplaness;
        }

        public static bool AddNewAirplane(string newName)
        {
            try
            {
                Airplane airplane = new Airplane()
                {
                    Name = newName
                };

                DBconnection.connection.Airplane.Add(airplane);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewAirplane(Airplane airplane)
        {
            try
            {
                DBconnection.connection.Airplane.Add(airplane);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Airplane GetAirplane(int id)
        {
            ObservableCollection<Airplane> airolanes = GetAirplanes();
            return airolanes.FirstOrDefault(t => t.Id_Airplane == id);
        }

        public static Airplane GetAirplane(string name)
        {
            ObservableCollection<Airplane> airolanes = GetAirplanes();
            return airolanes.FirstOrDefault(t => t.Name == name);
        }
        #endregion // Airplane
 
        // City
        #region
        public static ObservableCollection<City> GetCities()
        {
            ObservableCollection<City> cities = new ObservableCollection<City>(DBconnection.connection.City);

            return cities;
        }

        public static bool AddNewCity(City city)
        {
            try
            {
                DBconnection.connection.City.Add(city);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewCity(string newName)
        {
            try
            {
                City city = new City()
                {
                    Name = newName
                };

                DBconnection.connection.City.Add(city);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static City GetCity(int id)
        {
            ObservableCollection<City> cities = GetCities();
            return cities.FirstOrDefault(t => t.Id_City == id);
        }

        public static City GetCity(string name)
        {
            ObservableCollection<City> cities = GetCities();
            return cities.FirstOrDefault(t => t.Name == name);
        }

        #endregion

        // Airlines
        #region
        public static ObservableCollection<Airline> GetAirlines()
        {
            ObservableCollection<Airline> airlines = new ObservableCollection<Airline>(DBconnection.connection.Airline);
            ObservableCollection<Airline> airlin = new ObservableCollection<Airline>();
            foreach (var item in airlines)
            {
                airlin.Add(
                    new Airline
                    {
                        Id_Airline = item.Id_Airline,
                        Name = item.Name
                    });
            }
            return airlin;
        }


        public static bool AddNewAirline(string newName)
        {
            try
            {
                Airline airline = new Airline()
                {
                    Name = newName
                };

                DBconnection.connection.Airline.Add(airline);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewAirline(Airline airline)
        {
            try
            {
                DBconnection.connection.Airline.Add(airline);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Airline GetAirline(int id)
        {
            ObservableCollection<Airline> airlines = GetAirlines();
            return airlines.FirstOrDefault(t => t.Id_Airline == id);
        }

        public static Airline GetAirline(string name)
        {
            ObservableCollection<Airline> airlines = GetAirlines();
            return airlines.FirstOrDefault(t => t.Name == name);
        }
        #endregion

        //Clients
        #region
        public static ObservableCollection<Clients> GetClients()
        {
            ObservableCollection<Clients> clients = new ObservableCollection<Clients>(DBconnection.connection.Clients);
            ObservableCollection<Clients> client = new ObservableCollection<Clients>();
            foreach (var item in clients)
            {
                client.Add(
                    new Clients
                    {
                        Id_Client = item.Id_Client,
                        Name = item.Name,
                        Surname = item.Surname
                    });
            }
            return client;
        }

        public static bool AddNewClient(string newName, string newSurname)
        {
            try
            {
                Clients client = new Clients()
                {
                    Name = newName,
                    Surname = newSurname,
                };

                DBconnection.connection.Clients.Add(client);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewClient(Clients clients)
        {
            try
            {
                DBconnection.connection.Clients.Add(clients);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Clients GetClient(int id)
        {
            ObservableCollection<Clients> clients = GetClients();
            return clients.FirstOrDefault(t => t.Id_Client == id);
        }

        public static Clients GetClient(string name)
        {
            ObservableCollection<Clients> clients = GetClients();
            return clients.FirstOrDefault(t => t.Name == name);
        }

        public static void UpdateClient(int id, Clients client)
        {
            var c = DBconnection.connection.Clients.SingleOrDefault(t => t.Id_Client == id);
            c.Name = client.Name;
            c.Surname = client.Surname;
            DBconnection.connection.SaveChanges();
        }
        #endregion

        // Tickets
        #region
        public static ObservableCollection<Ticket> GetTickets()
        {
            ObservableCollection<Ticket> tickets = new ObservableCollection<Ticket>(DBconnection.connection.Ticket);
            return tickets;
        }

        public static bool AddNewTicket(int newId_Client, int newId_Flight)
        {
            try
            {
                Ticket ticket = new Ticket()
                {
                    Id_Client = newId_Client,
                    Id_Flight = newId_Flight
                };

                DBconnection.connection.Ticket.Add(ticket);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewTicket(Ticket ticket)
        {
            try
            {
                DBconnection.connection.Ticket.Add(ticket);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Ticket GetTicket(int id)
        {
            ObservableCollection<Ticket> tickets = GetTickets();
            return tickets.FirstOrDefault(t => t.Id_Ticket == id);
        }

        public static void DeleteTicket(Ticket ticket)
        {
            DBconnection.connection.Ticket.Remove(ticket);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteTicket(int id)
        {
            var ticket = GetTicket(id);

            DBconnection.connection.Ticket.Remove(ticket);
            DBconnection.connection.SaveChanges();
        }
        #endregion

        //Flights
        #region
        public static ObservableCollection<Flight> GetFlights()
        {
            ObservableCollection<Flight> flights = new ObservableCollection<Flight>(DBconnection.connection.Flight);
            ObservableCollection<Flight> flight = new ObservableCollection<Flight>();
            foreach (var item in flights)
            {
                flight.Add(
                    new Flight
                    {
                        Id_Flight = item.Id_Flight,
                        Id_Tour = item.Id_Tour,
                        DateFlight = item.DateFlight,
                        DepartureTime = item.DepartureTime,
                        FlightTime = item.FlightTime,
                        Id_Airplane = item.Id_Airplane,
                        Price_ticket = item.Price_ticket
                    });
            }
            return flights;
        }

        public static bool AddNewFlight(int newId_Tour, 
            DateTime newDateFlight, TimeSpan newDepartureTime, 
            TimeSpan newFlightTime, int newId_Airplane, decimal newPrice_ticket)
        {
            try
            {
                Flight flight = new Flight()
                {
                    Id_Tour = newId_Tour,
                    DateFlight = newDateFlight,
                    DepartureTime = newDepartureTime,
                    FlightTime = newFlightTime,
                    Id_Airplane = newId_Airplane,
                    Price_ticket = newPrice_ticket
                };

                DBconnection.connection.Flight.Add(flight);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddNewFlight(Flight flight)
        {
            try
            {
                DBconnection.connection.Flight.Add(flight);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Flight GetFlight(int id)
        {
            ObservableCollection<Flight> clients = GetFlights();
            return clients.FirstOrDefault(t => t.Id_Flight == id);
        }

        public static void DeleteFlight(Flight flight)
        {
            DBconnection.connection.Flight.Remove(flight);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteFlight(int id)
        {
            var flight = GetFlight(id);

            DBconnection.connection.Flight.Remove(flight);
            DBconnection.connection.SaveChanges();
        }
        #endregion

        //Tours
        #region
        public static ObservableCollection<Tours> GetTours()
        {
            ObservableCollection<Tours> tours = new ObservableCollection<Tours>(DBconnection.connection.Tours);
            ObservableCollection<Tours> tour = new ObservableCollection<Tours>();
            foreach (var item in tours)
            {
                tour.Add(
                    new Tours
                    {
                        Id_Tour = item.Id_Tour,
                        Name = item.Name,
                        Id_DepartureCity = item.Id_DepartureCity,
                        Id_LandingCity = item.Id_LandingCity,
                        Id_Airline = item.Id_Airline,
                        CountDays = item.CountDays
                    });
            }
            return tour;
        }

        public static bool AddNewTour(string newName, 
            int newId_DepartureCity, int newId_LandingCity, 
            int newId_Airline, int newCountDays)
        {
            if (newId_DepartureCity == newId_LandingCity)
            {
                return false;
            }
            else
            {
                try
                {
                    Tours tour = new Tours()
                    {
                        Name = newName,
                        Id_DepartureCity = newId_DepartureCity,
                        Id_LandingCity = newId_LandingCity,
                        Id_Airline = newId_Airline,
                        CountDays = newCountDays,
                    };

                    DBconnection.connection.Tours.Add(tour);
                    DBconnection.connection.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool AddNewTour(Tours tours)
        {
            try
            {
                DBconnection.connection.Tours.Add(tours);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Tours GetTour(int id)
        {
            ObservableCollection<Tours> tours = GetTours();
            return tours.FirstOrDefault(t => t.Id_Tour == id);
        }

        public static Tours GetTour(string name)
        {
            ObservableCollection<Tours> tours = GetTours();
            return tours.FirstOrDefault(t => t.Name == name);
        }
        #endregion
    }
}