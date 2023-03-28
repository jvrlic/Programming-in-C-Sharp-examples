namespace _7._05._CalendarEvents
{
    class CalendarEvent
    {
        public string Title { get; set; }

        public DateTimeOffset StartTime { get; set; }
        public TimeSpan Duration { get; set; }
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

        }
    }
}