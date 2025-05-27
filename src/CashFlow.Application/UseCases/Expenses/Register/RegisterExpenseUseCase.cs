using CashFlow.Communication.Enum;
using CashFlow.Communication.Request;
using CashFlow.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpanseJson Execute(RequestExpanseRegisterJson request)
    {
        Validate(request);
        return new ResponseRegisteredExpanseJson();
    }
    private void Validate(RequestExpanseRegisterJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);

      if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ArgumentException();
        }

    }
}
