using CashFlow.Communication.Request;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseValidator : AbstractValidator<RequestExpanseRegisterJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title)
                    .NotEmpty()
                    .WithMessage("Title is required");
        RuleFor(expense => expense.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than zero");
        RuleFor(expense => expense.Date)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("Date must be greater than today");
        RuleFor(expense => expense.PaymentTypes)
            .IsInEnum()
            .WithMessage("Payment type is not valid.");
    }
}
