using Microsoft.EntityFrameworkCore;
using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public RubberDuck AddDuck(RubberDuck toAddRubberDuck)
        {
            _ctx.Attach(toAddRubberDuck.DuckColor).State = EntityState.Unchanged;
            _ctx.Attach(toAddRubberDuck.DuckCostume).State = EntityState.Unchanged;
            _ctx.Attach(toAddRubberDuck.DuckPattern).State = EntityState.Unchanged;
            _ctx.RubberDucks.Attach(toAddRubberDuck).State = EntityState.Added;
            _ctx.SaveChanges();
            return toAddRubberDuck;
        }

        public RubberDuck DeleteDuck(int toDeleteId)
        {
            var deleted = _ctx.RubberDucks.Remove(new RubberDuck() { ID = toDeleteId }).Entity;
            _ctx.SaveChanges();
            return deleted;
        }

        public IEnumerable<RubberDuck> ReadAllDucks()
        {
            return _ctx.RubberDucks.Include(duck => duck.DuckColor).Include(duck => duck.DuckCostume).Include(duck => duck.DuckPattern);
        }

        public RubberDuck ReadDuckById(int id)
        {
            return ReadAllDucks().FirstOrDefault(duck => duck.ID == id);
        }

        public IEnumerable<RubberDuck> ReadSearchedDucks(string search)
        {
            throw new NotImplementedException();
        }

        public RubberDuck UpdateDuck(RubberDuck toUpdateRubberDuck)
        {
            _ctx.RubberDucks.Attach(toUpdateRubberDuck).State = EntityState.Modified;
            _ctx.SaveChanges();
            return toUpdateRubberDuck;
        }

        private IEnumerable<RubberDuck> FilterBy(IEnumerable<RubberDuck> rubberDucks, Filter filter)
        {
            IEnumerable<RubberDuck> sortedList = rubberDucks;
            if (filter.DuckColor != null)
            {
                sortedList = sortedList.Where(duck => duck.DuckColor.Equals(filter.DuckColor));
            }
            if (filter.DuckCostume != null)
            {
                sortedList = sortedList.Where(duck => duck.DuckCostume.Equals(filter.DuckCostume));
            }
            if (filter.DuckPattern != null)
            {
                sortedList = sortedList.Where(duck => duck.DuckPattern.Equals(filter.DuckPattern));
            }
            if (filter.Size != DuckSize.DEFAULT)
            {
                sortedList = sortedList.Where(duck => duck.DuckSize.Equals(filter.Size));
            }
            if (filter.DuckGender != DuckGender.DEFAULT)
            {
                sortedList = sortedList.Where(duck => duck.DuckGender.Equals(filter.DuckGender));
            }
            return sortedList;
        }

        private IEnumerable<RubberDuck> OrderBy(IEnumerable<RubberDuck> rubberDuck, Filter filter)
        {
            IEnumerable<RubberDuck> orderedList;
            switch (filter.SortBy)
            {
                case SortByPrice.ASC:
                    orderedList = rubberDuck.OrderBy(duck => duck.Price);
                    break;
                case SortByPrice.DESC:
                    orderedList = rubberDuck.OrderByDescending(duck => duck.Price);
                    break;
                default:
                    return rubberDuck;
            }
            return orderedList;
        }

        public IEnumerable<RubberDuck> ReadSortedDucks(Filter filter)

        {
            List<RubberDuck> filteredList;

            if (filter != null && filter.CurrentPage > 0)
            {
                filteredList = FilterBy(ReadAllDucks(), filter)
                    .Skip((filter.CurrentPage - 1) * 10)
                    .Take(10).ToList();
            }
            else
            {
                filteredList = ReadAllDucks().ToList();
                return filteredList;
            }
                

            if (filter.SortBy > 0)
            {
                filteredList = OrderBy(filteredList, filter).ToList();
            }

            return filteredList;
        }
    }
}
