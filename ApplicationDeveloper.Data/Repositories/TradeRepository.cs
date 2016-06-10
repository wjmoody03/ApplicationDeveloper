using ApplicationDeveloper.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeveloper.Data.Repositories
{
    public class TradeRepository
    {
        public IEnumerable<Trade> GetTrades()
        {
            var fhde = new FileHelpers.DelimitedFileEngine<Trade>();
            var tradeStream = new StreamReader(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("ApplicationDeveloper.Data.Repositories.Trades.csv"));
            var trades = fhde.ReadStream(tradeStream);
            return trades;
        }
    }
}
