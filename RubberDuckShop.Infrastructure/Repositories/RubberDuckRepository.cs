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
        readonly IRubberDuckService _rubberDuckService;
        public RubberDuckRepository(IRubberDuckService rubberDuckService)
        {
            _rubberDuckService = rubberDuckService;
        }

        public RubberDuck addDuck(RubberDuck rubberDuck)
        {
            throw new NotImplementedException();
        }

        public RubberDuck deleteDuck(RubberDuck rubberDuck)
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

        public RubberDuck updateDuck(RubberDuck rubberDuck)
        {
            throw new NotImplementedException();
        }
    }
}
