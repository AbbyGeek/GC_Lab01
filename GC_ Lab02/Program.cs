using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC__Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go == true)
            {
                Console.WriteLine("Enter the width of the room");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the room");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the room");
                double height = Convert.ToDouble(Console.ReadLine());

                double area = width * length;
                double perimeter = (width + length) * 2;
                double volume = (width * height * length);

                Console.WriteLine("The area of the room is: " + area.ToString());
                Console.WriteLine("The perimeter of the room is: " + perimeter.ToString());
                Console.WriteLine("The volume of the room is: " + volume.ToString());

                Console.WriteLine("Are you done yet? (y/n)");
                string input = Console.ReadLine();
                go = input == "y" ? false : true;
            }
        }
    }
}
