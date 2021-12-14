using LaunchpadCodeChallenge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LaunchpadCodeChallenge.API.SQSProcessor.Interfaces;

namespace LaunchpadCodeChallenge.API.SQSProcessor
{
    /// <summary>
    /// Consume SQS API using HTTP request
    /// </summary>
    public class SQSHttpProcessor: ISQSHttpProcessor
    {

        /// <summary>
        /// Read Records from Queue
        /// </summary>
        /// <returns></returns>
        public async Task<List<SQSVM>> SQSreadQueue()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.BaseAddress = new Uri("https://lduqrd76g8.execute-api.ca-central-1.amazonaws.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("beta/sqs");

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var sqsResponse = Res.Content.ReadAsStringAsync().Result;
                    var sqsRecords = JsonConvert.DeserializeObject<List<SQSVM>>(sqsResponse);
                    //if a search term is given filter album titles
                     return sqsRecords;
                }
                else
                {
                    throw new Exception("API request unavailable, please try again later");
                }
            }


        }

    }
}
