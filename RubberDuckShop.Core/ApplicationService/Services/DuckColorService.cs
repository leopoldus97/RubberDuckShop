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
        public DuckColor AddDuckColor(DuckColor toAddDuckColor)
        {
           return _duckColorRepository.AddDuckColor(toAddDuckColor);
        }

        public DuckColor DeleteDuckColor(int toDeleteId)
        {
            return _duckColorRepository.DeleteDuckColor(toDeleteId);
        }

        public DuckColor UpdateDuckColor(DuckColor toUpdateDuckColor)
        {
            return _duckColorRepository.UpdateDuckColor(toUpdateDuckColor);
        }

        public DuckColor getDuckColorById(int id)
        {
            return _duckColorRepository.readDuckColorById(id);
        }

        public List<DuckColor> getDuckColors()
        {
            return _duckColorRepository.readDuckColors();
        }
    }
}
