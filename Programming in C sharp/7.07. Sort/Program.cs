namespace _7._07._Sort
{
    class CalendarEvent
    {
        public string Title { get; set; }

        public DateTimeOffset StartTime { get; set; }
        public TimeSpan Duration { get; set; }
    }

    /*
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
    */
    class Program
    {
        static void Main(string[] args)
        {
            CalendarEvent[] events =
            {
                new CalendarEvent
                {
                    Title = "Swing Dancing at the South Bank",
                    StartTime = new DateTimeOffset (2009, 7, 11, 15, 00, 00, TimeSpan.Zero),
                    Duration = TimeSpan.FromHours(4)
                },
                new CalendarEvent
                {
                    Title = "Saturday Night Swing",
                    StartTime = new DateTimeOffset (2009, 7, 11, 19, 30, 00, TimeSpan.Zero),
                    Duration = TimeSpan.FromHours(6.5)
                },
                new CalendarEvent
                {
                    Title = "Formula 1 German Grand Prix",
                    StartTime = new DateTimeOffset (2009, 7, 12, 12, 10, 00, TimeSpan.Zero),
                    Duration = TimeSpan.FromHours(3)
                },
                new CalendarEvent
                {
                    Title = "Swing Dance Picnic",
                    StartTime = new DateTimeOffset (2009, 7, 12, 15, 00, 00, TimeSpan.Zero),
                    Duration = TimeSpan.FromHours(4)
                },
                new CalendarEvent
                {
                    Title = "Stompin' at the 100 Club",
                    StartTime = new DateTimeOffset (2009, 7, 13, 19, 45, 00, TimeSpan.Zero),
                    Duration = TimeSpan.FromHours(5)
                }
            };


            Array.Sort(events, (event1, event2) => event1.StartTime.CompareTo(event2.StartTime));

            Array.Sort(events, (event1, event2) => event1.Duration.CompareTo(event2.Duration));

            int[] numbers = { 4, 1, 2, 5, 3 };



            Array.Sort(numbers);

            Array.Sort(events); // Blam!

            foreach (CalendarEvent item in events)
            {
                Console.WriteLine(item.Title + ": " + item.StartTime);
            }
        }
    }
}