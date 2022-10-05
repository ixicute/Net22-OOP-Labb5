using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net22_OOP_CircleClass
{
    internal class Circle
    {
        //Fields
        private const float pi = 3.141f;
        private int radius;

        //Constructor
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            float math,
                  result;

            math = radius * radius * pi;

            //Explicit type-casting and limiting output to 3 decimals.
            result = (float)Math.Round(math, 3);

            return result;
        }

        public float GetVolume()
        {
            float math,
                  result;

            math = (4.0f / 3f) * pi * radius * radius * radius;

            //Explicit type-casting and limiting output to 3 decimals.
            result = (float)Math.Round(math, 3);

            return result;
        }

        public float GetCircumference()
        {
            float math,
                  result;

            math = 2 * pi * radius;

            //Explicit type-casting and limiting output to 3 decimals.
            result = (float)Math.Round(math, 3);

            return result;
        }
    }
}
