using System;

namespace SampleApp
{
    class Program
    {
        public string PromptForString()
        {
            Console.WriteLine("what is your name?: ");
            return Console.ReadLine();
        }
        public void Run()
        {
            PromptForString();
            Console.WriteLine("Welcome to c#");
        }






















        //hiding the static
        static void Main(string[] args)
        {
            //make a new program and call my programs run
            var app = new Program();
            app.Run();
        }
    }
}
