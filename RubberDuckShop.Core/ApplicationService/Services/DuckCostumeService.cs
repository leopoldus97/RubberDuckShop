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
            throw new NotImplementedException();
        }

        public DuckCostume deleteDuckCostume(DuckCostume duckCostume)
        {
            throw new NotImplementedException();
        }

        public DuckCostume updateDuckCostume(DuckCostume duckCostume)
        {
            throw new NotImplementedException();
        }

        public List<DuckCostume> getDuckCostume()
        {
            throw new NotImplementedException();
        }
    }
}
