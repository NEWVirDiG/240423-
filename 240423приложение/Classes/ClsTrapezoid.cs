using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourangleClasses.Classes
{
    internal class ClsTrapezoid : ClsFourangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;
        private double diagonal1;
        private double diagonal2;
        //Вычисление сторон
        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            sideB = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            sideC = Math.Sqrt((X3 - X4) * (X3 - X4) + (Y3 - Y4) * (Y3 - Y4));
            sideD = Math.Sqrt((X4 - X1) * (X4 - X1) + (Y4 - Y1) * (Y4 - Y1));
            Console.WriteLine("Стороны Трапезоида");
            Console.WriteLine($"Сторона A = {Math.Round(sideA, 2)}");
            Console.WriteLine($"Сторона B = {Math.Round(sideB, 2)}");
            Console.WriteLine($"Сторона C = {Math.Round(sideC, 2)}");
            Console.WriteLine($"Сторона D = {Math.Round(sideD, 2)}");
        }
        public double Perimetr()
        {
            return sideA+sideB+sideC+sideD;
        }
        public void DiagonalsCalculation()
        {
            diagonal1 = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            diagonal2 = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            Console.WriteLine($"Диагональ1 = {Math.Round(diagonal1, 2)}");
            Console.WriteLine($"Диагональ2 = {Math.Round(diagonal2, 2)}");
        }
        public double Ploshad()
        {
            return ((sideA + sideB)/2) * Math.Sqrt((sideC * sideC) - (((Math.Pow(sideA - sideB, 2)) + (sideC * sideC) - (sideD * sideD)) / 2 * (sideA - sideB)));
        }
    }
}
