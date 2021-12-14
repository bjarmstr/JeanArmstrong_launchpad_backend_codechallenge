using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.SQSProcessor
{
    public class AwsSQSProcessor
    {

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



        }    
    }
}

