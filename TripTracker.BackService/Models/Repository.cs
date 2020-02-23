using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip{Id = 1, Name = "MVP", StartDate = new DateTime(2020,2, 1), EndDate = new DateTime(2020, 03, 01)},
            new Trip{Id = 2, Name = "Dev Intersection", StartDate = new DateTime(2020,03, 3), EndDate = new DateTime(2020, 03, 04)},
            new Trip{Id = 3, Name = "Build 2020", StartDate = new DateTime(2020,04, 5), EndDate = new DateTime(2020, 04, 06)}
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.FirstOrDefault(t => t.Id == id);
        }
        
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            MyTrips.Add(tripToUpdate);
        }
        public void Delete(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
