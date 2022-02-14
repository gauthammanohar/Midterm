using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            while(option == 1)
            {
                Console.Clear();
                int screenWidth, screenHeight, diagonalSize;
                Console.WriteLine("==========================================================");
                Console.WriteLine("Menu");
                Console.WriteLine("==========================================================");

                Console.Write("1. Enter Screen dimensions\n2. Exit\nEnter your choice : ");
                while (!int.TryParse(Console.ReadLine(), out option) || (option != 1 && option != 2)) //Accepts only integer user inputs that is 1 or 2.
                {
                    Console.WriteLine("Please enter a valid option!\n\n");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Menu");
                    Console.WriteLine("==========================================================");
                    Console.Write("1. Enter Screen dimensions\n2. Exit\nEnter your choice : ");
                };
                if (option != 2)
                {
                    Console.WriteLine("\n\nPlease enter the following integers :");
                    Console.WriteLine("==========================================================");
                    Console.Write("Screen width : ");
                    while (!int.TryParse(Console.ReadLine(), out screenWidth) || (screenWidth <= 0)) //Accepts only integer value inputs that is greater than 0.
                    {
                        Console.WriteLine("Please enter a valid screen width!\n");
                        Console.Write("Screen width : ");
                    };
                    Console.Write("Screen height : ");
                    while (!int.TryParse(Console.ReadLine(), out screenHeight) || (screenHeight <= 0)) //Accepts only integer value inputs that is greater than 0.
                    {
                        Console.WriteLine("Please enter a valid screen height!\n");
                        Console.Write("Screen height : ");
                    };
                    Console.Write("Diagonal size : ");
                    while (!int.TryParse(Console.ReadLine(), out diagonalSize) || (diagonalSize <= 0)) //Accepts only integer value inputs that is greater than 0.
                    {
                        Console.WriteLine("Please enter a valid diagonal size!\n");
                        Console.Write("Diagonal size : ");
                    };
                    Console.WriteLine("\n\nResult");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("PPI                  : " + PixelCalc.CalculatePPI(screenWidth, screenHeight, diagonalSize) + " pixels per in");
                    Console.WriteLine("Diagonal (in pixels) : " + PixelCalc.CalculateDiagonalInPixels(screenWidth, screenHeight) + " pixels");
                    Console.WriteLine("Dot Pitch            : " + PixelCalc.CalculateDotPitch(screenWidth, screenHeight, diagonalSize) + " mm");
                }
                Console.ReadKey();
            }
        }
    }
}
