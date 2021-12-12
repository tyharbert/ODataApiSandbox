using System;
using System.Collections.Generic;
using ODataSandbox.Models;

namespace ODataSandbox.Repositories
{
    public class PersonRepository
    {
        private static readonly IEnumerable<Person> _people;

        static PersonRepository()
        {
            var people = new List<Person>();

            people.Add(new Person
            {
                Id = Guid.Parse("34c0ac10-1c0d-4a29-89ad-386a3fea893b"),
                Name = "Bob",
                Trips = new List<Trip>
                {
                    new Trip
                    {
                        Id = Guid.Parse("1b35a96d-ca98-438a-b63c-1478ae0661cb"),
                        Name = "Paris"
                    }
                }
            });

            people.Add(new Person
            {
                Id = Guid.Parse("d31713ca-236b-470f-bb9e-f5bd6fac3d8e"),
                Name = "Aaron",
                Trips = new List<Trip>
                {
                    new Trip
                    {
                        Id = Guid.Parse("741656bf-f5e6-4f18-855f-ca1b3c0eb478"),
                        Name = "Paris"
                    },
                    new Trip
                    {
                        Id = Guid.Parse("741656bf-f5e6-4f18-855f-ca1b3c0eb478"),
                        Name = "Paris"
                    }
                }
            });

            people.Add(new Person
            {
                Id = Guid.Parse("192dd197-6f25-4842-bb9f-207b5df221c2"),
                Name = "Jeff",
                Trips = new List<Trip>
                {
                    new Trip
                    {
                        Id = Guid.Parse("4537521c-27a6-4fa4-8bb5-fd94937abd56"),
                        Name = "Cleveland"
                    },
                    new Trip
                    {
                        Id = Guid.Parse("40431cba-0d8f-470a-9647-bdd99009737a"),
                        Name = "Cleveland"
                    },
                    new Trip
                    {
                        Id = Guid.Parse("1269c3e3-b5ff-4a73-8201-5388d00ea744"),
                        Name = "Cleveland"
                    }
                }
            });

            _people = people;
        }

        public IEnumerable<Person> Browse()
        {
            return _people;
        }
    }
}