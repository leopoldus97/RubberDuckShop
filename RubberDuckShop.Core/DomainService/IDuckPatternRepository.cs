using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckPatternRepository
    {
        DuckPattern addDuckPattern(DuckPattern toAddDuckPattern);
        DuckPattern deleteDuckPattern(DuckPattern toDeleteDuckPattern);
        DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern);
        List<DuckPattern> readDuckPatterns();
    }
}
