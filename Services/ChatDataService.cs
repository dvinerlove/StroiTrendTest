using StroiTrendTest.Models;

namespace StroiTrendTest.Services
{
    public class ChatDataService
    {
        private readonly HttpClient _httpClient;

        public ChatDataService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<TotalChatsReport<ChatData>> GetTotalChatsAsync()
        {
            return await _httpClient.GetFromJsonAsync<TotalChatsReport<ChatData>>("api/fakedata/totalchats");
        }

        public async Task<int> GetTotal(DateTime date)
        {
            var report = await _httpClient.GetFromJsonAsync<TotalChatsReport<ChatData>>("api/fakedata/totalchats");
            return report?.Records.GetValueOrDefault(date)?.Total ?? 0;
        }

        public async Task<T> GetReportData<T>(DateTime date) where T : class, new()
        {
            var endpoint = $"api/fakedata/{typeof(T).Name.ToLower()}";
            var report = await _httpClient.GetFromJsonAsync<TotalChatsReport<T>>(endpoint);
            return report?.Records.GetValueOrDefault(date) ?? new T();
        }

        public async Task<Dictionary<string, int>> GetTags(DateTime date)
        {
            var report = await _httpClient.GetFromJsonAsync<TotalChatsReport<Dictionary<string, int>>>("api/fakedata/tags");
            return report?.Records.GetValueOrDefault(date) ?? new Dictionary<string, int>();
        }
    }
}
