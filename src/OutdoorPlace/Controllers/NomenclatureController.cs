﻿using Infrastructure.Models;
using Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace OutdoorPlace.Controllers
{
    [ApiController]
    [Route("api/nomenclatures")]
    public class NomenclatureController : Controller
    {
        private readonly INomenclatureService _nomenclatureService;

        public NomenclatureController(INomenclatureService nomenclatureService)
        {
            _nomenclatureService = nomenclatureService;
        }

        [HttpGet("animals")]
        [ProducesResponseType(typeof(IList<AnimalModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllAnimals()
        {
            var animals = await _nomenclatureService.GetAllAnimals();

            return Ok(animals);
        }
    }
}
