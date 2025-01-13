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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;

        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("EightBall/{question}")]

        public string EightBallResponse(string question)
        {
            return _magic8BallServices.EightBallResponse(question);
        }
    }
}