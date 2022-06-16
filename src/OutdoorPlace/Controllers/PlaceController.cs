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
        public async Task<IActionResult> CrateOutdoors([FromForm]CreateOutdoorModel model)
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
        public async Task<IActionResult> CreateLakes([FromForm]CreateLakesModel model)
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

        //Fountain
        [HttpGet("fountains")]
        public async Task<IActionResult> GetAllFountains()
        {
            var fountains = await _placeService.GetAllFountain();

            return Ok(fountains);
        }

        //Landmark
        [HttpGet("landmarks")]
        public async Task<IActionResult> GetAllLandmarks()
        {
            var landmarks = await _placeService.GetAllLandmarks();

            return Ok(landmarks);
        }

        //NatureReserve
        [HttpGet("natureReserves")]
        public async Task<IActionResult> GetAllNatureReserves()
        {
            var natureReserves = await _placeService.GetAllNatureReserves();

            return Ok(natureReserves);
        }

        //Villa
        [HttpGet("villas")]
        public async Task<IActionResult> GetAllVillas()
        {
            var villas = await _placeService.GetAllVilla();

            return Ok(villas);
        }
    }
}
