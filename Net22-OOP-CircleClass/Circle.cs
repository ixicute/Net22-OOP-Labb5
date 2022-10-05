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

        //Method to round up numbers and keep a maximum of 3 decimals.
        public float RoundUp(float math)
        {
            //Explicit type-casting and limiting output to 3 decimals.
            float roundedNumber = (float)Math.Round(math, 3);

            return roundedNumber;
        }

        public float GetArea()
        {
            float area,
                  result;

            area = radius * radius * pi;

            result = RoundUp(area);

            return result;
        }

        public float GetVolume()
        {
            float volume,
                  result;

            volume = (4.0f / 3f) * pi * radius * radius * radius;

            result = RoundUp(volume);

            return result;
        }

        public float GetCircumference()
        {
            float circumference,
                  result;

            circumference = 2 * pi * radius;

            result = RoundUp(circumference);

            return result;
        }
    }
}
