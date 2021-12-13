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
            myvar = 6;
            TestModule(ref myvar);

            //case c. integer < 1
            myvar = -4;
            TestModule(ref myvar);

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
            Console.WriteLine($"{thisDate1} of type {valueTypeDT}");
            TestModule(ref thisDate1);
            bool b = true;
            TestModule(ref b);


        }

        static void TestModule<T>(ref T value)
        {
            var valueType = value.GetType();
            Console.WriteLine($"{value} of type {valueType}");
            

            switch (value)
            {
                case int i  :
                    if (i >= 1 && i <= 4)
                    {
                        var quotient = i * 2;
                        //return i
                        Console.WriteLine($"multiplied by 2 {quotient}");
                        break;
                    }
                    if (i > 4)
                    {
                        var quotient = i * 3;
                        
                        //return i
                        Console.WriteLine($"multiplied by 3 {quotient}");
                    }
                    if (i < 1)
                    {

                        throw new ArgumentException(
                            String.Format("{0} is an incorrect input, integer must be >= 1");
                    }
                    
                    break;

                case float t:
                    Console.WriteLine($"{t} of type {valueType}");
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

