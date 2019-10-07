using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Infrastructure.Repositories
{
    public class DuckPatternRepository : IDuckPatternRepository
    {
        private readonly RubberDuckShopContext _ctx;

        public DuckPatternRepository(RubberDuckShopContext ctx)
        {
            _ctx = ctx;
        }
        public DuckPattern addDuckPattern(DuckPattern toAddDuckPattern)
        {
            throw new NotImplementedException();
        }

        public DuckPattern deleteDuckPattern(int toDeleteId)
        {
            throw new NotImplementedException();
        }

        public DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern)
        {
            throw new NotImplementedException();
        }

        public List<DuckPattern> readDuckPatterns()
        {
            throw new NotImplementedException();
        }
    }
}
