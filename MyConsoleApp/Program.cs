// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// display the current time
Console.WriteLine($"The current time is {DateTime.Now}");
// calculate and display the days until Christmas
int daysUntilChristmas = (new DateTime(DateTime.Now.Year, 12, 25) - DateTime.Now).Days;
Console.WriteLine($"There are {daysUntilChristmas} days until the next Christmas");