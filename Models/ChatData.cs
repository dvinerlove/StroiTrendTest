namespace StroiTrendTest.Models
{
    public class DateDetails
    {
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public DurationData Duration { get; set; }
        public RatingsData Ratings { get; set; }
        public ResponseTimeData ResponseTime { get; set; }
        public Dictionary<string, int> Tags { get; set; }
    }
    public class TotalChatsReport<T>
    {
        public string Name { get; set; }
        public RequestData Request { get; set; }
        public int Total { get; set; }
        public Dictionary<DateTime, T> Records { get; set; }
    }

    public class RequestData
    {
        public string Distribution { get; set; }
        public FiltersData Filters { get; set; }
    }

    public class FiltersData
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public GroupsData Groups { get; set; }
    }

    public class GroupsData
    {
        public List<int> Values { get; set; }
    }


    public class ChatData
    {
        public int Total { get; set; }
    }
}
