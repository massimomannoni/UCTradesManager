
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeManager.Api.Application;
using TradeManager.Api.Models.Requests;
using TradeManager.Application.Trades.CreateTrade;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TradeManager.Api.Trades
{
    [Route(ApiBase.Trades)]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TradesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<TradesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TradesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Create a new trade
        /// </summary>
        /// <param name="request"></param>
        /// 
        // POST api/<TradesController>
        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(Guid), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> RegisterTrade([FromBody] Models.Requests.CreateTradeRequest request)
        {
            Guid tradeId = new Guid();

            try
            {
                // invoke service to store trades using mediator
                await _mediator.Send(new TradeManager.Application.Trades.CreateTrade.CreateTradeRequest(request.name, request.type, request.details, request.schemaId, request.portfolioId));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created(string.Empty, tradeId);
        }

        // PUT api/<TradesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TradesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
