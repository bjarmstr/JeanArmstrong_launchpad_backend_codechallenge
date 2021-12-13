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

            //question 8
            Console.WriteLine("Question8");

            //case a.  integer 1,2,3,4
            int myvar = 3;
            TestModule(ref myvar);

            //case b.  integer >4

            //case c. integer < 1

            //case d.  float 1f and 2f
            float myfloat = 1.0f;
            TestModule(ref myfloat);

            //case e.  string
            string mysstring = "e. to upper";
            TestModule(ref mysstring);

            //case f.  default
            //Test fails this case
            DateTime thisDate1 = new DateTime(2011, 6, 10);
            var valueTypeDT = thisDate1.GetType();
            
            bool b = true;
           // TestModule(ref thisDate1);


        }

        static void TestModule<T>(ref T value)
        {
            var valueType = value.GetType();
            Console.WriteLine($"{value} of type {valueType}");
            

            switch (value)
            {
                case (int i ) :
                    Console.WriteLine($"integer {i}");
                    break;

                case float t:
                    Console.WriteLine($"{t} of type {valueType}");
                    break;

                case string str:
                    Console.WriteLine($"{str.ToUpper()}");
                    break;

                default:
                    Console.WriteLine($"{value} of type {valueType}");
                    break;
            }

            Console.WriteLine();

        }


    }
}

