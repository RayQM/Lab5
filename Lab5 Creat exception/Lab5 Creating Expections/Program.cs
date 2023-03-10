using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Creating_Expections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle posRad = new Circle(1.27);
            Console.WriteLine($"{posRad}\nArea: {posRad.Area}");

            //One object with negative radius
            try
            {
                Circle negRad = new Circle(-1.27);
            }
            catch (InvalidRadius IREx)
            {
                Console.WriteLine(IREx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //One object with radius of zero

            try
            {
                Circle zeroRad = new Circle(0);
            }
            catch (InvalidRadius IREx)
            {
                Console.WriteLine(IREx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
