using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckColorService
    {
        DuckColor addDuckColor(DuckColor toAddDuckColor);
        DuckColor deleteDuckColor(DuckColor toDeleteDuckColor);
        DuckColor updateDuckColor(DuckColor toUpdateDuckColor);
        List<DuckColor> getDuckColors();
    }
}
