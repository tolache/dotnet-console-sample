// See https://aka.ms/new-console-template for more information
using dotnet_console_sample;

Console.WriteLine("Hello, World!");
Customer customer = new();
if (Environment.GetEnvironmentVariable("BOGUS_VAR") != null)
{
    Console.WriteLine(customer.Name.Length);
}