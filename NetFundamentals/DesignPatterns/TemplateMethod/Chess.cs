using System;

namespace NetFundamentals.DesignPatterns.TemplateMethod
{
    public class Chess : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Initializing Chess...");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Starting Chess...");
        }

        protected override void EndPlay()
        {
            Console.WriteLine("Ending Chess...");
        }
    }
}
