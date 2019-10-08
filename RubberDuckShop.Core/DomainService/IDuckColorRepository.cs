using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckColorRepository
    {
        DuckColor AddDuckColor(DuckColor toAddDuckColor);
        DuckColor DeleteDuckColor(int toDeleteId);
        DuckColor UpdateDuckColor(DuckColor toUpdateDuckColor);
        DuckColor ReadDuckColorById(int id);
        IEnumerable<DuckColor> ReadDuckColors();
    }
}
