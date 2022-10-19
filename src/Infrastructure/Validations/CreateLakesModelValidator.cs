using Common;
using Common.LoggerRecources;
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
        private readonly ILogger _logger;

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

            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.Animals)));
            if (model.Animals != null && model.Animals.Any())
            {
                List<Animal> animals = await _unitOfWork.Animals.GetAnimalsByIds(model.Animals);
                if (animals.Count != model.Animals.Count)
                {
                    string message = $"{nameof(Animal)}, not all animals are present in the system!";
                    _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Animals), message));
                    errors.Add(message);
                }
            }

            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.Extras)));
            if (model.Extras != null && model.Extras.Any())
            {
                List<Extras> extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
                if (extras.Count != model.Extras.Count)
                {
                    string message = $"{nameof(Extras)}, not all extras are present in the system!";
                    _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Extras), message));
                    errors.Add(message);
                }
            }
            _logger.LogInformation(LogMessages.ValidatingItem, string.Format(LogMessageResources.ValidatingItem, nameof(model.Name)));

            if (string.IsNullOrEmpty(model.Name) || model.Name.Length > 200)
            {
                string message = "Name cannot be empty or long than 200 charracters!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            } 

            if (string.IsNullOrEmpty(model.Description) || model.Description.Length > 1000)
            {
                string message = "Description cannot be null or longer than 1000 charracters!";
                _logger.LogInformation(LogMessages.ValidationFailed, string.Format(LogMessageResources.ValidationFailed, nameof(model.Name), message));
                errors.Add(message);
            }

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
