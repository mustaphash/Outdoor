using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models;
using Infrastructure.Models.CreateModels;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Validations
{
    public class CreateFountainsModelValidator : IValidation<CreateFountainsModel>
    {
        private readonly ILogger<CreateFountainsModelValidator> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateFountainsModelValidator(ILogger<CreateFountainsModelValidator> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task Validate(CreateFountainsModel model)
        {
            List<string> errors = new List<string>();

            WaterType waterType = await _unitOfWork.WaterTypes.GetWaterTypeById(model.WaterTypeId);
            if (waterType == null)
            {
                errors.Add($"{nameof(WaterType)} with id {model.WaterTypeId} is not found!");
                
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                errors.Add("Name cannot be empty!");
            }
        }
    }
}
