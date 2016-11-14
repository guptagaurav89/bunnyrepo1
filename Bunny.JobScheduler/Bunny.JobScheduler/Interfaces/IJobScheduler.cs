using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny.JobScheduler.Interfaces
{
    interface IJobScheduler : IDisposable
    {
        void Start();
        void Stop();
        string AddAsynchronousJob();

    }
}
