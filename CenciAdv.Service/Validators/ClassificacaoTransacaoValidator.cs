using FluentValidation;
using CenciAdv.Domain.Entities;


namespace CenciAdv.Service.Validators
{
    public class ClassificacaoTransacaoValidator : AbstractValidator<ClassificacaoTransacao>
    {
        public ClassificacaoTransacaoValidator()
        {
            RuleFor(c => c.CodAgrupamento)
                .NotEmpty().WithMessage("Por favor informe o código do agrupamento.")
                .NotNull().WithMessage("Por favor informe o código do agrupamento.");


            

            RuleFor(c => c.NomeAgrupamento)
                .NotEmpty().WithMessage("Por favor informe o nome do agrupamento.")
                .NotNull().WithMessage("Por favor informe o nome do agrupamento.");

         
        }
    }
}
