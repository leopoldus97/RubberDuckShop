using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckCostumeService
    {
        DuckCostume addDuckCostume(DuckCostume toAddDuckCostume);
        DuckCostume deleteDuckCostume(int toDeleteId);
        DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume);
        DuckCostume getDuckCostumeById(int id);
        List<DuckCostume> getDuckCostume();
    }
}
