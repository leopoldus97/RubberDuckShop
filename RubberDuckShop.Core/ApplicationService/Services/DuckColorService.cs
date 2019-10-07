using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService.Services
{
    public class DuckColorService : IDuckColorService
    {
        private readonly IDuckColorRepository _duckColorRepository;

        public DuckColorService(IDuckColorRepository duckColorRepository)
        {
            _duckColorRepository = duckColorRepository;
        }
        public DuckColor addDuckColor(DuckColor duckColor)
        {
            throw new NotImplementedException();
        }

        public DuckColor deleteDuckColor(DuckColor duckColor)
        {
            throw new NotImplementedException();
        }

        public DuckColor updateDuckColor(DuckColor duckColor)
        {
            throw new NotImplementedException();
        }

        public List<DuckColor> getDuckColors()
        {
            throw new NotImplementedException();
        }
    }
}
