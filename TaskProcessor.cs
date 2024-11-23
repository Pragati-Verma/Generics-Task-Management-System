using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    // TTask is either EmailTask or ReportTask
    // TResult is data type (string)
    public class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        public TTask Task { get; set; }
        public TaskProcessor(TTask task)
        {
            Task = task;
        }
        public TResult Execute()
        {
            // Perform method is called based on TTask object (either EmailTask or ReportTask object is passed)
            return Task.Perform();
        }
    }
}
