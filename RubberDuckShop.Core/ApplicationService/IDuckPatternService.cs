using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckPatternService
    {
        DuckPattern AddDuckPattern(DuckPattern toAddDuckPattern);
        DuckPattern DeleteDuckPattern(int toDeleteId);
        DuckPattern UpdateDuckPattern(DuckPattern toUpdateDuckPattern);
        DuckPattern GetDuckPatternById(int id);
        List<DuckPattern> GetDuckPatterns();
    }
}
