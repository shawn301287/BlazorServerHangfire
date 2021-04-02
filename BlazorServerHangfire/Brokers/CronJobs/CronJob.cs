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
        
        public string CreateDelayedJob()
        {
            throw new NotImplementedException();
        }


        public string CreateScheduledJob()
        {
            throw new NotImplementedException();
        }

        public string CreateSequentialJob()
        {
            throw new NotImplementedException();
        }
    }
}
