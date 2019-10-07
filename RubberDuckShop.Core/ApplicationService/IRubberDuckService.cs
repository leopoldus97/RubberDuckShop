using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Core.ApplicationService
{
    public interface IRubberDuckService
    {
        RubberDuck addDuck(RubberDuck toAddRubberDuck);
        RubberDuck deleteDuck(RubberDuck toDeleteRubberDuck);
        RubberDuck updateDuck(RubberDuck toUpdateRubberDuck);
        RubberDuck getDuckById(int id);
        List<RubberDuck> getSortedDucks(Filter filter);
        List<RubberDuck> getSearchedDucks(string search);
    }
}
