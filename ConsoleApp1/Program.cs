// See https://aka.ms/new-console-template for more information
using PasswordGenerator;

Console.WriteLine("Hello, World!");

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine(password.ToString());