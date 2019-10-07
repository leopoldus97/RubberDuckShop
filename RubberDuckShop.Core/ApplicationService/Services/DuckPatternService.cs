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
        public DuckPattern addDuckPattern(DuckPattern toAddDuckPattern)
        {
            return _duckPatternRepository.addDuckPattern(toAddDuckPattern);
        }

        public DuckPattern deleteDuckPattern(int toDeleteId)
        {
            return _duckPatternRepository.deleteDuckPattern(toDeleteId);
        }

        public DuckPattern updateDuckPattern(DuckPattern toUpdateDuckPattern)
        {
            return _duckPatternRepository.updateDuckPattern(toUpdateDuckPattern);
        }

        public List<DuckPattern> getDuckPatterns()
        {
            return _duckPatternRepository.readDuckPatterns();
        }
    }
}
