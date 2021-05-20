using System;

namespace Demo_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpreter interpreter = new Interpreter();
            interpreter.languge = interpreter.English;
            interpreter.SayHi();
        }
    }
}
