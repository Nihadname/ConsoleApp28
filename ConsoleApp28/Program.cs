// See https://aka.ms/new-console-template for more information
using ConsoleApp38.Service.Helpers;
using ConsoleApp38.Service.Services;
using System.Security.Principal;

Console.WriteLine("Hello, World!");
Account account = new Account();
account.AccountRoleAndLoginChecker("demo@mode.eduz.az", "lorem12345", Roles.SuperAdmin);