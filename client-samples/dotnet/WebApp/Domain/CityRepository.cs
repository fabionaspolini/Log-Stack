using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WebApp.Domain
{
    public class CityRepository
    {
        private readonly ILogger<CityRepository> _logger;

        public CityRepository(ILogger<CityRepository> logger)
        {
            _logger = logger;
        }

#pragma warning disable 1998
        public async Task<IEnumerable<City>> GetAll()
#pragma warning restore 1998
        {
            _logger.LogInformation("Obtendo todas as cidades");
            return new[]
            {
                new City {Id = 1, Name = "City 1", State = "ST-A"},
                new City {Id = 2, Name = "City 2", State = "ST-A"},
                new City {Id = 2, Name = "City 3", State = "ST-B"},
            };
        }
    }
}