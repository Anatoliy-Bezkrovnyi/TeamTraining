using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask
{
    class Task
    {
        public Task()
        {
            taskId = Input.setTaskID();
            taskName = Input.setTaskName();
            taskDescription = Input.setTaskDescription();
        }

        int taskId = 0;
        String taskName;
        String taskDescription;

        enum Priority
        {
            High,
            Middle,
            Low
        }

        enum Complexity
        {
            Hard, 
            Mild,
            Light
        }
    }
}
