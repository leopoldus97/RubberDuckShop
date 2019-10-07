using System;
using System.Collections.Generic;
using System.Linq;
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
            var duckPattern = _ctx.duckPatterns.Add(toAddDuckPattern).Entity;
            _ctx.SaveChanges();
            return duckPattern;
        }

        public DuckPattern deleteDuckPattern(int toDeleteId)
        {
            var duckPattern = _ctx.Remove(new DuckPattern()
            {
                ID = toDeleteId
            }).Entity;
            _ctx.SaveChanges();
            return duckPattern;
        }

        public DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern)
        {
            var duckPattern = _ctx.duckPatterns.Update(toUpdateDuckPattern).Entity;
            _ctx.SaveChanges();
            return duckPattern;
        }

        public DuckPattern readDuckPatternById(int id)
        {
            return _ctx.duckPatterns.FirstOrDefault(dP => dP.ID == id);
        }

        public IEnumerable<DuckPattern> readDuckPatterns()
        {
            return _ctx.duckPatterns;
        }
    }
}
