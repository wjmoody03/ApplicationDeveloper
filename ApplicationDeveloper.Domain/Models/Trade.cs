using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeveloper.Domain.Models
{
    [DelimitedRecord(",")]
    public class Trade
    {
        public string TradeID;
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime TradeDate;
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime SettleDate;
        public string Symbol;
        public string Account;
        public int Quantity;
        public decimal Price;
        public decimal Principal;
        public string Currency;
    }
}
