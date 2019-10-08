using System;
using System.Collections.Generic;
using System.Linq;
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
        public DuckPattern AddDuckPattern(DuckPattern toAddDuckPattern)
        {
            return _duckPatternRepository.AddDuckPattern(toAddDuckPattern);
        }

        public DuckPattern DeleteDuckPattern(int toDeleteId)
        {
            return _duckPatternRepository.DeleteDuckPattern(toDeleteId);
        }

        public DuckPattern UpdateDuckPattern(DuckPattern toUpdateDuckPattern)
        {
            return _duckPatternRepository.UpdateDuckPattern(toUpdateDuckPattern);
        }

        public DuckPattern getDuckPatternById(int id)
        {
            return _duckPatternRepository.readDuckPatternById(id);
        }

        public List<DuckPattern> getDuckPatterns()
        {
            return _duckPatternRepository.readDuckPatterns().ToList();
        }
    }
}
