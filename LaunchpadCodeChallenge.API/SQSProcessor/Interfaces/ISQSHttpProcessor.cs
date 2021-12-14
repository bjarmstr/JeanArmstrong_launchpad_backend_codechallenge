using LaunchpadCodeChallenge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.SQSProcessor.Interfaces
{
    public interface ISQSHttpProcessor
    {
        Task<List<SQSVM>> SQSreadQueue();
    }
}
