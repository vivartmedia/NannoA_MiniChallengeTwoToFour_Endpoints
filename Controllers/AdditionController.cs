
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeTwoToFour_Endpoints.Services.AddService;


namespace NannoA_MiniChallengeTwoToFour_Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class AdditionController : ControllerBase
{
    private readonly IAddService _addService;

    public AdditionController(IAddService addService)
    {
        _addService = addService;
    }


    [HttpGet]
    [Route("Add2Numbers/{number1}/{number2}")]
    public string Add2Numbers(double number1, double number2)
    {
        return _addService.Add2Numbers(number1, number2);
    }
}
