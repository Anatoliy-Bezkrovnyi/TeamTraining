using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FifthTask
{
    public class Request
    {
        public void AmountOfTimeNeededToSolveAllTasks(List<Task> taskList)
        {

            int timeSum = 0;
            foreach (Task task in taskList)
            {
                timeSum += task.Time;
            }

            //int t = taskList.Sum(x => x.Time);

            Console.WriteLine($"Total amount of time to solve all tasks is {timeSum} hours.");
        }

        public void ListofTasksAccordingToPriority(List<Task> taskList)
        {
            Console.WriteLine("Please enter tasks priority to find all corresponding tasks, use 'High', 'Medium', 'Low'.");
            String enteredPriority = Console.ReadLine();

            int attempts = 3;



            switch (enteredPriority)
            {
                case "High":
                    List<Task> hightasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.High)
                    .OrderByDescending(x => x.ComplexityEnum)
                    //.ThenBy(x => x.TaskName)
                    .ToList();
                    Console.WriteLine("High priority tasks are:");
                    foreach (Task task in hightasks)
                    {
                        Output.PrintTaskDetails(task);
                    }
                    break;

                case "Medium":
                    List<Task> middletasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.Middle)
                        .OrderByDescending(x => x.ComplexityEnum)
                        //.ThenBy(x => x.TaskName)
                        .ToList();
                    Console.WriteLine("Middle priority tasks are:");
                    foreach (Task task in middletasks)
                    {
                        Output.PrintTaskDetails(task);
                    }
                    break;

                case "Low":
                    List<Task> lowtasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.Low)
                        .OrderByDescending(x => x.ComplexityEnum)
                        //.ThenBy(x => x.TaskName)
                        .ToList();
                    Console.WriteLine("Low priority tasks are:");
                    foreach (Task task in lowtasks)
                    {
                        Output.PrintTaskDetails(task);
                    }
                    break;

                default:
                    while (attempts != 0)
                    {
                        Console.WriteLine("Invalid input, please use ONLY 'High', 'Medium', 'Low' options");
                        attempts--;
                    }
                    break;


            }


        }

        public void ListOfTasksCompletedBasedOnPriority()
        {

        }
    }
}
