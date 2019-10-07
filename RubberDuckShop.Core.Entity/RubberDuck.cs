using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.Entity
{

    public enum DuckSize { 
        SMALL, MEDIUM, LARGE, XXL
    }

    public enum DuckGender { 
        MALE, FEMALE
    }

    public class RubberDuck
    {
        public int ID { get; set; }
        public DuckColor DuckColor { get; set; }
        public DuckPattern DuckPattern { get; set; }
        public DuckSize DuckSize { get; set; }
        public int Price { get; set; }
        public DuckGender DuckGender { get; set; }
        public DuckCostume DuckCostume { get; set; }
    }
}
