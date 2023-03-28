namespace _7._09._GetEventsByDay
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
        static CalendarEvent[][] GetEventsByDay(CalendarEvent[] allEvents, DateTime firstDay, int numberOfDays)
        {
            var eventsByDay = new CalendarEvent[numberOfDays][];
            for (var day = 0; day < numberOfDays; ++day)
            {
                var dateOfInterest = (firstDay + TimeSpan.FromDays(day)).Date;
                var itemsOnDateOfInterest = Array.FindAll(allEvents, e => e.StartTime.Date == dateOfInterest);
                eventsByDay[day] = itemsOnDateOfInterest;
            }
            return eventsByDay;
        }

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


            var eventsByDay = GetEventsByDay(events, new DateTime(2009, 7, 11, 15, 00, 00), 10);

            foreach (CalendarEvent[] cs in eventsByDay)
            {
                Console.WriteLine("*********************************************************************************");
                foreach (CalendarEvent c in cs)
                    Console.WriteLine(c.Title + ": " + c.StartTime);
            }
        }
    }
}