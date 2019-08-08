using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask
{
    public abstract class Festoon<T>
    {
        protected Festoon()
        {
            CreateFestoon<T>();            
        }
        public abstract void CreateFestoon<T>();
    }
}
