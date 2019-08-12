using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NewOneBas : Base<double>
    {
        public NewOneBas(int size) : base(size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                var rnd = new Random();
                gar.Add(rnd.NextDouble());
            }
        }

        public NewOneBas()
        {
            for (int i = 0; i < 9; i++)
            {
                var rnd = new Random();
                gar.Add(rnd.NextDouble());
            }
        }

    }
}
