using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.ViewModels
{

    /// <summary>
    /// Basic Reponse Fields from 
    /// </summary>
    public class SQSVM
    {
        /// <summary>
        /// SQS EventID
        /// </summary>
        public string EventID { get; set; }
        
        /// <summary>
        /// primary key in DynamoDb
        /// </summary>
        public int Logevent_id { get; set; }

        /// <summary>
        /// LogMessage Field from DynamoDB
        /// </summary>
        public string LogMessage { get; set; }


        
  

    }
}
