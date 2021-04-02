using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Brokers.CronJobs
{
    public interface ICronJob
    {
        string CreateOneTimeJob();

        string CreateDelayedJob(int delaySeconds);

        string CreateScheduledJob(DateTime recurringTime);

        void CreateRecurringJob(string cronExpression);

        string CreateSequentialJob(string parentJobId);
    }
}
