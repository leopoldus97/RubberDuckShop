using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.Core.ApplicationService.Services
{
    public class DuckCostumeService: IDuckCostumeService
    {
        private readonly IDuckCostumeRepository _duckCostumeRepository;

        public DuckCostumeService(IDuckCostumeRepository duckCostumeRepository)
        {
            _duckCostumeRepository = duckCostumeRepository;
        }
        public DuckCostume addDuckCostume(DuckCostume toAddDuckCostume)
        {
            return _duckCostumeRepository.addDuckCostume(toAddDuckCostume);
        }

        public DuckCostume deleteDuckCostume(int toDeleteId)
        {
            return _duckCostumeRepository.deleteDuckCostume(toDeleteId);
        }

        public DuckCostume updateDuckCostume(DuckCostume toUpdateDuckCostume)
        {
            return _duckCostumeRepository.updateDuckCostume(toUpdateDuckCostume);
        }

        public List<DuckCostume> getDuckCostume()
        {
            return _duckCostumeRepository.readDuckCostume().ToList();
        }
    }
}
