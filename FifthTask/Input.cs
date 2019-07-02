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
            PriorityEnum en = PriorityEnum.High;

            return en;
        }

        public static ComplexityEnum GetComplexity()
        {
            ComplexityEnum en = ComplexityEnum.Light;

            return en;
        }

        public static TimeEnum GetTime()
        {
            TimeEnum en = TimeEnum.Mild;

            return en;
        }
    }
}
