using Microsoft.AspNetCore.Mvc;
using StroiTrendTest.Models;

namespace StroiTrendTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeDataController : ControllerBase
    {
        [HttpGet("totalchats")]
        public IActionResult GetTotalChats()
        {
            //TotalChatsReport<ChatData> totalChatsReport = new TotalChatsReport<ChatData>
            //{
            //    Name = "total-chats-report",
            //    Request = new RequestData
            //    {
            //        Distribution = "day",
            //        Filters = new FiltersData
            //        {
            //            From = DateTime.Parse("2024-01-01T02:00:00+02:00"),
            //            To = DateTime.Parse("2024-01-14T02:00:00+02:00"),
            //            Groups = new GroupsData
            //            {
            //                Values = new List<int> { 1, 2, 3 }
            //            }
            //        }
            //    },
            //    Total = 10399,
            //    Records = new Dictionary<DateTime, ChatData>
            //    {
            //        { DateTime.Parse("2024-01-01"), new ChatData { Total = 760 } },
            //        { DateTime.Parse("2024-01-02"), new ChatData { Total = 819 } },
            //        { DateTime.Parse("2024-01-03"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-04"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-05"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-06"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-07"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-08"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-09"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-10"), new ChatData { Total = 815 } },
            //        { DateTime.Parse("2024-01-11"), new ChatData { Total = 815 } },
            //    }
            //};
            return Ok("{\r\n  \"name\": \"total-chats-report\",\r\n  \"request\": {\r\n    \"distribution\": \"day\",\r\n    \"filters\": {\r\n      \"from\": \"2024-01-01T02:00:00+02:00\",\r\n      \"to\": \"2024-01-14T02:00:00+02:00\",\r\n      \"groups\": {\r\n        \"values\": [1, 2, 3]\r\n      }\r\n    }\r\n  },\r\n  \"total\": 10399,\r\n  \"records\": {\r\n    \"2024-01-01\": { \"total\": 760 },\r\n    \"2024-01-02\": { \"total\": 819 },\r\n    \"2024-01-03\": { \"total\": 815 },\r\n    \"2024-01-04\": { \"total\": 806 },\r\n    \"2024-01-05\": { \"total\": 721 },\r\n    \"2024-01-06\": { \"total\": 735 },\r\n    \"2024-01-07\": { \"total\": 742 },\r\n    \"2024-01-08\": { \"total\": 839 },\r\n    \"2024-01-09\": { \"total\": 766 },\r\n    \"2024-01-10\": { \"total\": 752 },\r\n    \"2024-01-11\": { \"total\": 807 },\r\n    \"2024-01-12\": { \"total\": 866 },\r\n    \"2024-01-13\": { \"total\": 895 },\r\n    \"2024-01-14\": { \"total\": 76 }\r\n  }\r\n}\r\n");
        }

        [HttpGet("durationdata")]
        public ActionResult<IEnumerable<DurationData>> GetDuration()
        {
        
            return Ok("{\r\n  \"name\": \"duration-report\",\r\n  \"request\": {\r\n    \"distribution\": \"day\",\r\n    \"filters\": {\r\n      \"from\": \"2024-01-01T02:00:00+02:00\",\r\n      \"to\": \"2024-01-14T02:00:00+02:00\",\r\n      \"groups\": {\r\n        \"values\": [1, 2, 3]\r\n      }\r\n    }\r\n  },\r\n  \"total\": 10399,\r\n  \"records\": {\r\n    \"2024-01-01\": {\r\n      \"agents_chatting_duration\": 407,\r\n      \"count\": 760,\r\n      \"duration\": 590\r\n    },\r\n    \"2024-01-02\": {\r\n      \"agents_chatting_duration\": 394,\r\n      \"count\": 819,\r\n      \"duration\": 560\r\n    },\r\n    \"2024-01-03\": {\r\n      \"agents_chatting_duration\": 396,\r\n      \"count\": 815,\r\n      \"duration\": 556\r\n    },\r\n    \"2024-01-04\": {\r\n      \"agents_chatting_duration\": 444,\r\n      \"count\": 806,\r\n      \"duration\": 593\r\n    },\r\n    \"2024-01-05\": {\r\n      \"agents_chatting_duration\": 420,\r\n      \"count\": 721,\r\n      \"duration\": 565\r\n    },\r\n    \"2024-01-06\": {\r\n      \"agents_chatting_duration\": 381,\r\n      \"count\": 735,\r\n      \"duration\": 531\r\n    },\r\n    \"2024-01-07\": {\r\n      \"agents_chatting_duration\": 385,\r\n      \"count\": 742,\r\n      \"duration\": 556\r\n    },\r\n    \"2024-01-08\": {\r\n      \"agents_chatting_duration\": 461,\r\n      \"count\": 839,\r\n      \"duration\": 633\r\n    },\r\n    \"2024-01-09\": {\r\n      \"agents_chatting_duration\": 470,\r\n      \"count\": 766,\r\n      \"duration\": 629\r\n    },\r\n    \"2024-01-10\": {\r\n      \"agents_chatting_duration\": 385,\r\n      \"count\": 752,\r\n      \"duration\": 532\r\n    },\r\n    \"2024-01-11\": {\r\n      \"agents_chatting_duration\": 438,\r\n      \"count\": 807,\r\n      \"duration\": 591\r\n    },\r\n    \"2024-01-12\": {\r\n      \"agents_chatting_duration\": 388,\r\n      \"count\": 866,\r\n      \"duration\": 528\r\n    },\r\n    \"2024-01-13\": {\r\n      \"agents_chatting_duration\": 456,\r\n      \"count\": 895,\r\n      \"duration\": 612\r\n    },\r\n    \"2024-01-14\": {\r\n      \"agents_chatting_duration\": 410,\r\n      \"count\": 76,\r\n      \"duration\": 535\r\n    }\r\n  }\r\n}\r\n");
        }

        [HttpGet("ratingsdata")]
        public ActionResult<IEnumerable<RatingsData>> GetRatings()
        {
           
            return Ok("{\r\n    \"name\": \"ratings-report\",\r\n    \"request\": {\r\n        \"distribution\": \"day\",\r\n        \"filters\": {\r\n            \"from\": \"2024-01-01T02:00:00+02:00\",\r\n            \"to\": \"2024-01-14T02:00:00+02:00\",\r\n            \"groups\": {\r\n                \"values\": [\r\n                    1,\r\n                    2,\r\n                    3\r\n                ]\r\n            }\r\n        }\r\n    },\r\n    \"total\": 10399,\r\n    \"records\": {\r\n        \"2024-01-01\": {\r\n            \"bad\": 19,\r\n            \"chats\": 760,\r\n            \"good\": 78\r\n        },\r\n        \"2024-01-02\": {\r\n            \"bad\": 19,\r\n            \"chats\": 819,\r\n            \"good\": 78\r\n        },\r\n        \"2024-01-03\": {\r\n            \"bad\": 28,\r\n            \"chats\": 815,\r\n            \"good\": 68\r\n        },\r\n        \"2024-01-04\": {\r\n            \"bad\": 25,\r\n            \"chats\": 806,\r\n            \"good\": 88\r\n        },\r\n        \"2024-01-05\": {\r\n            \"bad\": 16,\r\n            \"chats\": 721,\r\n            \"good\": 81\r\n        },\r\n        \"2024-01-06\": {\r\n            \"bad\": 12,\r\n            \"chats\": 735,\r\n            \"good\": 72\r\n        },\r\n        \"2024-01-07\": {\r\n            \"bad\": 16,\r\n            \"chats\": 742,\r\n            \"good\": 81\r\n        },\r\n        \"2024-01-08\": {\r\n            \"bad\": 21,\r\n            \"chats\": 839,\r\n            \"good\": 97\r\n        },\r\n        \"2024-01-09\": {\r\n            \"bad\": 26,\r\n            \"chats\": 766,\r\n            \"good\": 54\r\n        },\r\n        \"2024-01-10\": {\r\n            \"bad\": 26,\r\n            \"chats\": 752,\r\n            \"good\": 56\r\n        },\r\n        \"2024-01-11\": {\r\n            \"bad\": 24,\r\n            \"chats\": 807,\r\n            \"good\": 73\r\n        },\r\n        \"2024-01-12\": {\r\n            \"bad\": 26,\r\n            \"chats\": 866,\r\n            \"good\": 90\r\n        },\r\n        \"2024-01-13\": {\r\n            \"bad\": 21,\r\n            \"chats\": 895,\r\n            \"good\": 71\r\n        },\r\n        \"2024-01-14\": {\r\n            \"chats\": 76,\r\n            \"good\": 11\r\n        }\r\n    }\r\n}\r\n");
        }

        [HttpGet("responsetimedata")]
        public ActionResult<IEnumerable<ResponseTimeData>> GetResponseTime()
        {
            return Ok("{\r\n    \"name\": \"response-time-report\",\r\n    \"request\": {\r\n        \"distribution\": \"day\",\r\n        \"filters\": {\r\n            \"from\": \"2024-01-01T02:00:00+02:00\",\r\n            \"to\": \"2024-01-14T02:00:00+02:00\",\r\n            \"groups\": {\r\n                \"values\": [\r\n                    1,\r\n                    2,\r\n                    3\r\n                ]\r\n            }\r\n        }\r\n    },\r\n    \"total\": 7949,\r\n    \"records\": {\r\n        \"2024-01-01\": {\r\n            \"count\": 583,\r\n            \"response_time\": 51.06\r\n        },\r\n        \"2024-01-02\": {\r\n            \"count\": 637,\r\n            \"response_time\": 47.69\r\n        },\r\n        \"2024-01-03\": {\r\n            \"count\": 624,\r\n            \"response_time\": 47.55\r\n        },\r\n        \"2024-01-04\": {\r\n            \"count\": 626,\r\n            \"response_time\": 47.53\r\n        },\r\n        \"2024-01-05\": {\r\n            \"count\": 555,\r\n            \"response_time\": 48.09\r\n        },\r\n        \"2024-01-06\": {\r\n            \"count\": 558,\r\n            \"response_time\": 44.11\r\n        },\r\n        \"2024-01-07\": {\r\n            \"count\": 552,\r\n            \"response_time\": 44.55\r\n        },\r\n        \"2024-01-08\": {\r\n            \"count\": 677,\r\n            \"response_time\": 53.39\r\n        },\r\n        \"2024-01-09\": {\r\n            \"count\": 588,\r\n            \"response_time\": 53.29\r\n        },\r\n        \"2024-01-10\": {\r\n            \"count\": 582,\r\n            \"response_time\": 45.97\r\n        },\r\n        \"2024-01-11\": {\r\n            \"count\": 633,\r\n            \"response_time\": 48.63\r\n        },\r\n        \"2024-01-12\": {\r\n            \"count\": 618,\r\n            \"response_time\": 47.21\r\n        },\r\n        \"2024-01-13\": {\r\n            \"count\": 662,\r\n            \"response_time\": 56\r\n        },\r\n        \"2024-01-14\": {\r\n            \"count\": 54,\r\n            \"response_time\": 48.41\r\n        }\r\n    }\r\n}\r\n");
        }

        [HttpGet("tags")]
        public ActionResult<IEnumerable<TagsData>> GetTags()
        {
            return Ok("{\r\n    \"name\": \"tags-report\",\r\n    \"request\": {\r\n        \"distribution\": \"day\",\r\n        \"filters\": {\r\n            \"from\": \"2024-01-01T02:00:00+02:00\",\r\n            \"to\": \"2024-01-14T02:00:00+02:00\",\r\n            \"groups\": {\r\n                \"values\": [\r\n                    1,\r\n                    2,\r\n                    3\r\n                ]\r\n            }\r\n        }\r\n    },\r\n    \"total\": 10399,\r\n    \"records\": {\r\n        \"2024-01-01\": {\r\n            \"Adam\": 13,\r\n            \"Alex\": 26,\r\n            \"Chernozub.l\": 15,\r\n            \"Close - in progress\": 18\r\n        },\r\n        \"2024-01-02\": {\r\n            \"Adam\": 5\r\n        },\r\n        \"2024-01-03\": {\r\n            \"Steven\": 18,\r\n            \"Suhak I.\": 8,\r\n            \"Support\": 364,\r\n            \"TEST\": 1,\r\n            \"Tesliuk P.\": 41,\r\n            \"Tovkach S.\": 8,\r\n            \"Tsos I.\": 39,\r\n            \"Tymchuk O.\": 32\r\n        },\r\n        \"2024-01-04\": {\r\n            \"Julian\": 23,\r\n            \"Kopusyak V.\": 41,\r\n            \"Kostiuchyk I.\": 5,\r\n            \"Lily\": 12,\r\n            \"Limit\": 3,\r\n            \"Lishchuk O.\": 40,\r\n            \"Lukomska D.\": 18,\r\n            \"Mironov V.\": 7\r\n        },\r\n        \"2024-01-05\": {\r\n            \"Max\": 1,\r\n            \"Mia\": 1\r\n        },\r\n        \"2024-01-06\": {\r\n            \"Kopusyak V.\": 19,\r\n            \"Kostiuchyk I.\": 15,\r\n            \"Liam\": 1\r\n        },\r\n        \"2024-01-07\": {\r\n            \"Amelia\": 35,\r\n            \"Andrew\": 1,\r\n            \"VIP\": 198,\r\n            \"Vasylieva D.\": 20,\r\n            \"Veretelnyk M.\": 6,\r\n            \"Verification\": 17\r\n        },\r\n        \"2024-01-08\": {\r\n            \"Withdrawal - general info\": 65,\r\n            \"Withdrawal issue\": 21,\r\n            \"Yaremenko.Yu\": 8,\r\n            \"Yevchuk L.\": 17,\r\n            \"Zhyzhko V.\": 13\r\n        },\r\n        \"2024-01-09\": {\r\n            \"Support\": 364,\r\n            \"Tesliuk P.\": 3,\r\n            \"Tomakh D.\": 9,\r\n            \"Tsos I.\": 24,\r\n            \"Tymchuk O.\": 7,\r\n            \"VIP\": 116\r\n        },\r\n        \"2024-01-10\": {\r\n            \"Alex\": 34,\r\n            \"Amy\": 5,\r\n            \"Babii B.\": 11,\r\n            \"Badalian M.\": 37,\r\n            \"Bidnenko I.\": 34\r\n        },\r\n        \"2024-01-11\": {\r\n            \"Amy\": 1,\r\n            \"Badalian M.\": 37,\r\n            \"Bidnenko I.\": 27,\r\n            \"Bondar.B\": 1,\r\n            \"Bonus - general info\": 28\r\n        },\r\n        \"2024-01-12\": {\r\n            \"Alex\": 7,\r\n            \"Amy\": 7,\r\n            \"Babii B.\": 10,\r\n            \"Badalian M.\": 55\r\n        },\r\n        \"2024-01-13\": {\r\n            \"Mia\": 3,\r\n            \"Mironov V.\": 13,\r\n            \"Morrrigan\": 1,\r\n            \"NewVip\": 1,\r\n            \"Nikitina.O\": 8,\r\n            \"Reopen\": 10,\r\n            \"Review Left\": 1,\r\n            \"Review Requested\": 1,\r\n            \"Rudkovskyi.O\": 2\r\n        },\r\n        \"2024-01-14\": {\r\n            \"Bonus - general info\": 4,\r\n            \"Casino Bonus\": 25,\r\n            \"Close - in progress\": 3,\r\n            \"Closed - PG/01\": 1,\r\n            \"Closed - Personal Reason/03\": 1,\r\n            \"Closure\": 1\r\n        }\r\n    }\r\n}\r\n");  }
    }
}
