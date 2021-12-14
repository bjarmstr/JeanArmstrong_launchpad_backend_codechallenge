using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.SQSProcessor
{

    /// <summary>
    /// Use Awssdk.sqs to access SQS
    /// </summary>
    public class AwsSQSProcessor
    {
        /// <summary>
        /// Read and Delete Records from SQS
        /// SQS contains DynamoDb updates
        /// </summary>
        /// <returns></returns>
        public string readQueue()
        {
            //uses credentials in .aws folder on local computer
            
            var sqs = new AmazonSQSClient(RegionEndpoint.CACentral1);

            var queueUrl = sqs.GetQueueUrlAsync("DynamoQueue").Result.QueueUrl;

            var receiveMessageRequest = new ReceiveMessageRequest
            {
                QueueUrl = queueUrl
            };

            var receiveMessageResponse = sqs.ReceiveMessageAsync(receiveMessageRequest).Result;

            // TODO - Finish with Delete capabilites

            return ("not finished");

        }    
    }
}

