using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApplicationDeveloper.Data.Repositories;
using ApplicationDeveloper.Domain.Models;
using Newtonsoft.Json;
namespace ApplicationDeveloper.Controllers.api
{
    public class TradeController : ApiController
    {

        //GET /api/gettrades
        //[HttpPost]
        //[Route("api/GetTrades/")]
        //public async Task<HttpResponseMessage> GetTrades([FromBody] TradesView tv)
        //{
            
        //    var repo = new TradeRepository();
        //    var trades = repo.GetTrades();
        //    tv.rows = trades.Select(t => new Trade { Account = t.Account, Currency = t.Currency, Price = t.Price, Principal = t.Principal, Quantity = t.Quantity, SettleDate = t.SettleDate, Symbol = t.Symbol, TradeDate = t.TradeDate, TradeID = t.TradeID }).ToArray();
        //    tv.total = trades.Count<Trade>();
        //    tv.rowCount = trades.Count<Trade>();
        //    return Request.CreateResponse(HttpStatusCode.OK, tv);

        //}
        [Route("api/GetTrades/")]
        public IEnumerable<Trade> GetTrades()
        {
            var repo = new TradeRepository();
            var trades = repo.GetTrades();          
            return trades;
        }
    }
}
