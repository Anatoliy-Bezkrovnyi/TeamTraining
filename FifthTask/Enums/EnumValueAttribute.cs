using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTask.Enums
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumValueAttribute : Attribute
    {
        public EnumValueAttribute(int value)
        {
            EnumValue = value;
        }

        public int EnumValue { get; }
    }
}
