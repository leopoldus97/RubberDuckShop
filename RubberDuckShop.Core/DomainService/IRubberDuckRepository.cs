using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.DomainService
{
    public interface IRubberDuckRepository
    {
        IEnumerable<RubberDuck> readAllDucks();
        RubberDuck addDuck(RubberDuck toAddRubberDuck);
        RubberDuck deleteDuck(int toDeleteId);
        RubberDuck updateDuck(RubberDuck toUpdateRubberDuck);
        RubberDuck readDuckById(int id);
        IEnumerable<RubberDuck> readSortedDucks(Filter filter);
        IEnumerable<RubberDuck> readSearchedDucks(string search);
    }
}
