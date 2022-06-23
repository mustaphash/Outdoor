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

        public PlaceController(IPlaceService placeService_)
        {
            _placeService = placeService_;
        }

        //Outdoor
        [HttpGet("outdoors")]
        [ProducesResponseType(typeof(IList<OutdoorModel>), 200)]
        public async Task<IActionResult> GetAllOutdoors()
        {
            var outdoors = await _placeService.GetAllOutdoors();

            return Ok(outdoors);
        }

        [HttpPost("outdoor")]
        public async Task<IActionResult> CrateOutdoors([FromForm] CreateOutdoorsModel model)
        {
            await _placeService.CreateOutdoor(model);

            return Ok(model);
        }

        //Lake
        [HttpGet("lakes")]
        public async Task<IActionResult> GetAllLakes()
        {
            var lakes = await _placeService.GetAllLakes();

            return Ok(lakes);
        }

        [HttpPost("lake")]
        public async Task<IActionResult> CreateLakes([FromForm] CreateLakesModel model)
        {
            await _placeService.CreateLakes(model);

            return Ok(model);
        }

        //Park
        [HttpGet("parks")]
        public async Task<IActionResult> GetAllParks()
        {
            var parks = await _placeService.GetAllPark();

            return Ok(parks);
        }

        [HttpPost("park")]
        public async Task<IActionResult> CreateParks([FromForm] CreateParksModel model)
        {
            await _placeService.CreatePark(model);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteParks(int parkId)
        {
            
            await _placeService.Delete(parkId);

            return NoContent();
        }

        //Fountain
        [HttpGet("fountains")]
        public async Task<IActionResult> GetAllFountains()
        {
            var fountains = await _placeService.GetAllFountain();

            return Ok(fountains);
        }

        [HttpPost("fountain")]
        public async Task<IActionResult> CreateFountain([FromForm] CreateFountainsModel model)
        {
            await _placeService.CreateFountain(model);

            return NoContent();
        }

        //Landmark
        [HttpGet("landmarks")]
        public async Task<IActionResult> GetAllLandmarks()
        {
            var landmarks = await _placeService.GetAllLandmarks();

            return Ok(landmarks);
        }

        [HttpPost("landmark")]
        public async Task<IActionResult> CreateLandmark([FromForm] CreateLandmarksModel model)
        {
            await _placeService.CreateLandmark(model);

            return NoContent();
        }

        //NatureReserve
        [HttpGet("natureReserves")]
        public async Task<IActionResult> GetAllNatureReserves()
        {
            var natureReserves = await _placeService.GetAllNatureReserves();

            return Ok(natureReserves);
        }

        [HttpPost("natureReserve")]
        public async Task<IActionResult> CreateNatureReserve([FromForm] CreateNatureReservesModel model)
        {
            await _placeService.CreateNatureReserve(model);

            return NoContent();
        }

        //Villa
        [HttpGet("villas")]
        public async Task<IActionResult> GetAllVillas()
        {
            var villas = await _placeService.GetAllVilla();

            return Ok(villas);
        }

        [HttpPost("villa")]
        public async Task<IActionResult> CreateVilla([FromForm] CreateVillasModel model)
        {
            await _placeService.CreateVilla(model);

            return NoContent();
        }
    }
}
