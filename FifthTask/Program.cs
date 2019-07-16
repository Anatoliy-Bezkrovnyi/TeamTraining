using FifthTask.Enums;
using System;
using System.Collections.Generic;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
           

           // Task task = new Task();
            List<Task> taskList = new List<Task>();
            Input.AddNewTask(ref taskList);


            //Input.GetEnumValueAttribute<ComplexityEnum>(ComplexityEnum.Hard)

            //taskList.Add(task);
            //Console.WriteLine(task.TaskID.ToString());
            //Console.WriteLine(task.TaskName.ToString());
            //Console.WriteLine(task.TaskDescription.ToString());
            //Console.WriteLine(task.PriorityEnum.ToString());
            //Console.WriteLine(task.ComplexityEnum.ToString());
            //Console.WriteLine(task.Time.ToString());
        }
    }
}
