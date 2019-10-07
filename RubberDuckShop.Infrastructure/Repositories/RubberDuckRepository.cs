using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Infrastructure.Repositories
{
    public class RubberDuckRepository : IRubberDuckRepository
    {
        private readonly RubberDuckShopContext _ctx;

        public RubberDuckRepository(RubberDuckShopContext ctx)
        {
            _ctx = ctx;
        }
        public RubberDuck addDuck(RubberDuck toAddRubberDuck)
        {
            throw new NotImplementedException();
        }

        public RubberDuck deleteDuck(RubberDuck toDeleteRubberDuck)
        {
            throw new NotImplementedException();
        }

        public List<RubberDuck> readAllDucks()
        {
            throw new NotImplementedException();
        }

        public RubberDuck readDuckById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RubberDuck> readSearchedDucks(string search)
        {
            throw new NotImplementedException();
        }

        public List<RubberDuck> readSortedDucks(Filter filter)
        {
            throw new Exception();
        }

        public RubberDuck updateDuck(RubberDuck toUpdateRubberDuck)
        {
            throw new NotImplementedException();
        }
    }
}
