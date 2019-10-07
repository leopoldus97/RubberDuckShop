using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Infrastructure.Repositories
{
    public class DuckCostumeRepository :IDuckCostumeRepository
    {
        private readonly RubberDuckShopContext _ctx;

        public DuckCostumeRepository(RubberDuckShopContext ctx)
        {
            _ctx = ctx;
        }
        public DuckCostume addDuckCostume(DuckCostume toAddDuckCostume)
        {
            var duckCostume = _ctx.duckCostumes.Add(toAddDuckCostume).Entity;
            _ctx.SaveChanges();
            return duckCostume;
        }

        public DuckCostume deleteDuckCostume(int toDeleteId)
        {
            var duckCostume = _ctx.Remove(new DuckCostume()
            {
                ID = toDeleteId
            }).Entity;
            _ctx.SaveChanges();
            return duckCostume;
        }

        public DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume)
        {
            var duckCostume = _ctx.duckCostumes.Update(toUpdateDuckCostume).Entity;
            _ctx.SaveChanges();
            return duckCostume;
        }

        public IEnumerable<DuckCostume> readDuckCostume()
        {
            return _ctx.duckCostumes;
        }
    }
}
