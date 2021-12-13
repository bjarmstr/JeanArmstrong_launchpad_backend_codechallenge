using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {


        static List<string> NamesList = new List<string>()
            {
                "Jimmy",
                "Jeffrey",
                "John",
            };

        public static List<string>.Enumerator CreateNamesListEnumerator()
        {

            //GetEnumerator Returns an Enumerator that Iterates through the List
            List<string>.Enumerator enumeratorNamesList = NamesList.GetEnumerator();

            return enumeratorNamesList;

        }

    }
}
