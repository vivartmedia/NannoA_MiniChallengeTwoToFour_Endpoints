
using Microsoft.AspNetCore.Mvc;

namespace NannoA_MiniChallengeTwoToFour_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class TwoQuestionController : Controller
    {
        [HttpGet]
        [Route("Questions2Answers/{name}/{time}")]
        public string Questions2Answers(string name, string time)
        {
        return $"Hey {name} you woke up at {time}";
        }
    }
