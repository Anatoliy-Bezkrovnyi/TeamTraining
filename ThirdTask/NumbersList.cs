using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdTask
{
    class NumbersList
    {

        
        
        public int[] CreateNumbersArray()
        {


            int[] numbersArray = new int[(Helper.maxRange - Helper.minRange) + 1];
            
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Helper.minRange;
                Helper.minRange++;
                Console.WriteLine(numbersArray[i]);
            }

            return numbersArray;

                
        }
    }
}
