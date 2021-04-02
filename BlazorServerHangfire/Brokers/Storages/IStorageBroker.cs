using BlazorServerHangfire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Brokers.Storages
{
    public interface IStorageBroker
    {
        void InsertValue();

        IQueryable<Logs> SelectAllLogs();
    }
}
