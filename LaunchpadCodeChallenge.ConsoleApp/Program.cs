using System;
using System.Collections.Generic;


namespace LaunchpadCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("test");
            List<string>.Enumerator iterateNames = QuestionClass.CreateNamesListEnumerator();
            while (iterateNames.MoveNext())
            {
                string str = iterateNames.Current;
                Console.WriteLine(str);
            }

        }


    }
}

