using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of items:");
            int number = Convert.ToInt32(Console.ReadLine());
            class_anbar[] items = new class_anbar[number];
             

                for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"please enter name of items {(i+1)}:");
                string name = Console.ReadLine();

                Console.WriteLine($"please enter model of items {(i + 1)}:");
                string model = Console.ReadLine();

                class_anbar anbar = new class_anbar(name, model);
                items[i]= anbar;

            }
            
               foreach(class_anbar class_Anbar in items)
            {
                Console.WriteLine($"name :{class_Anbar.name} model:{class_Anbar.model}");
                Console.ReadKey();
            }

        }
    }
}
