using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckCostumeRepository
    {
        DuckCostume addDuckCostume(DuckCostume toAddDuckCostume);
        DuckCostume deleteDuckCostume(DuckCostume toDeleteDuckCostume);
        DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume);
        List<DuckCostume> readDuckCostume();
    }
}
