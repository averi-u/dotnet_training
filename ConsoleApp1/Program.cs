// See https://aka.ms/new-console-template for more information
using PasswordGenerator;
using System; 

Console.WriteLine("Hello, World!");

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine(password.ToString());


const float a = 3.14f;

decimal number = 1.2m;

//overflow 
checked
{
    byte number1 = 255; 
    number1 += 1;
}

int b = 1;
bool isWorking = true; 

Console.WriteLine(number); 