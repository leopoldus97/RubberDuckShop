using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IDuckPatternService
    {
        DuckPattern addDuckPattern(DuckPattern toAddDuckPattern);
        DuckPattern deleteDuckPattern(int toDeleteId);
        DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern);
        List<DuckPattern> getDuckPatterns();
    }
}
