using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CostumerController : ControllerBase
    {
        private readonly ILogger<CostumerController> _logger;
        public CostumerController(ILogger<CostumerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Costumer> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Costumer()
                {
                    Id =  index,
                    Nome = $"Cliente - {index}"
                }).ToArray();
        }
    }
}