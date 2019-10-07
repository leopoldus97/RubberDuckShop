using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckCostumeRepository
    {
        DuckCostume addDuckCostume(DuckCostume toAddDuckCostume);
        DuckCostume deleteDuckCostume(int toDeleteId);
        DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume);
        DuckCostume readDuckCostumeById(int id);
        IEnumerable<DuckCostume> readDuckCostume();
    }
}
