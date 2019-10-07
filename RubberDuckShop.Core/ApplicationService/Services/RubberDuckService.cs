using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;

namespace RubberDuckShop.Core.ApplicationService.Services
{
    public class RubberDuckService : IRubberDuckService
    {
        private readonly IRubberDuckRepository _rubberDuckRepository;

        public RubberDuckService(IRubberDuckRepository rubberDuckRepository)
        {
            _rubberDuckRepository = rubberDuckRepository;
        }
        public RubberDuck addDuck(RubberDuck rubberDuck)
        {
            return _rubberDuckRepository.addDuck(rubberDuck);
        }

        public RubberDuck deleteDuck(RubberDuck rubberDuck)
        {
            return _rubberDuckRepository.deleteDuck(rubberDuck);
        }

        public RubberDuck getDuckById(int id)
        {
            return _rubberDuckRepository.readDuckById(id);
        }

        public List<RubberDuck> getSearchedDucks(string search)
        {
            return _rubberDuckRepository.readSearchedDucks(search);
        }

        public List<RubberDuck> getSortedDucks(Filter filter)
        {
            return _rubberDuckRepository.readSortedDucks(filter);
        }

        public RubberDuck updateDuck(RubberDuck rubberDuck)
        {
            return _rubberDuckRepository.updateDuck(rubberDuck);
        }
    }
}
