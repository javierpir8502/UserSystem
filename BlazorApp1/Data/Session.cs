namespace BlazorApp1.Data
{
    public class Session
    {
        public Guid SessionId { get; set; }
        public string UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
