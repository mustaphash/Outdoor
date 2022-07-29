using Common;
using Common.LoggerRecources;
using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models.CreateModels;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Validations
{
    public class CreateVillasModelValidator : IValidation<CreateVillasModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CreateVillasModelValidator(IUnitOfWork unitOfWork, ILogger<CreateVillasModelValidator> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task Validate(CreateVillasModel model)
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
