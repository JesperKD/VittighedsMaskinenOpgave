using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VittighedsMaskinenOpgave.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : Controller
    {
        private readonly ILogger<JokeController> _logger;
        private JokeProvider JokeProvider = new JokeProvider();

        public JokeController(ILogger<JokeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public void Get()
        {
            HttpContext.Session.SetObjectAsJson("Rjoke", JokeProvider.GetRandomJoke());
        }

        [HttpGet]
        [Route("[action]")]
        public void GetDadJoke()
        {
            HttpContext.Session.SetObjectAsJson("Djoke", JokeProvider.GetDadJokeDK());
        }

        [HttpGet]
        [Route("[action]")]
        public void GetYourMomJoke()
        {
            HttpContext.Session.SetObjectAsJson("Mjoke", JokeProvider.GetYourMomJokeDK());
        }

        [HttpGet]
        [Route("[action]")]
        public void GetBlondeJoke()
        {
            HttpContext.Session.SetObjectAsJson("Bjoke", JokeProvider.GetBlondeJokeDK());
        }

        [HttpGet]
        [Route("[action]")]
        public void GetKnockJoke()
        {
            HttpContext.Session.SetObjectAsJson("Kjoke", JokeProvider.GetKnockKnockJokeDK());
        }



    }
}
