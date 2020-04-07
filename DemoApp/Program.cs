using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Log(new DemoClass{ Id = 0}));
            Console.ReadLine();
        }

        static string Log(DemoClass demoClass) => demoClass switch
        {
            { Id: 1 } => "1",
            _ => "No match"
        };
    }

    public class DemoClass
    {
        public long Id { get; set; }
    }

    public struct DemoStruct
    {
        public long Id { get; set; }
        public long NextId => Id + 1;
        public override readonly string ToString() => NextId.ToString();
    }
}
