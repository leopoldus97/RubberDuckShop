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
        public DuckCostume AddDuckCostume(DuckCostume toAddDuckCostume)
        {
            return _duckCostumeRepository.AddDuckCostume(toAddDuckCostume);
        }

        public DuckCostume DeleteDuckCostume(int toDeleteId)
        {
            return _duckCostumeRepository.DeleteDuckCostume(toDeleteId);
        }

        public DuckCostume UpdateDuckCostume(DuckCostume toUpdateDuckCostume)
        {
            return _duckCostumeRepository.UpdateDuckCostume(toUpdateDuckCostume);
        }

        public DuckCostume GetDuckCostumeById(int id)
        {
            return _duckCostumeRepository.ReadDuckCostumeById(id);
        }

        public List<DuckCostume> GetDuckCostume()
        {
            return _duckCostumeRepository.ReadDuckCostume().ToList();
        }
    }
}
