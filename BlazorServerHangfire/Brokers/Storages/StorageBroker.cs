using BlazorServerHangfire.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Brokers.Storages
{
    public class StorageBroker : IStorageBroker
    {
        private readonly ApplicationDbContext DbContext;

        public StorageBroker(ApplicationDbContext applicationDbContext)
        {
            this.DbContext = applicationDbContext;
        }

        public void InsertValue()
        {
            DbContext.Logs.Add(new Models.Logs()
            {
                Id = Guid.NewGuid(),
                TimeStamp = DateTimeOffset.Now
            });

            DbContext.SaveChanges();
        }
    }
}
