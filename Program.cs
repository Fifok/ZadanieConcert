using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieConcrete.Models;

namespace ZadanieConcrete
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void zad1()
        {
            var band = new Band
            {
                Name = "Foals",
                Address = new Address
                {
                    City = new City
                    {
                        Name = "Oxford",
                        Voivodeship = "Oxfordshire"
                    },
                    Phone = "666431524",
                    Street = "Red Street 16"
                }
            };

            var newEvent = new Event
            {
                Band = band,
                City = new City
                {
                    Name = "Bielsko-Biala",
                    Voivodeship = "Silesia"
                },
                Date = DateTime.Now,
                Tickets = new[]
                {
                    new Ticket
                    {
                        Price = 30,
                         Type = TicketType.Standard
                    },
                    new Ticket
                    {
                        Price = 150,
                        Type = TicketType.Vip
                    }
                }
            };

            var dbContext = new MusicIndustryContext();

            dbContext.Events.Add(newEvent);
            dbContext.SaveChanges();
        }

        static void zad2()
        {
            var dbContext = new MusicIndustryContext();

            var eventsBB = dbContext.Events
                .Where(x => x.City.Name == "Bielsko-Biala")
                .Select(x => new { BandName = x.Band.Name, x.Date, CityName = x.City.Name, x.City.Voivodeship });

            foreach (var eventBB in eventsBB)
            {
                Console.WriteLine(eventBB);
            }

        }

        static void zad3()
        {
            var dbContext = new MusicIndustryContext();

            var eventFoals = dbContext.Events
                .FirstOrDefault(x => x.Band.Name == "Foals");

            if (eventFoals != null)
            {
                eventFoals.City.Name = "Cracow";
                eventFoals.City.Voivodeship = "Malopolskie";
            }

            dbContext.SaveChanges();
        }
    }
}
