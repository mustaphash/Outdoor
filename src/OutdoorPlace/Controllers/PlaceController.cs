using Common;
using Common.LoggerRecources;
using Infrastructure.Models;
using Infrastructure.Models.CreateModels;
using Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace OutdoorPlace.Controllers
{
    [ApiController]
    [Route("api/places")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeService;
        private readonly ILogger _logger;

        public PlaceController(ILogger<PlaceController> logger, IPlaceService placeService_)
        {
            _placeService = placeService_;
            _logger = logger;
        }

        //Outdoor
        [HttpGet("outdoors")]
        [ProducesResponseType(typeof(IList<OutdoorModel>), 200)]
        public async Task<IActionResult> GetAllOutdoors()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllOutdoors)));

            var outdoors = await _placeService.GetAllOutdoors();

            return Ok(outdoors);
        }

        [HttpPost("outdoor")]
        public async Task<IActionResult> CreateOutdoors([FromForm] CreateOutdoorsModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateOutdoors)));

            await _placeService.CreateOutdoor(model);

            return Ok(model);
        }

        [HttpDelete("outdoor")]
        public async Task<IActionResult> DeleteOutdoor(int outId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteOutdoor)));

            await _placeService.DeleteOutdoor(outId);

            return NoContent();
        }

        //Lake
        [HttpGet("lakes")]
        public async Task<IActionResult> GetAllLakes()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllLakes)));

            var lakes = await _placeService.GetAllLakes();

            return Ok(lakes);
        }

        [HttpPost("lake")]
        public async Task<IActionResult> CreateLakes([FromForm] CreateLakesModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateLakes)));

            await _placeService.CreateLakes(model);

            return Ok(model);
        }

        [HttpDelete("lake")]
        public async Task<IActionResult> DeleteLakes(int lakeId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteLakes)));

            await _placeService.DeleteLake(lakeId);

            return NoContent();
        }

        //Park
        [HttpGet("parks")]
        public async Task<IActionResult> GetAllParks()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllParks)));

            var parks = await _placeService.GetAllPark();

            return Ok(parks);
        }

        [HttpPost("park")]
        public async Task<IActionResult> CreateParks([FromForm] CreateParksModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateParks)));

            await _placeService.CreatePark(model);

            return NoContent();
        }

        [HttpDelete("park")]
        public async Task<IActionResult> DeleteParks(int parkId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteParks)));

            await _placeService.DeletePark(parkId);

            return NoContent();
        }

        //Fountain
        [HttpGet("fountains")]
        public async Task<IActionResult> GetAllFountains()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllFountains)));

            var fountains = await _placeService.GetAllFountain();

            return Ok(fountains);
        }

        [HttpPost("fountain")]
        public async Task<IActionResult> CreateFountain([FromForm] CreateFountainsModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateFountain)));

            await _placeService.CreateFountain(model);

            return NoContent();
        }

        [HttpDelete("fountain")]
        public async Task<IActionResult> DeleteFountain(int fountainId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteFountain)));

            await _placeService.DeleteFountain(fountainId);

            return NoContent();
        }

        //Landmark
        [HttpGet("landmarks")]
        public async Task<IActionResult> GetAllLandmarks()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllLandmarks)));

            var landmarks = await _placeService.GetAllLandmarks();

            return Ok(landmarks);
        }

        [HttpPost("landmark")]
        public async Task<IActionResult> CreateLandmark([FromForm] CreateLandmarksModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateLandmark)));

            await _placeService.CreateLandmark(model);

            return NoContent();
        }

        [HttpDelete("landmark")]
        public async Task<IActionResult> DeleteLandmark(int landmarkId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteLandmark)));

            await _placeService.DeleteLandmark(landmarkId);

            return NoContent();
        }

        //NatureReserve
        [HttpGet("natureReserves")]
        public async Task<IActionResult> GetAllNatureReserves()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllNatureReserves)));

            var natureReserves = await _placeService.GetAllNatureReserves();

            return Ok(natureReserves);
        }

        [HttpPost("natureReserve")]
        public async Task<IActionResult> CreateNatureReserve([FromForm] CreateNatureReservesModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateNatureReserve)));

            await _placeService.CreateNatureReserve(model);

            return NoContent();
        }

        [HttpDelete("natureReserve")]
        public async Task<IActionResult> DeleteNatureReserve(int natureReserveId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteNatureReserve)));

            await _placeService.DeleteNatureReserve(natureReserveId);

            return NoContent();
        }

        //Villa
        [HttpGet("villas")]
        public async Task<IActionResult> GetAllVillas()
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(GetAllVillas)));

            var villas = await _placeService.GetAllVilla();

            return Ok(villas);
        }

        [HttpPost("villa")]
        public async Task<IActionResult> CreateVilla([FromForm] CreateVillasModel model)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(CreateVilla)));

            await _placeService.CreateVilla(model);

            return NoContent();
        }

        [HttpDelete("villa")]
        public async Task<IActionResult> DeleteVilla(int villaId)
        {
            _logger.LogInformation(LogMessages.ControllerFound, string.Format(LogMessageResources.ControllerFound, nameof(PlaceController), nameof(DeleteVilla)));

            await _placeService.DeleteVilla(villaId);

            return NoContent();
        }
    }
}
