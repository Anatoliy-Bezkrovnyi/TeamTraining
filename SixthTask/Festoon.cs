using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask
{
    public abstract class Festoon<T>
    {

        public T NewFestoon { get; set; }

        protected Festoon()
        {
            NewFestoon = CreateFestoon();            
        }

        
        protected abstract T CreateFestoon();
        public abstract void LightUpFestoon(T NewFestoon);
    }
}
