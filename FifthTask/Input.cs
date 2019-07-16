using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FifthTask
{
    public class Input
    {
        public static int taskId = 0;

        public static void AddNewTask(ref List<Task> tasks)
        {
            int counter = 5;
            while(counter > 0)
            {
                tasks.Add(new Task());
                counter--;
                Input.taskId++;
                Console.WriteLine("Your task was created");
                if (counter > 0)
                {
                    Console.WriteLine($"You should add {counter} more task(s), please proceed");
                }
                else
                {
                    Console.WriteLine("Task creation is finished");
                }
            }
           
            
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
            Console.WriteLine("Please select task priority, use '1 - High', '2 - Medium', '3 - Low' keys from numeric keyboard");

            foreach (String priorityEnum in Enum.GetNames(typeof(PriorityEnum)))
            {
                Console.WriteLine(priorityEnum);
            }

            int counter = 3;
            PriorityEnum priority = PriorityEnum.Low;

            while (counter > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int parsedInput) && parsedInput > 0 && parsedInput <= 3)
                {
                    priority = (PriorityEnum)parsedInput;
                    break;                 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please, use only '1 - High', '2 - Medium', '3 - Low' keys from numeric keyboard");
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Your task priority was set to default 'Low' value");
            }
           
            return priority;
           
        }


        public static ComplexityEnum GetComplexity()
        {
            Console.WriteLine("Please select task complexity, use '4 - Hard', '2 - Mild', '1 - Light' keys from numeric keyboard");

            foreach (String complexityEnum in Enum.GetNames(typeof(ComplexityEnum)))
            {
                Console.WriteLine(complexityEnum);
            }

            int counter = 3;
            ComplexityEnum complexity = ComplexityEnum.Light;

            while (counter > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int parsedInput) && (parsedInput == 1 || parsedInput == 2 || parsedInput == 4))
                {
                    complexity = (ComplexityEnum)parsedInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please, use only '4 - Hard', '2 - Mild', '1 - Light' keys from numeric keyboard");
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Your task complexity was set to default 'Light' value");
            }

            return complexity;
        }

       

    }
}
