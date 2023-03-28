namespace _7._08._RemoveFirst
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
            var events1 = RemoveFirstEvent(events);

            foreach (CalendarEvent item in events1)
            {
                Console.WriteLine(item.Title + ": " + item.StartTime);
            }

        }

        static CalendarEvent[] CombineEvents(CalendarEvent[] events1, CalendarEvent[] events2)
        {
            var combinedEvents = new CalendarEvent[events1.Length + events2.Length];
            events1.CopyTo(combinedEvents, 0);
            events2.CopyTo(combinedEvents, events1.Length);
            return combinedEvents;
        }

        static CalendarEvent[] RemoveFirstEvent(CalendarEvent[] events)
        {
            var croppedEvents = new CalendarEvent[events.Length - 1];
            Array.Copy(
            events, // Array from which to copy
            1, // Starting point in source array
            croppedEvents, // Array into which to copy
            0, // Starting point in destination array
            events.Length - 1 // Number of elements to copy
            );
            return croppedEvents;
        }
    }
}