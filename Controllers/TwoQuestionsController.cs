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
    public class TwoQuestionsController : ControllerBase
    {
        private readonly TwoQuestionsServices _twoQuestionsServices;

        public TwoQuestionsController(TwoQuestionsServices twoQuestionsServices)
        {
            _twoQuestionsServices = twoQuestionsServices;
        }

        [HttpPost]
        [Route("WakeupTime/{name}/{wakingUpTime}")]

        public string MakeSentence(string name, string wakingUpTime)
        {
            return _twoQuestionsServices.MakeSentence(name, wakingUpTime);
        }
    }
}