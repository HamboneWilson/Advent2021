using System;

namespace AoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subCalc = new SubBearingCalculator();

            subCalc.CoordinateFilePath = ".\\inputFiles\\day2.txt";

            subCalc.ProcessSubCoordinates();
        }
    }
}
