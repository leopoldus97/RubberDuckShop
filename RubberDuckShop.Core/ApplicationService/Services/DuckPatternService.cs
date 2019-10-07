using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService.Services
{
    public class DuckPatternService: IDuckPatternService
    {
        private readonly IDuckPatternRepository _duckPatternRepository;

        public DuckPatternService(IDuckPatternRepository duckPatternRepository)
        {
            _duckPatternRepository = duckPatternRepository;
        }
        public DuckPattern addDuckPattern(DuckPattern duckPattern)
        {
            throw new NotImplementedException();
        }

        public DuckPattern deleteDuckPattern(DuckPattern duckPattern)
        {
            throw new NotImplementedException();
        }

        public DuckPattern updateDuckPattern(DuckPattern duckPattern)
        {
            throw new NotImplementedException();
        }

        public List<DuckPattern> getDuckPatterns()
        {
            throw new NotImplementedException();
        }
    }
}
