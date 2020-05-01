using System;

namespace ApiTwo
{
    public class Order
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public DateTime Date { get; set; }
        public int CostumerId { get; set; }
       
    }
}