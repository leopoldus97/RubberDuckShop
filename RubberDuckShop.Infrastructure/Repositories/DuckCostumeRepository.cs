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
            throw new NotImplementedException();
        }

        public DuckCostume deleteDuckCostume(int toDeleteId)
        {
            throw new NotImplementedException();
        }

        public DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DuckCostume> readDuckCostume()
        {
            throw new NotImplementedException();
        }
    }
}
