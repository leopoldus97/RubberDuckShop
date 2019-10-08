using System;
using System.Collections.Generic;
using System.Linq;
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
        public RubberDuck AddDuck(RubberDuck toAddRubberDuck)
        {
            return _rubberDuckRepository.AddDuck(toAddRubberDuck);
        }

        public RubberDuck DeleteDuck(int toDeleteId)
        {
            return _rubberDuckRepository.DeleteDuck(toDeleteId);
        }

        public RubberDuck GetDuckById(int id)
        {
            return _rubberDuckRepository.ReadDuckById(id);
        }

        public List<RubberDuck> GetSearchedDucks(string search)
        {
            return _rubberDuckRepository.ReadSearchedDucks(search).ToList();
        }

        public List<RubberDuck> GetSortedDucks(Filter filter)
        {
            return _rubberDuckRepository.ReadSortedDucks(filter).ToList();
        }

        public RubberDuck UpdateDuck(RubberDuck toUpdateRubberDuck)
        {
            return _rubberDuckRepository.UpdateDuck(toUpdateRubberDuck);
        }
    }
}
