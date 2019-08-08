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

        
        protected abstract void CreateFestoon<T>();
        protected abstract void LightUpFestoon<T>();
    }
}
