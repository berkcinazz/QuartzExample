using Quartz;

namespace QuartzExample.JobsHelper
{
    public class SendMessageJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Send Message");

            return Task.FromResult(true);
        }
    }
}
