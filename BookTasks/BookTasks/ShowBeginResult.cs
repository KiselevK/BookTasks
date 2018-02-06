using System;

using BookTasks.Begin;

namespace BookTasks
{
    class ShowBeginResult
    {
        public static void ShowFrom1to11()
        {
            Console.WriteLine("-------------------\nbegin1");
            Begin1.PerimeterOfSquare(6);
            Console.WriteLine("-------------------\nbegin2");
            Begin1.AreaOfSqueare(5);
            Console.WriteLine("-------------------\nbegin3");
            Begin1.AreaAndPerimeterOfRectangle(7,6);
            Console.WriteLine("-------------------\nbegin4");
            Begin1.CircleDiameterLength(9);
            Console.WriteLine("-------------------\nbegin5");
            Begin1.VolumAndAreaofCube(4);
            Console.WriteLine("-------------------\nbegin6");
            Begin1.VolumAndAreaTriangle(5,6,1);
            Console.WriteLine("-------------------\nbegin7");
            Begin1.LandSofCircle(6);
            Console.WriteLine("-------------------\nbegin8");
            Begin1.AverageMeen(10,5);
            Console.WriteLine("-------------------\nbegin9");
            Begin1.GeometricMean(9,7);
            Console.WriteLine("-------------------\nbegin10");
            Begin1.SumDifferenceProductQuotient(17,19);
            Console.WriteLine("-------------------\nbegin11");
            Begin1.SumDifferenceProductQuotientWithmodul(-19,29);
            
        }

        public static void ShowFrom12()
        {
            Console.WriteLine("-------------------\nbegin12");
            Begin1.FindCAndPTriangle(4,5);
        }
    }
}
