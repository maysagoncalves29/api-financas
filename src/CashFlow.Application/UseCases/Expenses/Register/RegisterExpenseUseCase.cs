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
        return new ResponseRegisteredExpanseJson();
    }
}
