using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckColorService
    {
        DuckColor AddDuckColor(DuckColor toAddDuckColor);
        DuckColor DeleteDuckColor(int toDeleteId);
        DuckColor UpdateDuckColor(DuckColor toUpdateDuckColor);
        DuckColor GetDuckColorById(int id);
        List<DuckColor> GetDuckColors();
    }
}
