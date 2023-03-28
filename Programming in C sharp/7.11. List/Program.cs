namespace _7._11._List
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
        public override string ToString()
        {
            return Title;
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
            var newEvent1 = new CalendarEvent
            {
                Title = "Dean",
                StartTime = new DateTimeOffset(2009, 7, 14, 19, 15, 00, TimeSpan.Zero),
                Duration = TimeSpan.FromHours(1)
            };

            events.Add(newEvent);

            events.Insert(0, newEvent1);

            foreach (CalendarEvent c in events)
                Console.WriteLine(c);

            Console.WriteLine(events[0]);

            Console.WriteLine(events);
        }
    }
}