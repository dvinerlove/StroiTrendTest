using Microsoft.AspNetCore.Mvc;
using StroiTrendTest.Models;
using StroiTrendTest.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StroiTrendTest.Controllers
{
    public class DataListController : Controller
    {
        private readonly ChatDataService _chatDataService;
        private const int ItemsPerPage = 7;

        public DataListController(ChatDataService chatDataService)
        {
            _chatDataService = chatDataService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var chatData = await _chatDataService.GetTotalChatsAsync();

            page -= 1;
            IEnumerable<KeyValuePair<DateTime, Models.ChatData>> list = chatData.Records.Where(x => x.Key.Day > 7 * page && x.Key.Day <= 7 + 7 * page);
            int weeks = GetWeeksBetweenDates(chatData.Request.Filters.From, chatData.Request.Filters.To);

            ViewBag.TotalPages = weeks;
            ViewBag.CurrentPage = page;

            return View(list);
        }

        public async Task<IActionResult> Details(DateTime date)
        {
            DateDetails details = new DateDetails()
            {
                Date = date,
                Duration = await _chatDataService.GetReportData<DurationData>(date),
                Ratings = await _chatDataService.GetReportData<RatingsData>(date),
                ResponseTime = await _chatDataService.GetReportData<ResponseTimeData>(date),
                Tags = await _chatDataService.GetTags(date),
                Total = await _chatDataService.GetTotal(date),
            };
            return View(details);
        }

        private static int GetWeeksBetweenDates(DateTime fromDate, DateTime toDate)
        {
            int totalDays = (int)(toDate - fromDate).TotalDays;

            int weeks = (int)Math.Ceiling((double)totalDays / 7);

            return weeks;
        }
    }
}
