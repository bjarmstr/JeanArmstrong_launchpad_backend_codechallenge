using LaunchpadCodeChallenge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.SQSProcessor.Interfaces
{
   /// <summary>
   /// Interface for Reading SQS using Http
   /// </summary>
    public interface ISQSHttpProcessor
    {
        /// <summary>
        /// Read SQS data
        /// </summary>
        /// <returns></returns>
        Task<List<SQSVM>> SQSreadQueue();
    }
}
