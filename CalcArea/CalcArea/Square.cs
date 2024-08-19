using CalcArea;

namespace CalcMethod
{
    public class Square :Figure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            if (side > 0)
            {
                Side = side;
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz reqem duzgun deyil");
            }
        }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }
}
