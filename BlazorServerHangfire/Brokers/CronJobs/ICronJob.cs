using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Brokers.CronJobs
{
    public interface ICronJob
    {
        string CreateOneTimeJob();

        string CreateDelayedJob();

        string CreateScheduledJob();

        string CreateSequentialJob();
    }
}
