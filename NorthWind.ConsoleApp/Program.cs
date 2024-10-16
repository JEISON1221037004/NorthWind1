using NorthWind.ConsoleApp.Services;

Console.WriteLine("Hello, World!");
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
Applogger Logger = new Applogger((IUserActionWriter)default);
Logger.WriteLog("Application Started.");
