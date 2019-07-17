using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    public class Output
    {
        public static void PrintTaskDetails(Task task)
        {
            Console.WriteLine($"Task ID: {task.TaskID.ToString()}");
            Console.WriteLine($"Task name: {task.TaskName.ToString()}");
            Console.WriteLine($"Task description: {task.TaskDescription.ToString()}");
            Console.WriteLine($"Task priority: {task.PriorityEnum.ToString()}");
            Console.WriteLine($"Task complexity: {task.ComplexityEnum.ToString()}");
            Console.WriteLine($"{task.Time.ToString()} hours to solve");
            Console.WriteLine();
        }
    }
}
