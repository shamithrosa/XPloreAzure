using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using XPloreAzure.Common;

namespace XPloreAzure.Functions
{
    public class ItemQueueTrigger
    {
        [FunctionName("ItemQueueTrigger")]
        public void Run(
            [QueueTrigger(XPloreConstants.ItemEventQueueName, Connection = XPloreConstants.ConStringName)] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            Console.ReadKey();
        }
    }
}
