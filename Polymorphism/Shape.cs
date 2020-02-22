using System;

namespace Polymorphism
{
    class Shape
    {
        public int Perimeter(int side1, int side2, int side3)
        {
            return side1 + side2 + side3;
        }

        public int Perimeter(int side1, int side2, int side3, int side4)
        {
            return side1 + side2 + side3 + side4;
        }
    }
}
