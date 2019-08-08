using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTask
{
    public class SimpleFestoon<T> : Festoon<T>
    {
        public override void CreateFestoon<SimpleFestoon>()
        {
            int simpleBulbsQuantity = 0;
            int counter = 3;
            List<LightBulb> simpleFestoon = new List<LightBulb>();
            //LightBulb lightBulb = new LightBulb();
            // TODO: CreateFestoon Festoon

                // TODO: Light Feston
               

            Console.WriteLine("Please enter the quantity of simple lightbulbs to create simple festoon:");
            DateTime date = DateTime.Now;

            bool isOn = date.Minute % 2 == 0 ;

            while (counter > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int parsedInput) && parsedInput > 0)
                {
                    simpleBulbsQuantity = parsedInput;

                    for (int i = 0; i < simpleBulbsQuantity; i++)
                    {
                        if (i % 2 == 0 && isOn)
                        {
                            simpleFestoon.Add(new LightBulb("Shines"));
                        }
                        else
                        {
                            simpleFestoon.Add(new LightBulb("Doesn't shine"));
                        }

                        Console.WriteLine($"Bulb {i}: {simpleFestoon[i].State}");
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
                    if (i % 2 == 0 && isOn)
                    {
                        simpleFestoon.Add(new LightBulb("Shines"));
                    }
                    else
                    {
                        simpleFestoon.Add(new LightBulb("Doesn't shine"));
                    }

                    Console.WriteLine($"Bulb {i}: {simpleFestoon[i].State}");
                }
            }
            
        }
    }
}
