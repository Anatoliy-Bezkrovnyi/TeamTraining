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

        public void ListofTasksAccordingToPriority()
        {
            Console.WriteLine("Please enter tasks priority to find all corresponding tasks, use 'High', 'Medium', 'Low'.");
            String enteredPriority = Console.ReadLine();

            int attempts = 3;

            while (attempts != 0)
            {
                switch (enteredPriority)
                {
                    case "High":

                        break;
                    case "Medium":

                        break;
                    case "Low":

                        break;
                    default:
                        Console.WriteLine("Invalid input, please use ONLY 'High', 'Medium', 'Low' options");
                        attempts--;
                        break;
                }
            }
            

        }

        public void ListOfTasksCompletedBasedOnPriority()
        {

        }
    }
}
