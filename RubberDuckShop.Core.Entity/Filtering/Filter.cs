using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.Entity.Filtering
{

    public enum SortByPrice { 
        DEFAULT = 0, ASC = 1, DESC = 2
    }

    public class Filter
    {
        public int CurrentPage { get; set; }
        public DuckColor DuckColor { get; set; }
        public DuckSize Size { get; set; }
        public DuckPattern DuckPattern { get; set; }
        public DuckCostume DuckCostume { get; set; }
        public DuckGender DuckGender { get; set; }
        public SortByPrice SortBy { get; set; }
    }
}
