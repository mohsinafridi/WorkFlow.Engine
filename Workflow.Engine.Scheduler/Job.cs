using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Job : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            //Sample code that denotes the job to be performed
            using (StreamWriter streamWriter = new StreamWriter(@"D:\IDGLog.txt", true))
            {
                streamWriter.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
