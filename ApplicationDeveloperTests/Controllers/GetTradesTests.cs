using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ApplicationDeveloper.Data.Repositories;
using ApplicationDeveloper.Domain.Models;
namespace TradeController.Tests
{
    [TestFixture()]
    public class GetTradesTests
    {
        [Test()]
        public void Test_GetTrades()
        {
            int expected = 500;
            var repo = new TradeRepository();
            var trades = repo.GetTrades();           
            int tradeCount = trades.Count<Trade>();         
            Assert.AreEqual(tradeCount, expected);
         
        }

    }
}
