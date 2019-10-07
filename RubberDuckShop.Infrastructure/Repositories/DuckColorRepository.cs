using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Infrastructure.Repositories
{
    public class DuckColorRepository : IDuckColorRepository
    {
        private readonly RubberDuckShopContext _ctx;

        public DuckColorRepository(RubberDuckShopContext ctx)
        {
            _ctx = ctx;
        }
        public DuckColor addDuckColor(DuckColor toAddDuckColor)
        {
            throw new NotImplementedException();
        }

        public DuckColor deleteDuckColor(DuckColor toDeleteDuckColor)
        {
            throw new NotImplementedException();
        }

        public DuckColor updateDuckColor(DuckColor toUpdateDuckColor)
        {
            throw new NotImplementedException();
        }

        public List<DuckColor> readDuckColors()
        {
            throw new NotImplementedException();
        }
    }
}
