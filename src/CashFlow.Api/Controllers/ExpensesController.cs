using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Request;
using CashFlow.Communication.Response;
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
        try
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
        catch (ArgumentException ex) 
        {
            var errorMessage = new ResponseError(ex.Message);
            errorMessage.ErrorMessage = ex.Message;
            return BadRequest(errorMessage);
            
        }
        catch
        {
            var errorMessage = new ResponseError("unknown error");
            
            return StatusCode(StatusCodes.Status500InternalServerError, errorMessage);
        }
    }
}
