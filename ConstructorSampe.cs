using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(
                 InteractiveInput.InputFloat("幅："),
                 InteractiveInput.InputFloat("高さ："));
            Console.WriteLine($"面積は{triangle.GetArea()}");
        }
    }
}
