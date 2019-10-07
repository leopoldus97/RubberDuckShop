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
            return _duckPatternRepository.addDuckPattern(duckPattern);
        }

        public DuckPattern deleteDuckPattern(DuckPattern duckPattern)
        {
            return _duckPatternRepository.deleteDuckPattern(duckPattern);
        }

        public DuckPattern updateDuckPattern(DuckPattern duckPattern)
        {
            return _duckPatternRepository.updateDuckPattern(duckPattern);
        }

        public List<DuckPattern> getDuckPatterns()
        {
            return _duckPatternRepository.readDuckPatterns();
        }
    }
}
