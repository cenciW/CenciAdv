
using FluentValidation;
using CenciAdv.Domain.Entities;

namespace CenciAdv.Service.Validators
{
    public class ConsultaValidator : AbstractValidator<Consulta>
    {
        public ConsultaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");

            RuleFor(c => c.Advogado)
                .NotEmpty().WithMessage("Por favor informe o Advogado que irá realizar a consulta.")
                .NotNull().WithMessage("Por favor informe o Advogado que irá realizar a consulta.");

            RuleFor(c => c.Cliente)
                .NotEmpty().WithMessage("Por favor informe o Cliente que irá ser atendido.")
                .NotNull().WithMessage("Por favor informe o Cliente que irá ser atendido.");

        }
    }
}
