using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;

            float x1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);

                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
              
                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}",x,y);
                    x += dx;
                    y += dy;
                }
            }
            else
            {
                step = Math.Abs(dy);

                step = Math.Abs(dx);

                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                }
            }

        }
    }
}
