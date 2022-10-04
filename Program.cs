using System;

namespace dotnet_console_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Source source = new Source();
            Console.WriteLine(source);
        }
    }

    public sealed class Source {
        public decimal Amount { get; set; }
        public Guid Id { get; set; }
        public int Value { get; set; }
        public string? Name { get; set; }
    }
}
