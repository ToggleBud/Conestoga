/*FirstProgram.cs
 * 
 * A simple program to deomonstrate some basic concepts including:
 *  - heaeder comments
 *  - body comments
 *  - grouping ofcode
 *  - sequencing
 *  
 *  Revision History
 *      Aidan Pearce ... Sept 7, 2023: Created
 */
/*
 * Things I would like to do
 * Loop the Meltdown to Flash Red and White
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.Write("Hello, ");
            Console.WriteLine("Welcome to PROG1925. ");
            Console.WriteLine("Waterloo Campus");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();

            //Changes Screen Colours
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //Makes Texts in the New Screen Colour
            Console.WriteLine("Programming");
            Console.WriteLine("Is this DarkGray?");
            Console.ReadKey();
            
            //Changes the Screen Colour
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            
            //Creates a Meltdown Screen With Timer of 1 Second
            Console.WriteLine("Meltdown Happening");
            Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Meltdwon Happening");

            //Final ReadKey Function to End Code!!
            Console.ReadKey();

        }
    }
}
