using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TesteSelecaoSquadra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController:ControllerBase
    {
        private readonly ILogger<ShowMeTheCodeController> _logger;

        public ShowMeTheCodeController(ILogger<ShowMeTheCodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ShowMeTheCode> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new ShowMeTheCode
            {
               Url = "https://github.com/mauridf/TesteDeSelecaoSquadra/tree/main/TesteSelecaoSquadra"
            })
            .ToArray();
        }
    }
}
