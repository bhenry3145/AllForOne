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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("GuessItEasy/{easyGuess}")]

        public string EasyMode(string easyGuess)
        {
            return _guessItServices.EasyMode(easyGuess);
        }

        [HttpGet]
        [Route("GuessItMedium/{mediumGuess}")]

        public string MediumMode(string mediumGuess)
        {
            return _guessItServices.MediumMode(mediumGuess);
        }

        [HttpGet]
        [Route("GuessItHard/{hardGuess}")]

        public string HardMode(string hardGuess)
        {
            return _guessItServices.HardMode(hardGuess);
        }
    }
}