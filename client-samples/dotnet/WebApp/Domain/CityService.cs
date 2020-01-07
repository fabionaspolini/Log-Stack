using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace WebApp.Domain
{
    public class CityService
    {
        private readonly CityRepository _cityRepository;
        private readonly ILogger<CityService> _logger;

        public CityService(CityRepository cityRepository, ILogger<CityService> logger)
        {
            _cityRepository = cityRepository;
            _logger = logger;
        }

        public IEnumerable<City> GetAll()
        {
            _logger.LogInformation("Obtendo todas as cidades");
            return _cityRepository.GetAll();
        }
    }
}