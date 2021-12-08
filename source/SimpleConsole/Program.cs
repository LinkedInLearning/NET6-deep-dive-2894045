// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Details at https://devblogs.microsoft.com/dotnet/date-time-and-time-zone-enhancements-in-net-6/
// DateOnly

var d1 = new DateOnly();

var d2 = DateOnly.FromDateTime(DateTime.Now);

d2 = d2.AddDays(10);

var d3 = new DateOnly( year:2025,month:11,day:20);

// TimeOnly
var t1 = new TimeOnly();

var t2 = TimeOnly.FromDateTime(DateTime.Now);

var t3 = new TimeOnly(hour: 11,minute: 17, second:45);
	