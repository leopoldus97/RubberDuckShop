using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Infrastructure.Repositories
{
    public class DuckColorRepository : IDuckColorRepository
    {
        private readonly RubberDuckShopContext _ctx;

        public DuckColorRepository(RubberDuckShopContext ctx)
        {
            _ctx = ctx;
        }
        public DuckColor AddDuckColor(DuckColor toAddDuckColor)
        {
            _ctx.DuckColors.Attach(toAddDuckColor).State = EntityState.Added;
            _ctx.SaveChanges();
            return toAddDuckColor;
        }

        public DuckColor DeleteDuckColor(int toDeleteId)
        {
            var duckColor = _ctx.Remove(new DuckColor()
            {
                ID = toDeleteId
            }).Entity;
            _ctx.SaveChanges();
            return duckColor;
        }

        public DuckColor UpdateDuckColor(DuckColor toUpdateDuckColor)
        {
            _ctx.DuckColors.Attach(toUpdateDuckColor).State = EntityState.Modified;
            _ctx.SaveChanges();
            return toUpdateDuckColor;
        }

        public DuckColor ReadDuckColorById(int id)
        {
            return _ctx.DuckColors.FirstOrDefault(dC => dC.ID == id);
        }

        public IEnumerable<DuckColor> ReadDuckColors()
        {
            return _ctx.DuckColors;
        }
    }
}
