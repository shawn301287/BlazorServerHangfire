using BlazorServerHangfire.Brokers.Storages;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Brokers.CronJobs
{
    public class CronJob : ICronJob
    {
        private readonly IStorageBroker storageBroker;

        public CronJob(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }


        public string CreateOneTimeJob()
        {
            return BackgroundJob.Enqueue(() => storageBroker.InsertValue());
        }
        
        public string CreateDelayedJob(int delayedSeconds)
        {
            return BackgroundJob.Schedule(() => storageBroker.InsertValue(), TimeSpan.FromSeconds(delayedSeconds));
        }


        public string CreateScheduledJob(DateTime recurringAfter)
        {
            return BackgroundJob.Schedule(() => storageBroker.InsertValue(), recurringAfter);
        }

        public void CreateRecurringJob(string cronExpression)
        {
            RecurringJob.AddOrUpdate(() => storageBroker.InsertValue(), cronExpression);
        }

        public string CreateSequentialJob(string parentJobId)
        {
            return BackgroundJob.ContinueJobWith(parentJobId, () => storageBroker.InsertValue());
        }
    }
}
