namespace GenericDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmailTask emailTask = new EmailTask();
            emailTask.Recipient = "Pragati Verma";
            emailTask.Message = "Hello! Testing!!";
            //Console.WriteLine("EmailTask's Perform method: ");
            //Console.WriteLine(emailTask.Perform()); 
            

            ReportTask reportTask = new ReportTask();
            reportTask.ReportName = "Generics Concepts";
            //Console.WriteLine("Report task's Perform method:");
            //Console.WriteLine(reportTask.Perform());


            TaskProcessor<EmailTask,string> taskProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            Console.WriteLine("EmailTask's Perform method: ");
            taskProcessor.Execute();

            TaskProcessor<ReportTask,string> taskProcessor1 = new TaskProcessor<ReportTask, string>(reportTask);
            Console.WriteLine("\nReport task's Perform method:");
            taskProcessor1.Execute();

            Console.ReadKey();
        }
    }
}
