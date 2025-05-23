﻿// See https://aka.ms/new-console-template for more information

using System.Collections;
using dotnet_console_sample;
using Newtonsoft.Json;

IDictionary environmentVariables = Environment.GetEnvironmentVariables();

string filePath = "environment_variables.txt";

using (StreamWriter writer = new StreamWriter(filePath))
{
    foreach (DictionaryEntry entry in environmentVariables)
    {
        Console.WriteLine($"{entry.Key} = {entry.Value}");
        writer.WriteLine($"{entry.Key} = {entry.Value}");
    }
}

Console.WriteLine("Hello, World!7");
Customer customer = new();
if (Environment.GetEnvironmentVariable("BOGUS_VAR") != null)
{
    Console.WriteLine(customer.Name?.Length);
}

customer = new Customer
{
    Id = Guid.NewGuid(),
    Amount = 100M,
    Value = 1000,
    Name = "Acme Corp.",
    
};

string output = JsonConvert.SerializeObject(customer);
Console.WriteLine($"Serialized customer {output}");
Customer deserializedCustomer = JsonConvert.DeserializeObject<Customer>(output) ?? throw new InvalidOperationException();
Console.WriteLine($"Deserialized customer name: {deserializedCustomer.Name}");
