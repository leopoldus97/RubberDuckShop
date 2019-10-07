using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckColorRepository
    {
        DuckColor addDuckColor(DuckColor duckColor);
        DuckColor deleteDuckColor(DuckColor duckColor);
        DuckColor updateDuckColor(DuckColor duckColor);
        List<DuckColor> readDuckColors();
    }
}
