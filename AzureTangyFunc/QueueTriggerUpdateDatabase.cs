using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureTangyFunc
{
    public class QueueTriggerUpdateDatabase
    {
        [FunctionName("QueueTriggerUpdateDatabase")]
        public void Run([QueueTrigger("SalesRequestInbound", Connection = "AzureWebJobStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
