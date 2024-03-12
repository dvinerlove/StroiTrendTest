using Microsoft.AspNetCore.Mvc;
using StroiTrendTest.Models;
using StroiTrendTest.Services;
using System.IO;

namespace StroiTrendTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeDataController : ControllerBase
    {
        [HttpGet("totalchats")]
        public ActionResult<TotalChatsReport<ChatData>> GetTotalChats()
        {
            return Ok(System.IO.File.ReadAllText("data/total-chats-report.json"));
        }

        [HttpGet("durationdata")]
        public ActionResult<TotalChatsReport<DurationData>> GetDuration()
        {
            return Ok(System.IO.File.ReadAllText("data/duration-report.json"));
        }

        [HttpGet("ratingsdata")]
        public ActionResult<TotalChatsReport<RatingsData>> GetRatings()
        {
            return Ok(System.IO.File.ReadAllText("data/ratings-report.json"));
        }

        [HttpGet("responsetimedata")]
        public ActionResult<TotalChatsReport<ResponseTimeData>> GetResponseTime()
        {
            return Ok(System.IO.File.ReadAllText("data/response-time-report.json"));
        }

        [HttpGet("tags")]
        public ActionResult<TotalChatsReport<TagsData>> GetTags()
        {
            return Ok(System.IO.File.ReadAllText("data/tags-report.json"));
        }
    }
}
