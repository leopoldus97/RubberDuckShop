using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.Entity.Filtering
{

    public enum SortByPrice { 
        DEFAULT, ASC, DESC
    }

    public class Filter
    {
        public int CurrentPage { get; set; }
        public DuckColor DuckColor { get; set; }
        public DuckSize Size { get; set; }
        public DuckPattern DuckPattern { get; set; }
        public DuckCostume DuckCostume { get; set; }
        public DuckGender DuckGender { get; set; }
        public SortByPrice SortByPrice { get; set; }
    }
}
