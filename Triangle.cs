using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        float Length;
        float Height;
        float SidesA;
        float SidesB;
        float SidesC;

        public Triangle(float l, float h)
        {
            this.Length = l;
            this.Height = h;
        }

        public TriangleEdge(float a,float b,float c)
        {
            this.SidesA = a;
            this.SidesB = b;
            this.SidesC = c;
        }

        public float GetArea()
        {
            return (Length * Height / 2);
        }

        public float GetHeronsFormula()
        {
            return ((SidesA+SidesB+SidesC)/2) ;
        }

    }
}
