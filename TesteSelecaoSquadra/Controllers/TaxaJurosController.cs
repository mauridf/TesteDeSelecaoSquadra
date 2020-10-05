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
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaxaJuros> Get()
        {
            var juros = new Double();
            juros = 0.01;
            return Enumerable.Range(1, 1).Select(index => new TaxaJuros
            {
                Juros = juros
            })
            .ToArray();
        }
    }
}
