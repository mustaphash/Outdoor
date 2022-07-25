using Common;
using Common.LoggerRecources;
using Infrastructure.Models;
using Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace OutdoorPlace.Controllers
{
    [ApiController]
    [Route("api/nomenclatures")]
    public class NomenclatureController : Controller
    {
        private readonly INomenclatureService _nomenclatureService;
        private readonly ILogger _logger;

        public NomenclatureController(INomenclatureService nomenclatureService, ILogger logger)
        {
            _nomenclatureService = nomenclatureService;
            _logger = logger;
        }

        [HttpGet("animals")]
        [ProducesResponseType(typeof(IList<AnimalModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllAnimals()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(NomenclatureController), nameof(GetAllAnimals)));
            var animals = await _nomenclatureService.GetAllAnimals();

            return Ok(animals);
        }

        [HttpGet("extras")]
        [ProducesResponseType(typeof(IList<ExtrasModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllExtras()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(NomenclatureController), nameof(GetAllExtras)));
            var extras = await _nomenclatureService.GetAllExtras();

            return Ok(extras);
        }

        [HttpGet("waterTypes")]
        [ProducesResponseType(typeof(IList<WaterTypeModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllWaterTypes()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(NomenclatureController), nameof(GetAllWaterTypes)));
            var waterTypes = await _nomenclatureService.GetAllWaterTypes();

            return Ok(waterTypes);
        }
    }
}
