using LaunchpadCodeChallenge.API.SQSProcessor.Interfaces;
using LaunchpadCodeChallenge.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.Controllers
{
    /// <summary>
    /// Controller to Access AWS External API 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DynamoController : ControllerBase
    {

        private readonly ISQSHttpProcessor _sqsHttpProcessor;

        /// <summary>
        /// Access SQS
        /// </summary>
        /// <param name="sqsHttpProcessor"></param>
        public DynamoController(ISQSHttpProcessor sqsHttpProcessor)
        {
            _sqsHttpProcessor = sqsHttpProcessor;
        }

        /// <summary>
        /// Get SQS Records
        /// DynamoDb Streams updates to SQS through a Lambda function
        /// </summary>
        [HttpGet]

        public async Task<ActionResult<List<SQSVM>>> SQSreadQueue()
        {
            var sqsResults = await _sqsHttpProcessor.SQSreadQueue();

            return Ok(sqsResults);

        }

    }
}
