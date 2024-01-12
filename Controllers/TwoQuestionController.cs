
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeTwoToFour_Endpoints.Services.TwoQuestionService;

namespace NannoA_MiniChallengeTwoToFour_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class TwoQuestionController : Controller
{
    private readonly ITwoQuestionService _twoQuestionService;

    public TwoQuestionController(ITwoQuestionService twoQuestionService)
    {
        _twoQuestionService = twoQuestionService;
    }


    [HttpGet]
    [Route("Questions2Answers/{name}/{time}")]
    public string Questions2Answers(string name, string time)
    {
        return _twoQuestionService.Questions2Answers(name, time);
    }
}
