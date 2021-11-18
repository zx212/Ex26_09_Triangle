using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        float Length;
        float Height;

        public Triangle(float l, float h)
        {
            this.Length = l;
            this.Height = h;
        }

        public float GetArea()
        {
            return (Length * Height / 2);
        }

    }
}
