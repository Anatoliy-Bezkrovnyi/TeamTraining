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

            foreach (Task task in taskList)
            {
                Output.PrintTaskDetails(task);
            }


            
        }
    }
}
