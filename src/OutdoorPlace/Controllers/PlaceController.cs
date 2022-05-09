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

        [HttpGet("outdoors")]
        public async Task<IActionResult> GetAllOutdoors()
        {
            var outdoors = await _placeService.GetAllOutdoors();

            return Ok(outdoors);
        }
    }
}
