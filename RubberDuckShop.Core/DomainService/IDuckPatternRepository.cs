using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckPatternRepository
    {
        DuckPattern AddDuckPattern(DuckPattern toAddDuckPattern);
        DuckPattern DeleteDuckPattern(int toDeleteId);
        DuckPattern UpdateDuckPattern(DuckPattern toUpdateDuckPattern);
        DuckPattern ReadDuckPatternById(int id);
        IEnumerable<DuckPattern> ReadDuckPatterns();
    }
}
