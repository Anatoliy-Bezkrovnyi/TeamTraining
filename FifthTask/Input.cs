using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    public class Input
    {

        public static void AddNewTask(ref List<Task> tasks)
        {
            int i = 10;
            while(i > 5)
            {
                tasks.Add(new Task());
                i--;
            }
        }


        public static int setTaskID()
        {
            int taskID = 0;
            return taskID;
        }

        public static String setTaskName()
        {
            Console.WriteLine("Please provide task name:");
            String taskName = Console.ReadLine();
            return taskName;
        }

        public static String setTaskDescription()
        {
            Console.WriteLine("Please provide task description:");
            String taskDescription = Console.ReadLine();
            return taskDescription;
        }

        public static PriorityEnum GetPriority()
        {
            Console.WriteLine("Please select task priority, use '0', '1', '2' keys from numeric keyboard");

            foreach (String priorityEnum in Enum.GetNames(typeof(PriorityEnum)))
            {
                Console.WriteLine(priorityEnum);
            }

            int counter = 3;
            PriorityEnum priority = PriorityEnum.Low;

            while (counter > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int parsedInput) && parsedInput >= 0 && parsedInput < 3)
                {
                    priority = (PriorityEnum)parsedInput;
                    break;                 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please use only '0', '1', '2' keys from numeric keyboard");
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Your task priority was set to defult 'Low' value");
            }
           
            return priority;
           
        }


        public static ComplexityEnum GetComplexity()
        {
            Console.WriteLine("Please select task complexity, use '1', '2', '3' keys from numeric keyboard");

            foreach (String complexityEnum in Enum.GetNames(typeof(ComplexityEnum)))
            {
                Console.WriteLine(complexityEnum);
            }

            String complexityInput = Console.ReadLine();

            while (true)
            {
                switch (complexityInput)
                {
                    case "1":
                        return ComplexityEnum.Hard;                        
                    case "2":
                        return ComplexityEnum.Mild;
                    case "3":
                        return ComplexityEnum.Light;
                    default:
                        Console.WriteLine("Invalid input, please ONLY '1', '2', '3' keys from numeric keyboard");
                        complexityInput = Console.ReadLine();
                        break;
                }
            }
        }

        
    }
}
