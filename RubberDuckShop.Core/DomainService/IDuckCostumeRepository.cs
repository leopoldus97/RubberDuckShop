using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckCostumeRepository
    {
        DuckCostume addDuckCostume(DuckCostume duckCostume);
        DuckCostume deleteDuckCostume(DuckCostume duckCostume);
        DuckCostume updateDuckCostume(DuckCostume duckCostume);
        List<DuckCostume> readDuckCostume();
    }
}
