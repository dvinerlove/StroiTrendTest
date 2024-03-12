using Microsoft.AspNetCore.Mvc;
using StroiTrendTest1.Models;
using StroiTrendTest1.Services;
using System.Diagnostics;

namespace StroiTrendTest1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChatDataService _chatDataService;

        public HomeController(ChatDataService chatDataService)
        {
            _chatDataService = chatDataService;
        }
        public async Task<IActionResult> Index()
        {
            var totalChats = await _chatDataService.GetTotalChatsAsync();
            return View(totalChats);
        }
        public IActionResult DataList()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
