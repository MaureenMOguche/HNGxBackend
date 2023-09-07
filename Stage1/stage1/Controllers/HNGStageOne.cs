using Microsoft.AspNetCore.Mvc;
using stage1.Models;

namespace stage1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HNGStageOne : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet()]
        public IActionResult GetHNGDetails(string slack_name, string track)
        {
            var names = slack_name.Split(' ');
            if ((slack_name.ToLower().Contains("maureen") || slack_name.ToLower().Contains("oguche")) 
                && track.ToLower() == "backend")
            {
                HngDetail detail = new HngDetail{
                    SlackName = "Maureen Oguche",
                    CurrentDay = DateTime.UtcNow.DayOfWeek.ToString(),
                    UtcTime = DateTime.UtcNow.TimeOfDay.ToString(),
                    Track = "Backend",
                    GithubFile = "https://github.com/MaureenMOguche/HNGxBackend/blob/main/Stage1/stage1/Controllers/HNGStageOne.cs",
                    GithubRepo = "https://github.com/MaureenMOguche/HNGxBackend",
                    StatusCode = 200
                };
                return Ok(detail);
            }
            return NotFound("user detail not found");
        }
    }
}