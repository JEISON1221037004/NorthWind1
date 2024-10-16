using NorthWind.ConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new FileWriter();
var Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<Applogger>();
Builder.Services.AddSingleton<ProductService>();
using var AppHost = Builder.Build();
IUserActionWriter Writer = new ConsoleWriter();

Applogger Logger = new Applogger(Writer);
Logger.WriteLog("Application Started.");


 *Applogger : Inversio de dependencias, los modulos 
 * de alto nivel son independientes de los detalles de implementacion
 * 
 * */
 * */"Demo", "Azucar refinada");