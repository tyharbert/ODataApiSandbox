using System;
using System.Collections.Generic;

namespace ODataSandbox.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public IEnumerable<Trip> Trips { get; set; }
    }
}