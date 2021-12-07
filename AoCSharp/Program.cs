using System;

namespace AoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subCalc = new Day2_SubBearingCalculator();

            subCalc.CoordinateFilePath = ".\\inputFiles\\day2.txt";

            subCalc.ProcessSubCoordinates();
        }
    }
}
