using System;
using System.Collections.Generic;
using System.Text;
using SixthTask.Enums;

namespace SixthTask
{
    public class LightBulb
    {
        public StateEnum State { get; set; }

        public LightBulb ()
        {
            this.State = StateEnum.Off;
        }
    }
}
