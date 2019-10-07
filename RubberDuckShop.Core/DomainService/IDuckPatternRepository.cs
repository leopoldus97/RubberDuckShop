using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckPatternRepository
    {
        DuckPattern addDuckPattern(DuckPattern duckPattern);
        DuckPattern deleteDuckPattern(DuckPattern duckPattern);
        DuckPattern updateDuckPattern(DuckPattern duckPattern);
        List<DuckPattern> readDuckPatterns();
    }
}
