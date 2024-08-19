using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    internal class Rectangular: Figure
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangular(double width, double length)
        {
            if (width > 0 && length > 0)
            {
                Width = width;
                Length = length;
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz reqem duzgun deyil");

            }
        }

        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
