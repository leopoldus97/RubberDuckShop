using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.DomainService
{
    public interface IRubberDuckRepository
    {
        IEnumerable<RubberDuck> ReadAllDucks();
        RubberDuck AddDuck(RubberDuck toAddRubberDuck);
        RubberDuck DeleteDuck(int toDeleteId);
        RubberDuck UpdateDuck(RubberDuck toUpdateRubberDuck);
        RubberDuck ReadDuckById(int id);
        IEnumerable<RubberDuck> ReadSortedDucks(Filter filter);
        IEnumerable<RubberDuck> ReadSearchedDucks(string search);
    }
}
