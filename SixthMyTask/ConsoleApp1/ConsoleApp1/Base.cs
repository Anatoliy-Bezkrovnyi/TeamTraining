using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Base <T>
    {
        protected List<T> gar;

        protected Base(int size)
        {
            gar = new List<T>(size);
        }

        protected Base()
        {
            gar = new List<T>();
        }
    }
}
