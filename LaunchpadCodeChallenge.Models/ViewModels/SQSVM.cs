using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    public class SQSVM
    {
        
        public string EventID { get; set; }
        /// <summary>
        /// primary key in DynamoDb
        /// </summary>
        public int Logevent_id { get; set; }

        public string LogMessage { get; set; }


        
  

    }
}
