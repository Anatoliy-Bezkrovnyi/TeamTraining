using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    class Task
    {

        public PriorityEnum PriorityEnum { get; set; }
        public ComplexityEnum ComplexityEnum { get; set; }
        public TimeEnum TimeEnum { get; set; }

        public Task()
        {
            taskId = Input.setTaskID();
            taskName = Input.setTaskName();
            taskDescription = Input.setTaskDescription();
            PriorityEnum = Input.GetPriority();
            ComplexityEnum = Input.GetComplexity();
            TimeEnum = Input.GetTime();

        }

        

        int taskId = 0;
        String taskName;
        String taskDescription;

        


       
    }
}
