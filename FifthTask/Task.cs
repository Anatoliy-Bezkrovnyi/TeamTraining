using FifthTask.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    public class Task
    {

        public PriorityEnum PriorityEnum { get; set; }
        public ComplexityEnum ComplexityEnum { get; set; }
        public int Time { get; set; }
        public String TaskName { get; set; }
        public int TaskID { get; set; }
        public String TaskDescription { get; set; }

        public Task()
        {
            TaskID = Input.taskId;
            TaskName = Input.setTaskName();
            TaskDescription = Input.setTaskDescription();
            PriorityEnum = Input.GetPriority();
            ComplexityEnum = Input.GetComplexity();
            Time = (int)ComplexityEnum;
            
        }      

              


       
    }
}
