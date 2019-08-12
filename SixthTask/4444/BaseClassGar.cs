using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask._4444
{
    abstract class BaseClassGar<T> where T : LightBulb
    {
        List<T> gar;

        public BaseClassGar()
        {
            gar = new List<T>();
        }

    }
}
