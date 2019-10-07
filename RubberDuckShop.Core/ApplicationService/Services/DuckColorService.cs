using System;
using System.Collections.Generic;
using System.Linq;
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
        public DuckColor addDuckColor(DuckColor toAddDuckColor)
        {
           return _duckColorRepository.addDuckColor(toAddDuckColor);
        }

        public DuckColor deleteDuckColor(int toDeleteId)
        {
            return _duckColorRepository.deleteDuckColor(toDeleteId);
        }

        public DuckColor updateDuckColor(DuckColor toUpdateDuckColor)
        {
            return _duckColorRepository.updateDuckColor(toUpdateDuckColor);
        }

        public List<DuckColor> getDuckColors()
        {
            return _duckColorRepository.readDuckColors().ToList();
        }
    }
}
