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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaServices;

        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaServices)
        {
            _reverseItAlphaServices = reverseItAlphaServices;
        }

        [HttpGet]
        [Route("ReverseItAlpha/{input}")]

        public string ReverseIt(string input)
        {
            return _reverseItAlphaServices.ReverseIt(input);
        }
    }
}