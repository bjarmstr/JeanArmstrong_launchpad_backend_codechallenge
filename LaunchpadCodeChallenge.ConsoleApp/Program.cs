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
            int myvar = 3;
            TestModule(ref myvar);

            //case b.  integer >4
            myvar = 6;
            TestModule(ref myvar);

            //case c. integer < 1
            myvar = -4;
            //TestModule(ref myvar);

            //case d.  float 1f and 2f
            float myfloat = 1.0f;
            TestModule(ref myfloat);

            //case e.  string
            string mysstring = "e. to upper";
            TestModule(ref mysstring);

            //case f.  default
            DateTime thisDate1 = new DateTime(2011, 6, 10);
            TestModule(ref thisDate1);
            bool b = true;
            TestModule(ref b);


        }

        static void TestModule<T>(ref T value)
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
                     //return quotient
                     Console.WriteLine($"multiplied {quotient}");
                    break;


                case 1.0f:
                case 2.0f:
                    Console.WriteLine($"return 3.0f");
                    break;


                case string str:
                    Console.WriteLine($"{str.ToUpper()}");
                    break;

                      
                default:
                    Console.WriteLine($"default");
                    break;
            }

            Console.WriteLine();

        }


    }
}

