using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask
{
    public class SimpleFestoon : Festoon<LightBulb>
    {
        protected List<LightBulb> CreateFestoon<LightBulb>()
        {
            int simpleBulbsQuantity = 0;
            int counter = 3;
            List<LightBulb> simpleFestoon = new List<LightBulb>();
            
            Console.WriteLine("Please enter the quantity of simple lightbulbs to create simple festoon:");
            

            while (counter > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int parsedInput) && parsedInput > 0)
                {
                    simpleBulbsQuantity = parsedInput;

                    for (int i = 0; i < simpleBulbsQuantity; i++)
                    {
                        simpleFestoon.Add(new LightBulb());                       
                    }

                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input. Please, use only digits to set bulbs quantity:");
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Default festoon with twenty lightbulbs was created");

                for (int i = 0; i < 20; i++)
                {
                    
                        simpleFestoon.Add(new LightBulb());
                    
                }
            }

            return simpleFestoon;

        }

        public override void LightUpFestoon(List<LightBulb> NewFestoon)
        {

            foreach (var bulb in NewFestoon)
            {
                Console.WriteLine(bulb);
            }
            
            //DateTime date = DateTime.Now;

            //bool isOn = date.Minute % 2 == 0;

            //throw new NotImplementedException();
        }

        public override void LightUpFestoon(LightBulb NewFestoon)
        {
            throw new NotImplementedException();
        }
    }
}
