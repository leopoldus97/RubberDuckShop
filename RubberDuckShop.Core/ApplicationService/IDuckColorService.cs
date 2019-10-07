using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckColorService
    {
        DuckColor addDuckColor(DuckColor toAddDuckColor);
        DuckColor deleteDuckColor(int toDeleteId);
        DuckColor updateDuckColor(DuckColor toUpdateDuckColor);
        DuckColor getDuckColorById(int id);
        List<DuckColor> getDuckColors();
    }
}
