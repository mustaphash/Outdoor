﻿using DAL;
using Infrastructure.Models;
using Infrastructure.Services.Abstract;

namespace Infrastructure.Services
{
    public class NomenclatureService : INomenclatureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NomenclatureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<AnimalModel>> GetAllAnimals()
        {
            var animals = await _unitOfWork.Animals.GetAll();
            var animalsModel = animals.Select(a => new AnimalModel(a)).ToList();

            return animalsModel;
        }
    }
}