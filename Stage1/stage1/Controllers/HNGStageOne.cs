using Microsoft.AspNetCore.Mvc;
using stage1.Models;

namespace stage1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HNGStageOne : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetHNGDetails(string slack_name, string track)
        {
            var names = slack_name.Split(' ');
            if (slack_name.ToLower().Contains("maureen") || slack_name.ToLower().Contains("oguche")){
                HngDetail detail = new HngDetail{
                    SlackName = "Maureen Oguche",
                    CurrentDay = DateTime.UtcNow.DayOfWeek.ToString(),
                    UtcTime = DateTime.UtcNow.TimeOfDay.ToString(),
                    Track = "Backend",
                    GithubFile = "",
                    GithubRepo = "",
                    StatusCode = 200
                };
                return Ok(detail);
            }
            return NotFound("user detail not found");
        }
    }
}