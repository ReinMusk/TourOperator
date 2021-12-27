﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.ObjectModel;

namespace Core
{
    public static class DataAccess
    {
        public static List<Airplane> GetAirplanes()
        {
            List<Airplane> airplaness = new List<Airplane>(DBconnection.connection.Airplane);
            List<Airplane> airplns = new List<Airplane>();
            foreach (var item in airplaness)
            {
                airplns.Add(
                    new Airplane
                    {
                        Id_Airplane = item.Id_Airplane,
                        Name = item.Name
                    });
            }
            return airplns;
        }

        public static bool AddNewAirplane(int newId_Airplane, string newName)
        {
            try
            {
                Airplane airplane = new Airplane()
                {
                    Id_Airplane = newId_Airplane,
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

        public static Airplane GetAirplane(int id)
        {
            List<Airplane> tattoos = GetAirplanes();
            return tattoos.FirstOrDefault(t => t.Id_Airplane == id);
        }

        public static Airplane GetAirplane(string name)
        {
            List<Airplane> tattoos = GetAirplanes();
            return tattoos.FirstOrDefault(t => t.Name == name);
        }

        public static void DeleteAirplane(Airplane airplane)
        {
            DBconnection.connection.Airplane.Remove(airplane);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteTattoo(int id)
        {
            List<Airplane> tattoos = GetAirplanes();
            var tattoo = tattoos.FirstOrDefault(t => t.Id_Airplane == id);

            DBconnection.connection.Airplane.Remove(tattoo);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateAirplane(int id, Airplane airplane)
        {
            DBconnection.connection.Airplane.SingleOrDefault(t => t.Id_Airplane == id);
            DBconnection.connection.SaveChanges();
        }


        //////////////////////////////////////////////////////////
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>(DBconnection.connection.City);
            List<City> city = new List<City>();
            foreach (var item in cities)
            {
                city.Add(
                    new City
                    {
                        Id_City = item.Id_City,
                        Name = item.Name
                    });
            }
            return city;
        }

        public static bool AddNewCity(int newId_City, string newName)
        {
            try
            {
                City city = new City()
                {
                    Id_City = newId_City,
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
            List<City> cities = GetCities();
            return cities.FirstOrDefault(t => t.Id_City == id);
        }

        public static City GetCity(string name)
        {
            List<City> cities = GetCities();
            return cities.FirstOrDefault(t => t.Name == name);
        }

        public static void DeleteCity(City city)
        {
            DBconnection.connection.City.Remove(city);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteCity(int id)
        {
            List<City> cities = GetCities();
            var city = cities.FirstOrDefault(t => t.Id_City == id);

            DBconnection.connection.City.Remove(city);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateCity(int id, City city)
        {
            DBconnection.connection.City.SingleOrDefault(t => t.Id_City == id);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////////////////
        public static List<Airline> GetAirlines()
        {
            List<Airline> airlines = new List<Airline>(DBconnection.connection.Airline);
            List<Airline> airlin = new List<Airline>();
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

        public static bool AddNewAirline(int newId_Airline, string newName)
        {
            try
            {
                Airline airline = new Airline()
                {
                    Id_Airline = newId_Airline,
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

        public static Airline GetAirline(int id)
        {
            List<Airline> airlines = GetAirlines();
            return airlines.FirstOrDefault(t => t.Id_Airline == id);
        }

        public static Airline GetAirline(string name)
        {
            List<Airline> airlines = GetAirlines();
            return airlines.FirstOrDefault(t => t.Name == name);
        }

        public static void UpdateAirline(int id, Airline airline)
        {
            DBconnection.connection.Airline.SingleOrDefault(t => t.Id_Airline == id);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteAirline(Airline airline)
        {
            DBconnection.connection.Airline.Remove(airline);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteAirline(int id)
        {
            List<Airline> airlines = GetAirlines();
            var airline = airlines.FirstOrDefault(t => t.Id_Airline == id);

            DBconnection.connection.Airline.Remove(airline);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////////////////
        public static List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>(DBconnection.connection.Ticket);
            List<Ticket> ticket = new List<Ticket>();
            foreach (var item in tickets)
            {
                ticket.Add(
                    new Ticket
                    {
                        Id_Ticket = item.Id_Ticket,
                        Id_Client = item.Id_Client,
                        Id_Flight = item.Id_Flight
                    });
            }
            return ticket;
        }

        public static bool AddNewTicket(int newId_Ticket, int newId_Client, int newId_Flight)
        {
            try
            {
                Ticket ticket = new Ticket()
                {
                    Id_Ticket = newId_Ticket,
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

        public static Ticket GetTicket(int id)
        {
            List<Ticket> tickets = GetTickets();
            return tickets.FirstOrDefault(t => t.Id_Ticket == id);
        }

        public static void UpdateAirline(int id, Ticket ticket)
        {
            DBconnection.connection.Ticket.SingleOrDefault(t => t.Id_Ticket == id);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteAirline(Ticket ticket)
        {
            DBconnection.connection.Ticket.Remove(ticket);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteTicket(int id)
        {
            List<Ticket> tickets = GetTickets();
            var ticket = tickets.FirstOrDefault(t => t.Id_Ticket == id);

            DBconnection.connection.Ticket.Remove(ticket);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////////////////
        public static List<Clients> GetClients()
        {
            List<Clients> clients = new List<Clients>(DBconnection.connection.Clients);
            List<Clients> client = new List<Clients>();
            foreach (var item in clients)
            {
                client.Add(
                    new Clients
                    {
                        Id_Client = item.Id_Client,
                        Name = item.Name,
                        Surname = item.Surname,
                        Date_Birth = item.Date_Birth
                    });
            }
            return client;
        }

        public static bool AddNewClient(int newId_Client, string newName,
            string newSurname, DateTime newDate_Birth)
        {
            try
            {
                Clients client = new Clients()
                {
                    Id_Client = newId_Client,
                    Name = newName,
                    Surname = newSurname,
                    Date_Birth = newDate_Birth
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

        public static Clients GetClient(int id)
        {
            List<Clients> clients = GetClients();
            return clients.FirstOrDefault(t => t.Id_Client == id);
        }

        public static Clients GetClient(string name)
        {
            List<Clients> clients = GetClients();
            return clients.FirstOrDefault(t => t.Name == name);
        }

        public static void UpdateClient(int id, Airline client)
        {
            DBconnection.connection.Clients.SingleOrDefault(t => t.Id_Client == id);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteClient(Clients client)
        {
            DBconnection.connection.Clients.Remove(client);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteClient(int id)
        {
            List<Clients> clients = GetClients();
            var client = clients.FirstOrDefault(t => t.Id_Client == id);

            DBconnection.connection.Clients.Remove(client);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////////////////
        public static List<Flight> GetFlights()
        {
            List<Flight> flights = new List<Flight>(DBconnection.connection.Flight);
            List<Flight> flight = new List<Flight>();
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
            return flight;
        }

        public static bool AddNewFlight(int newId_Flight, int newId_Tour, 
            DateTime newDateFlight, TimeSpan newDepartureTime, 
            TimeSpan newFlightTime, int newId_Airplane, decimal newPrice_ticket)
        {
            try
            {
                Flight flight = new Flight()
                {
                    Id_Flight = newId_Flight,
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

        public static Flight GetFlight(int id)
        {
            List<Flight> clients = GetFlights();
            return clients.FirstOrDefault(t => t.Id_Flight == id);
        }

        public static void UpdateFlight(int id, Flight flight)
        {
            DBconnection.connection.Flight.SingleOrDefault(t => t.Id_Flight == id);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteFlight(Flight flight)
        {
            DBconnection.connection.Flight.Remove(flight);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteFlight(int id)
        {
            List<Flight> flights = GetFlights();
            var flight = flights.FirstOrDefault(t => t.Id_Flight == id);

            DBconnection.connection.Flight.Remove(flight);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////////////////
        public static List<Tours> GetTours()
        {
            List<Tours> tours = new List<Tours>(DBconnection.connection.Tours);
            List<Tours> tour = new List<Tours>();
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

        public static bool AddNewTour(int newId_Tour, string newName, 
            int newId_DepartureCity, int newId_LandingCity, 
            int newId_Airline, int newCountDays)
        {
            try
            {
                Tours tour = new Tours()
                {
                    Id_Tour = newId_Tour,
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

        public static Tours GetTour(int id)
        {
            List<Tours> tours = GetTours();
            return tours.FirstOrDefault(t => t.Id_Tour == id);
        }

        public static Tours GetTour(string name)
        {
            List<Tours> tours = GetTours();
            return tours.FirstOrDefault(t => t.Name == name);
        }

        public static void UpdateTour(int id, Tours tour)
        {
            DBconnection.connection.Tours.SingleOrDefault(t => t.Id_Tour == id);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteTour(Tours tour)
        {
            DBconnection.connection.Tours.Remove(tour);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteTour(int id)
        {
            List<Tours> tours = GetTours();
            var tour = tours.FirstOrDefault(t => t.Id_Tour == id);

            DBconnection.connection.Tours.Remove(tour);
            DBconnection.connection.SaveChanges();
        }
    }
}