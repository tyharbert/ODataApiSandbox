using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataSandbox.Models;
using ODataSandbox.Repositories;

namespace ODataSandbox.Controllers
{
    public class PeopleController : ODataController
    {
        private readonly PersonRepository _personRepository;

        public PeopleController()
        {
            _personRepository = new PersonRepository();
        }

        [HttpGet]
        [EnableQuery]
        public IEnumerable<Person> Get()
        {
            return _personRepository.Browse();
        }
    }
}
