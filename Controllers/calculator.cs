using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace.CalcOp;

namespace MyApp.Namespace
{
    
    [Route("[controller]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
    [HttpGet]
public IActionResult calculator(int numberOne, int numberTwo, calcAction calcOperation)
{
    switch (calcOperation)
    {
        case calcAction.Add:
            return Ok(numberOne + numberTwo);

        case calcAction.Subtract:
            return Ok(numberOne - numberTwo);

        case calcAction.Multiply:
            return Ok(numberOne * numberTwo);

        case calcAction.Divide:
            if (numberTwo == 0)
                return BadRequest("Division by zero is not allowed.");

            return Ok(numberOne / numberTwo);

        default:
            return BadRequest("Invalid operation.");
    }
}

    }
}
