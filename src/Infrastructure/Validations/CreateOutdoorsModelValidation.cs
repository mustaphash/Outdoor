using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models;

namespace Infrastructure.Validations
{
    public class CreateOutdoorsModelValidation : IValidation<CreateOutdoorsModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateOutdoorsModelValidation(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Validate(CreateOutdoorsModel model)
        {
            Outdoor outdoor = await _unitOfWork.Outdoors.GetOutdoorById(model.Id);
        }
    }
}
