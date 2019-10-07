using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckColorRepository
    {
        DuckColor addDuckColor(DuckColor toAddDuckColor);
        DuckColor deleteDuckColor(int toDeleteId);
        DuckColor updateDuckColor(DuckColor toUpdateDuckColor);
        List<DuckColor> readDuckColors();
    }
}
