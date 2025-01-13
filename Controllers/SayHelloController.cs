using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;

        public SayHelloController(SayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }

        [HttpPost]
        [Route("AddName/{sayHelloTo}")]

        public string SayHello(string sayHelloTo)
        {
            return _sayHelloServices.SayHello(sayHelloTo);
        }

    }
}