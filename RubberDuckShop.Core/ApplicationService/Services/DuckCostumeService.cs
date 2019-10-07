using System;
using System.Collections.Generic;
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
        public DuckCostume addDuckCostume(DuckCostume duckCostume)
        {
            return _duckCostumeRepository.addDuckCostume(duckCostume);
        }

        public DuckCostume deleteDuckCostume(DuckCostume duckCostume)
        {
            return _duckCostumeRepository.deleteDuckCostume(duckCostume);
        }

        public DuckCostume updateDuckCostume(DuckCostume duckCostume)
        {
            return _duckCostumeRepository.updateDuckCostume(duckCostume);
        }

        public List<DuckCostume> getDuckCostume()
        {
            return _duckCostumeRepository.readDuckCostume();
        }
    }
}
