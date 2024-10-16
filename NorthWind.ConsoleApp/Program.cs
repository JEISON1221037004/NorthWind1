﻿using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter writer = default;
IUserActionWriter Writer = new ConsoleWriter();

Applogger Logger = new Applogger(writer);
Applogger Logger = new Applogger(Writer);
Logger.WriteLog("Application Started.");


ProductService service = new ProductService(Writer);
service.Add("Demo", "Azucar refinada");