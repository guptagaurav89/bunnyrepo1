using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunny.JobScheduler.Interfaces;

namespace Bunny.JobScheduler
{
    public class JobScheduler : IJobScheduler
    {
        private bool isStarted;
        private bool isDisposed;

        public void Start()
        {
            if (isStarted)
            {
                throw new InvalidOperationException("The Job Scheduler is already running.");
            }
        }

        public void Stop()
        {
            
        }

        public string AddAsynchronousJob()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if(!isDisposed)
            {
                this.Stop();
                this.isDisposed = true;
            }
        }
    }
}
