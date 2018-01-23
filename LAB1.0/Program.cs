using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            do
            {

                double Width;
                double Length;
                double Height;

                //input

                Width = Doubles();
                Length = Triples();
                Height = Quad();

                //processing
                double Area;
                double Volume;
                double Peramiter;
                Area = (Width * Length);
                Peramiter = ((Width * 2) + (Length * 2));
                Volume = (Width * Length * Height);


                // Output
                Console.WriteLine("The area of the room is: " + Area);
                Console.WriteLine("The Peramiter of the room is: " + Peramiter);
                Console.WriteLine("The volume of the room is: " + Volume);
                Console.WriteLine("Would you like me to calculate the size of another room? (Y/N)");
                repeat = Console.ReadLine();


            } while (repeat == "y");
              


            
        }

        private static double Doubles()
        {
            double Width;
            Console.WriteLine("Please enter the width");
            Width = double.Parse(Console.ReadLine());
            return Width;
        }

        private static double Triples()
        {
            double Length;
            Console.WriteLine("Please enter the Length");
            Length = double.Parse(Console.ReadLine());
            return Length;
        }

        private static double Quad()
        {

            double Height;
            Console.WriteLine("Please enter the height");
            Height = double.Parse(Console.ReadLine());
            return Height;
            
        }
    }
}
