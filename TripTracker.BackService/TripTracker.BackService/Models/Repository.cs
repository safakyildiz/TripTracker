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
            new Trip
            {
                Id=1,
                Name="Mvp Summit",
                StartDate=new DateTime(2019,3,11),
                EndDate=new DateTime(2019,3,14)
            },

            new Trip
            {
                Id=2,
                Name="DevBesties of 2019",
                StartDate= new DateTime(2019,3,21),
                EndDate=new DateTime(2019,3,25)

            },

             new Trip
            {
                Id=3,
                Name="Build 2019",
                StartDate= new DateTime(2019,4,11),
                EndDate=new DateTime(2019,4,19)

            },


        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t=>t.Id==id);
        }
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t=>t.Id==id));

        }

    }
}
