using System;
using System.Collections.Generic;


namespace LaunchpadCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 7
            Console.WriteLine("Question7");
            List<string>.Enumerator iterateNames = QuestionClass.CreateNamesListEnumerator();
            while (iterateNames.MoveNext())
            {
                string str = iterateNames.Current;
                Console.WriteLine(str);
            }

            Console.WriteLine();
            //question 8
            Console.WriteLine("Question8");

            //case a.  integer 1,2,3,4
            int intVar = 3;
            Console.WriteLine($"{TestModule(ref intVar)}, {intVar}*2");

            //case b.  integer >4
            intVar = 6;
            TestModule(ref intVar);
            Console.WriteLine($"{TestModule(ref intVar)}, {intVar}*3");

            //case c. integer < 1
            intVar = -4;
            //TestModule(ref intVar);

            //case d.  float 1f and 2f
            float floatVar = 1.0f;
            var floatResult = TestModule(ref floatVar);
            Console.WriteLine($"{floatResult}");
            var valueType = floatResult.GetType();
            Console.WriteLine($"{floatResult} of type {valueType}");


            //case e.  string
            string stringVar = "e. to upper";
            Console.WriteLine($"{TestModule(ref stringVar)}");

            //case f.  default
            DateTime dateVar = new DateTime(2011, 6, 10);
            Console.WriteLine($"{TestModule(ref dateVar)}");

            bool boolVar = true;
            Console.WriteLine($"{TestModule(ref boolVar)}");


        }

        static T TestModule<T>(ref T value)
        {
            //var valueType = value.GetType();
            //Console.WriteLine($"{value} of type {valueType}");
            

            switch (value)
            {
                case < 1:
                    throw new ArgumentException(
                            "Incorrect input, integer must be >= 1","value");
                  
                case int i:

                    var quotient = 0;

                    if (i <= 4) quotient = i * 2;
                    else quotient = i * 3;

                    return (T)Convert.ChangeType(quotient, typeof(T));        


                case 1.0f:
                case 2.0f:
                    return (T)Convert.ChangeType(3.0f, typeof(T));


                case string str:
                    return (T)Convert.ChangeType(str.ToUpper(), typeof(T));


                default:
                    return (T)Convert.ChangeType(value, typeof(T));
            }

            Console.WriteLine();

        }


    }
}

