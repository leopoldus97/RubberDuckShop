using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.DomainService
{
    public interface IDuckPatternRepository
    {
        DuckPattern addDuckPattern(DuckPattern toAddDuckPattern);
        DuckPattern deleteDuckPattern(int toDeleteId);
        DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern);
        List<DuckPattern> readDuckPatterns();
    }
}
