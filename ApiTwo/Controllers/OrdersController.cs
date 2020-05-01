using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            
            return Enumerable.Range(1, 5).Select(index => new Order
                {
                    Date = DateTime.Now.AddDays(-index),
                    Produto =$"Tenis tamanho : {index}", 
                    CostumerId = index,
                    Id = index
                    
                })
                .ToArray();
        }
        
        
        [HttpGet("{id}")]
        
        public IEnumerable<Order> Get(string id)
        {
            
            return   Enumerable.Range(1, 5).Select(index => new Order
                {
                    Date = DateTime.Now.AddDays(-index),
                    Produto =$"Tenis tamanho : {index}", 
                    CostumerId = index,
                    Id = index
                    
                })
                .ToArray().Where(x => x.CostumerId == Convert.ToInt32(id));;

            

        }
    }
}