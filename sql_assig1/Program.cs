using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_assig1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLength, strWidth;
            int length, width;
            while (true)
            {
                Console.Write("Enter Length: ");
                strLength = Console.ReadLine();
                if (!int.TryParse(strLength, out length) || (length <= 0))
                    Console.Write("\n\tInvalid Input\n\tplease enter again");
                else
                    break;
            }
            while (true)
            {
                Console.Write("Enter Width: ");
                strWidth = Console.ReadLine();
                if (!int.TryParse(strWidth, out width) || (width <= 0))
                    Console.Write("\n\tInvalid Input\n\tplease enter again");
                else
                    break;
            }
            Rectangle rect = new Rectangle(length, width);
            int opt = 0;
            do
            {
                while (true)
                {
                    Console.Write("\n\t1. Get Rectangle Length\n" +
                        "\t2. Change Rectangle Length\n" +
                        "\t3. Get Rectangle Width\n" +
                        "\t4. Change Rectangle Width\n" +
                        "\t5. Get Rectangle Perimeter\n" +
                        "\t6. GetRectangle Area\n" +
                        "\t7. Exit\nEnter your choise:");
                    if (!int.TryParse(Console.ReadLine(), out opt) || (opt > 7 || opt < 1))
                        Console.Write("\n\tInvalid Input\n\tplease enter again");
                    else
                        break;
                }
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Length of ractangle: " + rect.GetLength().ToString());
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Enter Length: ");
                            strLength = Console.ReadLine();
                            if (!int.TryParse(strLength, out length) || (length <= 0))
                                Console.Write("\n\tInvalid Input\n\tplease enter again");
                            else
                                break;
                        }
                        rect.SetLength(length);
                        break;
                    case 3:
                        Console.WriteLine("Width of ractangle: " + rect.GetWidth().ToString());
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Enter Width: ");
                            strWidth = Console.ReadLine();
                            if (!int.TryParse(strWidth, out width) || (width <= 0))
                                Console.Write("\n\tInvalid Input\n\tplease enter again");
                            else
                                break;
                        }
                        rect.SetWidth(width);
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of ractangle: " + rect.GetPerimeter().ToString());
                        break;
                    case 6:
                        Console.WriteLine("Area of ractangle: " + rect.GetArea().ToString());
                        break;
                    case 7:
                        Console.WriteLine("Good bye");
                        break;
                    default:
                        Console.WriteLine("Exception occured");
                        break;
                }
            } while (opt != 7);
        }
    }
}
