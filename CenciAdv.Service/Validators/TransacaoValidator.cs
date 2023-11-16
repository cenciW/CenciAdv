
using FluentValidation;
using CenciAdv.Domain.Entities;

namespace CenciAdv.Service.Validators
{
    public class TransacaoValidator : AbstractValidator<Transacao>
    {
        public TransacaoValidator()
        {
            RuleFor(c => c.Valor)
                .NotEmpty().WithMessage("Por favor informe o valor da transação.")
                .NotNull().WithMessage("Por favor informe o valor da transação.");

            RuleFor(c => c.DataTransacao)
                .NotEmpty().WithMessage("Por favor informe a data da Transação.")
                .NotNull().WithMessage("Por favor informe a data da Transação.");

            RuleFor(c => c.TipoTransacao)
                .NotEmpty().WithMessage("Por favor informe o Tipo da transação.")
                .NotNull().WithMessage("Por favor informe o Tipo da transação.");
        }
    }
}
