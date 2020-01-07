using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<City>> GetAll()
        {
            _logger.LogInformation("Service = Obtendo todas as cidades");
            var result = await _cityRepository.GetAll();
            _logger.LogInformation("Service = Cidades obtidas");
            return result;
        }
    }
}