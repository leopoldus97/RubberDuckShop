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
           return _duckColorRepository.addDuckColor(duckColor);
        }

        public DuckColor deleteDuckColor(DuckColor duckColor)
        {
            return _duckColorRepository.deleteDuckColor(duckColor);
        }

        public DuckColor updateDuckColor(DuckColor duckColor)
        {
            return _duckColorRepository.updateDuckColor(duckColor);
        }

        public List<DuckColor> getDuckColors()
        {
            return _duckColorRepository.readDuckColors();
        }
    }
}
