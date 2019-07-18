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

        public static TEnum RequestForEnumValue<TEnum>() where TEnum : struct
        {
            Console.Clear();
            TEnum result;
            bool parseResult;

            do
            {
                string _pr = Console.ReadLine();
                parseResult = Enum.TryParse(_pr, ignoreCase: true, result: out result)
                              & Enum.IsDefined(typeof(TEnum), result);

                if (!parseResult)
                {
                    Console.Clear();
                    Console.WriteLine($"Please, enter number or value from the current list");
                }

            } while (!parseResult);
            return result;
        }

        public void ListofTasksAccordingToPriority(List<Task> taskList)
        {
            Console.WriteLine("Please enter tasks priority to find all corresponding tasks, use 'High', 'Middle', 'Low'.");

            int attempts = 3;
            PriorityEnum priority;
            bool parseResult = false;
            List<Task> sortedList = new List<Task>();


            while (attempts != 0)
            {
                string _pr = Console.ReadLine();
                parseResult = Enum.TryParse(_pr, ignoreCase: true, result: out priority)
                              & Enum.IsDefined(typeof(PriorityEnum), priority);

                if(parseResult)
                {
                    sortedList = taskList.Where(x => x.PriorityEnum == priority)
                                            .OrderByDescending(x => x.ComplexityEnum)
                                            .ToList();
                    break;
                }

                Console.WriteLine("Please, enter one from 'High', 'Middle' or 'Low'.");
                attempts--;
            }

            if(parseResult)
            {
                if (sortedList.Count == 0)
                {
                    Console.WriteLine($"There are no tasks of selected priority");
                }
                else
                {
                    Console.WriteLine("Tasks of selected priority are:");
                    foreach (Task task in sortedList)
                    {
                        Output.PrintTaskDetails(task);
                    }
                }
            }
            else
            {
                Console.WriteLine("All tasks were selected by default:");
                foreach (Task task in taskList)
                {
                    Output.PrintTaskDetails(task);
                }
            }

            /*
            while (attempts != 0)
            {
                bool isSuccess = false;
                String enteredPriority = Console.ReadLine().ToLower();

                switch (enteredPriority)
                {
                    case "high":
                        List<Task> hightasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.High)
                        .OrderByDescending(x => x.ComplexityEnum)
                        //.ThenBy(x => x.TaskName)
                        .ToList();
                        if (hightasks.Count == 0)
                        {
                            Console.WriteLine("There are no high priority tasks in the list, please select other option:");
                        }
                        else
                        {
                            Console.WriteLine("High priority tasks are:");
                            foreach (Task task in hightasks)
                            {
                                Output.PrintTaskDetails(task);
                            }
                        } 
                        
                        break;

                    case "medium":
                        List<Task> middletasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.Middle)
                            .OrderByDescending(x => x.ComplexityEnum)
                            //.ThenBy(x => x.TaskName)
                            .ToList();
                        if (middletasks.Count == 0)
                        {
                            Console.WriteLine("There are no middle priority tasks in the list, please select other option:");
                        }
                        else
                        {
                            Console.WriteLine("Middle priority tasks are:");
                            foreach (Task task in middletasks)
                            {
                                Output.PrintTaskDetails(task);
                            }
                        }
                        break;

                    case "low":
                        List<Task> lowtasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.Low)
                            .OrderByDescending(x => x.ComplexityEnum)
                            //.ThenBy(x => x.TaskName)
                            .ToList();
                        if (lowtasks.Count == 0)
                        {
                            Console.WriteLine("There are no low priority tasks in the list, please select other option:");
                        }
                        else
                        {
                            Console.WriteLine("Low priority tasks are:");
                            foreach (Task task in lowtasks)
                            {
                                Output.PrintTaskDetails(task);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input, please use ONLY 'High', 'Medium', 'Low' options");
                        attempts--;
                        break;
                }

                if (isSuccess)
                    break;
            }
            if (attempts == 0)
            {
                List<Task> defaulttasks = taskList.Where(x => x.PriorityEnum == PriorityEnum.High)
            .OrderByDescending(x => x.ComplexityEnum)
            //.ThenBy(x => x.TaskName)
            .ToList();
                Console.WriteLine("High priority tasks were selected by default:");
                foreach (Task task in defaulttasks)
                {
                    Output.PrintTaskDetails(task);
                }
            }
            */

        }

        public void ListOfTasksToCompleteBasedOnPriority(List<Task> taskList)
        {
            List<Task> sortedTaskList = taskList.OrderBy(x => x.PriorityEnum).ThenByDescending(x => x.ComplexityEnum).ToList();
            List<Task> tasksForDay = new List<Task>();
            int daytime = 8;
            for (int i = 0; i < sortedTaskList.Count; i++)
            {
                tasksForDay.Add(sortedTaskList[i]);
                daytime = daytime - sortedTaskList[i].Time;

                if (daytime == 0)
                {
                    Console.WriteLine("Your tasks for day:");
                    foreach (Task task in tasksForDay)
                    {
                        Output.PrintTaskDetails(task);
                    }
                    break;
                }
                else if (daytime < 0)
                {
                    daytime = daytime + tasksForDay.Last().Time;
                    //tasksForDay.RemoveAt(tasksForDay.IndexOf(tasksForDay.Last()));
                    tasksForDay.Remove(tasksForDay.LastOrDefault());

                }
            }
        }
    }
}
