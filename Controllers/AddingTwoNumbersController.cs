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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;


        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices)
        {
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }

        [HttpPost]
        [Route("Add2Numbers/{num1}/{num2}")]

        public string AddNumbers(string num1, string num2)
        {
            return _addingTwoNumbersServices.AddNumbers(num1, num2);
        }
    }
}