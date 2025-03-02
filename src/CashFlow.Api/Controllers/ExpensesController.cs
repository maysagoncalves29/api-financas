using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    
    public IActionResult Register([FromBody] RequestExpanseRegisterJson request)
    {
        var useCase = new RegisterExpenseUseCase();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }
}
