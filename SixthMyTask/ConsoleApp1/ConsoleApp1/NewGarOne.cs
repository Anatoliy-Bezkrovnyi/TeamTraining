using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NewGarOne : Base<int>
    {
        public NewGarOne() : base()
        {
            for (int i = 0; i < 15; i++)
            {
                gar.Add(i);
            }
        }
    }
}
