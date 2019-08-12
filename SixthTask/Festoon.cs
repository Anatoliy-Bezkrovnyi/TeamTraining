using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask
{
    public abstract class Festoon<T>
    {

        public List<T> NewFestoon { get; set; }

        public Festoon()
        {
            NewFestoon = new List<T>();            
        }

        
        //protected abstract List<T> CreateFestoon();
        public abstract void LightUpFestoon(T NewFestoon);
    }
}
