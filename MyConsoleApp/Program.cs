// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");
int daysUntilChristmas = (new DateTime(DateTime.Now.Year, 12, 25) - DateTime.Now).Days;
Console.WriteLine($"There are {daysUntilChristmas} days until the next Christmas");