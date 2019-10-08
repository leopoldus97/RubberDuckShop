using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckCostumeRepository
    {
        DuckCostume AddDuckCostume(DuckCostume toAddDuckCostume);
        DuckCostume DeleteDuckCostume(int toDeleteId);
        DuckCostume UpdateDuckCostume(DuckCostume toUpdateDuckCostume);
        DuckCostume ReadDuckCostumeById(int id);
        IEnumerable<DuckCostume> ReadDuckCostume();
    }
}
