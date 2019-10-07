using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.DomainService
{
    public interface IRubberDuckRepository
    {
        List<RubberDuck> readAllDucks();
        RubberDuck addDuck(RubberDuck toAddRubberDuck);
        RubberDuck deleteDuck(int toDeleteId);
        RubberDuck updateDuck(RubberDuck toUpdateRubberDuck);
        RubberDuck readDuckById(int id);
        List<RubberDuck> readSortedDucks(Filter filter);
        List<RubberDuck> readSearchedDucks(string search);
    }
}
