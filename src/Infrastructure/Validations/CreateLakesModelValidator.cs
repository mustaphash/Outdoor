using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models.CreateModels;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Validations
{
    public class CreateLakesModelValidator : IValidation<CreateLakesModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateLakesModelValidator> _logger;

        public CreateLakesModelValidator(
            IUnitOfWork unitOfWork,
            ILogger<CreateLakesModelValidator> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task Validate(CreateLakesModel model)
        {
            List<string> errors = new List<string>();

            Animal animals = await _unitOfWork.Animals.GetAnimalsByIds(model.Animals);
        }
    }
}
