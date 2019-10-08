using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckCostumeService
    {
        DuckCostume AddDuckCostume(DuckCostume toAddDuckCostume);
        DuckCostume DeleteDuckCostume(int toDeleteId);
        DuckCostume UpdateDuckCostume(DuckCostume toUpdateDuckCostume);
        DuckCostume GetDuckCostumeById(int id);
        List<DuckCostume> GetDuckCostume();
    }
}
