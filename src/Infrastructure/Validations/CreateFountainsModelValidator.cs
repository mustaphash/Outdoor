using Common;
using Common.LoggerRecources;
using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models.CreateModels;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Validations
{
    public class CreateFountainsModelValidator : IValidation<CreateFountainsModel>
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateFountainsModelValidator(ILogger<CreateFountainsModelValidator> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task Validate(CreateFountainsModel model)
        {
            List<string> errors = new List<string>();

            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.WaterTypeId)));
            WaterType waterType = await _unitOfWork.WaterTypes.GetWaterTypeById(model.WaterTypeId);

            if (waterType == null)
            {
                string message = $"{nameof(WaterType)} with id {model.WaterTypeId} is not found!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.WaterTypeId), message));
                errors.Add(message);
            }
            _logger.LogInformation(LogMessages.ValidatedItem, string.Format(LogMessageResources.ValidatedItem, nameof(model.WaterTypeId)));

            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.Name)));
            if (string.IsNullOrEmpty(model.Name))
            {
                string message = "Name cannot be empty!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }
            _logger.LogInformation(LogMessages.ValidatedItem, string.Format(LogMessageResources.ValidatedItem, nameof(model.Name)));
        }
    }
}
