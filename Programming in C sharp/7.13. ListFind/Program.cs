namespace _7._13._ListFind
{
    class CalendarEvent : IComparable<CalendarEvent>
    {
        public string Title { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int CompareTo(CalendarEvent other)
        {
            if (other == null) { return 1; }
            return StartTime.CompareTo(other.StartTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var events = new List<CalendarEvent>();

            var newEvent = new CalendarEvent
            {
                Title = "Dean Collins Shim Sham Lesson",
                StartTime = new DateTimeOffset(2009, 7, 14, 19, 15, 00, TimeSpan.Zero),
                Duration = TimeSpan.FromHours(1)
            };

            events.Add(newEvent);

            var dateOfInterest = new DateTime(2009, 7, 14);
            var itemsOnDateOfInterest = events.FindAll(e => e.StartTime.Date == dateOfInterest);

            foreach (CalendarEvent c in itemsOnDateOfInterest)
                Console.WriteLine(c.Title);
        }
    }
}