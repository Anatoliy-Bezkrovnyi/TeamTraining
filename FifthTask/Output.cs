using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    public class Output
    {
        public static void PrintTaskDetails(Task task)
        {
            Console.WriteLine(task.TaskID.ToString());
            Console.WriteLine(task.TaskName.ToString());
            Console.WriteLine(task.TaskDescription.ToString());
            Console.WriteLine(task.PriorityEnum.ToString());
            Console.WriteLine(task.ComplexityEnum.ToString());
            Console.WriteLine(task.Time.ToString());
        }
    }
}
