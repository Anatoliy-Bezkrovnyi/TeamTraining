using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    public class Input
    {


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
            Console.WriteLine("Please select task priority, use '1', '2', '3' keys from numeric keyboard");

            foreach (String priorityEnum in Enum.GetNames(typeof(PriorityEnum)))
            {
                Console.WriteLine(priorityEnum);
            }

            String priorityInput = Console.ReadLine();

            while (true)
            {
                switch (priorityInput)
                {
                    case "1":
                        return PriorityEnum.High;
                    case "2":
                        return PriorityEnum.Middle;
                    case "3":
                        return PriorityEnum.Low;
                    default:
                        Console.WriteLine("Invalid input, please ONLY '1', '2', '3' keys from numeric keyboard");
                        priorityInput = Console.ReadLine();
                        break;
                }
            }

           
        }


        public static ComplexityEnum GetComplexity()
        {
            Console.WriteLine("Please select task priority, use '1', '2', '3' keys from numeric keyboard");

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

        public static TimeEnum GetTime()
        {
            Console.WriteLine("Please select task priority, use '1', '2', '3' keys from numeric keyboard");

            foreach (String timeEnum in Enum.GetNames(typeof(TimeEnum)))
            {
                Console.WriteLine(timeEnum);
            }

            String timeInput = Console.ReadLine();

            while (true)
            {
                switch (timeInput)
                {
                    case "1":
                        return TimeEnum.Hard;
                    case "2":
                        return TimeEnum.Mild;
                    case "3":
                        return TimeEnum.Light;
                    default:
                        Console.WriteLine("Invalid input, please ONLY '1', '2', '3' keys from numeric keyboard");
                        timeInput = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
