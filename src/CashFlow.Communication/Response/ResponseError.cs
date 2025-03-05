using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Communication.Response;
public class ResponseError
{
    public string ErrorMessage { get; set; } = string.Empty;
    public ResponseError(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}
