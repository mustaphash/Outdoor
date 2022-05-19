using Infrastructure.Models;
using Infrastructure.Models.CreateModels;
using Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("lakes")]
        public async Task<IActionResult> GetAllLakes()
        {
            var lakes = await _placeService.GetAllLakes();

            return Ok(lakes);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLakes([FromForm]CreateLakesModel model)
        {
            await _placeService.CreateLakes(model);

            return Ok(model);
        }
    }
}
