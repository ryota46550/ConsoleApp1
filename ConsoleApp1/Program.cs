using System;
namespace Ex26
{
    class Ex26
    {
        static void Main(string[] args)
        {
            var width = InputUtility.InputFloat("幅");
            var height = InputUtility.InputFloat("高さ");
            var depth = InputUtility.InputFloat("奥行");
            Box box = new Box(width, height, depth);
            Console.WriteLine($"boxの表面積{box.GetSurface()}boxの体積={box.GetVolume()}");

        }

    }
}