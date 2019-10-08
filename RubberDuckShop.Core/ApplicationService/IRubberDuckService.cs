using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IRubberDuckService
    {
        RubberDuck AddDuck(RubberDuck toAddRubberDuck);
        RubberDuck DeleteDuck(int toDeleteId);
        RubberDuck UpdateDuck(RubberDuck toUpdateRubberDuck);
        RubberDuck GetDuckById(int id);
        List<RubberDuck> GetSortedDucks(Filter filter);
        List<RubberDuck> GetSearchedDucks(string search);
    }
}
