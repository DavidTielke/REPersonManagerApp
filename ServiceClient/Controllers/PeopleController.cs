using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleClient;
using ConsoleClient.Logic;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonManager _manager;

        public PeopleController(IPersonManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("People/Adults")]
        public IEnumerable<Person> Get()
        {
            return _manager.GetAllChildren();
        }
    }
}
