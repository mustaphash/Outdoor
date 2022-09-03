using Common;
using Common.Exceptions;
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
            IDictionary<string, string> error = new Dictionary<string, string>();
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
#pragma warning disable CS8602 
            if (string.IsNullOrEmpty(model.Name) || model.Name.Length > 200)
            {
                string message = "Name cannot be empty or long than 200 charracters!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }
            if (string.IsNullOrEmpty(model.Description) || model.Description.Length > 1000)
            {
                string message = "Description cannot be null or long than 1000 charracters!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }
#pragma warning disable CS8602
            if (model.Longitude <= 0)
            {
                string message = "Longitude cannot be negative or zero!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }
            if (model.Latitude <= 0)
            {
                string message = "Latitude cannot be negative or zero!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }
            _logger.LogInformation(LogMessages.ValidatedItem, string.Format(LogMessageResources.ValidatedItem, nameof(model.Name)));

            if (errors.Any())
            {
                string message = string.Join(Environment.NewLine, errors);
                _logger.LogWarning(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(CreateFountainsModel), message));
                throw new BadRequestException(message);
            }
        }
    }
}
