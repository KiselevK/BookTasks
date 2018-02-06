using System;
using static System.Math;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BookTasks.Begin
{
    class Begin1
    {
        //Begin 1 
        //Дана сторона квадрата a. Найти его периметр P = 4·a. 
        public static void PerimeterOfSquare(double side) => Console.WriteLine($"Input is {side}\nPerimeter of Square is " + side * 4);

        //Begin 2 
        //Дана сторона квадрата a. Найти его площадь S = a2. 
        public static void AreaOfSqueare(double side) => Console.WriteLine($"Input is {side}\nArea is square " + Pow(side, 2));

        //Begin 3
        //Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b). 
        public static void AreaAndPerimeterOfRectangle(double sideA, double sideB) =>
            Console.WriteLine($"a is {sideA}, side b is {sideB} \nArea of rectangle is { sideA * sideB:F}, perimeter is {2 * (sideA + sideB):F}");

        //Begin 4
        //Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14. 
        public static void CircleDiameterLength(double diameter) => 
            Console.WriteLine($"Diameter is {diameter}\n Diameter length is {PI * diameter:F}" );

        //Begin 5 
        //Дана длина ребра куба a. Найти объем куба V = pow(a,3) и площадь его поверхности S = 6·pow(a,2).
        public static void VolumAndAreaofCube (double side)=> Console.WriteLine($"Side is {side}\nValum is {Pow(side, 3):F}, area is { 6 * Pow(side, 2):F}");

        //Begin 6
        //Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c). 
        public static void VolumAndAreaTriangle(double sideA, double sideB, double sideC) => 
            Console.WriteLine($"A = {sideA}, B = {sideB}, C = {sideC}\nValum = {sideA * sideB * sideC}, area = {2 * (sideA * sideB + sideB * sideC + sideA * sideC)}"); 

        //Begin7 
        //Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R,        S = π·pow(R,2).
        public static void LandSofCircle(double R) => Console.WriteLine($"R = {R}, L = { 2 * PI * R:F}, S = {PI * Pow(R, 2):f}");

        //Begin 8
        //Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2. 
        public static void AverageMeen(double firstValue, double secondValue) => 
            Console.WriteLine($"First value is {firstValue}, second is {secondValue}\nAverge meen is " + (firstValue + secondValue) / 2);

        //Begin 9
        //Даны два неотрицательных числа a и b. Найти их среднее геометрическое, т. е. квадратный корень из их произведения: pow((a·b),1/2). 
        public static void GeometricMean(double firstValue, double secondValue) => 
            Console.WriteLine($"First value is {firstValue}, second is {secondValue}\nGeometric meen is {Pow(firstValue *secondValue,(double)1 / 2):F}");

        // Begin10
        //Даны два ненулевых числа.Найти сумму, разность, произведение и частное их квадратов.
        public static void SumDifferenceProductQuotient(double firstValue, double secondValue) => 
            Console.WriteLine("Sum = {0}\nDifference = {1}\nProduct = {2}\nQuotient = {3:F}",Pow(firstValue,2)+Pow(secondValue,2),Pow(firstValue,2)-Pow(secondValue,2),
                Pow(firstValue, 2) * Pow(secondValue, 2), Pow(firstValue, 2) / Pow(secondValue, 2));


       // Begin11
       // Даны два ненулевых числа.Найти сумму, разность, произведение и частное их модулей.
        public static void SumDifferenceProductQuotientWithmodul(double firstValue, double secondValue)=>
            Console.WriteLine($"Sum = {Abs(firstValue) + Abs(secondValue):F}\nDifference = {Abs(firstValue) - Abs(secondValue)}"+
                $"\nProduct = {Abs(firstValue) * Abs(secondValue):F}\nQuotient={((firstValue) / (double)Abs(secondValue)):F}");

        //Begin12
       // Даны катеты прямоугольного треугольника a и b.Найти его гипотенузу c и периметр P: c = (a2 + b2)1/2,        P = a + b + c.
        public static void FindCAndPTriangle(double sideA, double sideB, double i = 0) => Console.WriteLine(
            $"A = {sideA}, B = {sideB}\nc = {i = Pow(Pow(sideA, 2) + Pow(sideB, 2), (double) 1 / 2):F}, P = {sideA + sideB + i:F}");

        //Begin13
        //Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). Найти площади этих кругов S1 и S2, а также площадь S3 кольца,
        //внешний радиус которого равен R1, а внутренний радиус равен R2: S1 = π·pow(R1),2,        S2 = π·pow((R2),2),        S3 = S1 − S2.
        public static void SCircle(double r1, double r2, double s1 = 0, double s2 = 0) => Console.WriteLine(
            $"R1 = {r1}, R1 = {r2}\nS1 = {s1 = PI * Pow(r1, 2)}, S2 = {s2 = PI * Pow(r2, 2)}, S3 = {s1 - s2:F}");

        // Begin14
        // Дана длина L окружности.Найти ее радиус R и площадь S круга, ограниченного этой окружностью, учитывая, 
        //что L = 2·π·R, S = π·R2.В качестве значения π использовать 3.14. 

        public static void RSCircle(double L, double r = 0) =>
            Console.WriteLine($"L={L}, R{r = L / (PI * 2):F}, S = {PI * Pow(r, 2):F}");
        
        //Begin15 
        //Дана площадь S круга. Найти его диаметр D и длину L окружности, ограничивающей этот круг, учитывая, что L = π·D,    S = π·D2/4.
        public static void SLCircle(double S, double D) =>
            Console.WriteLine($"S = {S}, D = {D = Sqrt(S * 4 / PI):D}, L = {PI * D}");

        //Begin16
        //Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|. 
        public static void DistanceFromx1Tox2(double x1, double x2) => Console.WriteLine($"x1 = {x1}, x2 = {x2}\nDistance ={Abs(x2-x1)}");

        //Begin17
        //Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму. 
        public static void FindACandBC(int A, int B, int C, int AC = 0, int BC = 0) =>
            Console.WriteLine($"A = {A}, B = {B}\n AC = {AC = Abs(C - A)}, BC = {BC = Abs(C-B)}, BC + Ac = {BC+AC}");

        //Begin18 
        //Даны три точки A, B, C на числовой оси.Точка C расположена между точками A и B.Найти произведение длин отрезков AC и BC.
        public static void FindACandBC2(int A, int B, int C, int AC, int BC) => Console.WriteLine(
            $"A = {A}, B = {B}, C = {C}\nAC = {AC = Abs(C - A)}, BC = {BC = Abs(C - B)}, AC*BC + {AC * BC} ");

        //Begin 19
        //Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат.
        //Найти периметр и площадь данного прямоугольника.
        public static void FinfRectangleAreAndPerimetr(int x1, int y1, int x2, int y2, int sideA, int sideB )=>Console.WriteLine($"Side a = {sideA = Abs(2-x1)}, side b = {sideB =Abs(y2-y1)}\nPerimetr = {2*(sideA+sideB)}, area = {sideA*sideB}");

        //Begin20
        //Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2) на плоскости. Расстояние вычисляется по формуле 
        //((x2 − x1)2 + (y2 − y1)2)1/2.

        public static void FindDistanceBetween(double x1, double y1, double x2, double y2) => Console.WriteLine("Distance = "+Pow((Pow(x2-x1,2)+Pow(y2-y1,2)),(double)1/2));

    }
}
