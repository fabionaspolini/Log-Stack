using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Domain;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly CityService _cityService;
        private readonly ILogger<CitiesController> _logger;

        public CitiesController(ILogger<CitiesController> logger, CityService cityService)
        {
            _cityService = cityService;
            _logger = logger;
        }

        [HttpGet]
        public Task<IEnumerable<City>> Get()
        {
            _logger.LogInformation("Obter todas as cidades");
            return _cityService.GetAll();
        }

        [HttpGet("CustomError")]
        public void CustomError()
        {
            try
            {
                int.Parse("abc");
            }
            catch (Exception e)
            {
                throw new Exception("Teste erro conversão número", e);
            }
        }

        [HttpGet("Error")]
        public void Error()
        {
            int.Parse("abc");
        }
        
        [HttpGet("Fatal")]
        public void Fatal()
        {
            try
            {
                int.Parse("abc");
            }
            catch
            {
                _logger.LogCritical("ERRO AO CONVERTER NUMERO!");
                throw;
            }
        }
    }
}