using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationDeveloper.Domain.Models;

namespace ApplicationDeveloper
{
    public class TradesView
    {
        public int current { get; set; }
        public int rowCount { get; set; }
        public string sort { get; set; }
        public string searchPhrase { get; set; }
        public string id { get; set; }
        public int total { get; set; }
        public Trade[] rows { get; set; }
    }
}