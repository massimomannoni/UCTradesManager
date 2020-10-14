
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TradeManager.Api.Models.Requests
{
    public class CreateTradeRequest 
    {

        [Required]
        public string name { get; set; }

        [Required]
        public int type { get; set; }

        [Required]
        public string details { get; set; }

        [Required]
        public Guid schemaId { get; set; }

        [Required]
        public Guid portfolioId { get; set; }

    }
}
