using Common;
using Common.LoggerRecources;
using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models.CreateModels;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Validations
{
    public class CreateLandmarkModelValidator : IValidation<CreateLandmarksModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CreateLandmarkModelValidator(IUnitOfWork unitOfWork, ILogger<CreateLandmarkModelValidator> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task Validate(CreateLandmarksModel model)
        {
            List<string> errors = new List<string>();

            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.Extras)));
            List<Extras> extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            foreach (var extra in extras)
            {
                if (extra == null)
                {
                    string message = $"{nameof(Extras)}, {extra} is not found!";
                    _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Extras), message));
                    errors.Add(message);
                }
            }
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

        }
    }
}
