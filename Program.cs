using System;

namespace examSat
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double filmBackWidth = double.Parse(Console.ReadLine());
            if (filmBackWidth > 0)
            {
                do
                    {
                        Console.WriteLine("invalid filmBackWidth please input again.");
                        filmBackWidth = double.Parse(Console.ReadLine());

                     } while (filmBackWidth !> 0);
            }
            else
            {
                double fLength, fov;

                if (mode == "fLength")
                {
                    do
                    {
                        Console.WriteLine("invalid fLength please input again.");
                        fLength = double.Parse(Console.ReadLine());

                    } while (fLength !> 0);
                    if (fLength>0)
                    {
                        fov = 2 * Math.Atan2(filmBackWidth / 2, fLength);
                        Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
                    }
                    
                }
                else if(mode == "fov")
                {
                    do
                    {
                        Console.WriteLine("invalid fov. please input again.");
                        fov = double.Parse(Console.ReadLine());

                    } while (fov !> 0.1 && fov !< 6.28 );

                    if (fov > 0.1 && fov < 6.28)
                    {
                        fLength = filmBackWidth / (2 * Math.Atan(fov / 2));

                        Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
                    }
                    }
                }
                
            

            
        }
    }
}
