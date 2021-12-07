using System;
using System.IO;
using System.Collections.Generic;

namespace AoCSharp
{
    class SubBearingCalculator
    {
        private string coordinateFilePath;

        public String CoordinateFilePath
        {
            get { return coordinateFilePath; }
            set { coordinateFilePath = value; }
        }

        public void ProcessSubCoordinates(){
            var coordinateDict = new Dictionary<String, List<Int32>>();
            var coordinates = File.ReadLines(coordinateFilePath);

            var depth = 0;
            var distance = 0;
            var aim = 0;

            foreach( var coord in coordinates ){
                var coordArray = coord.Split(" ");

                var moveType = coordArray[0];
                var speed = Int32.Parse(coordArray[1]);

                switch( moveType )
                {
                    case "forward":
                        distance += speed;
                        depth += (aim * speed);
                        
                        break;
                    case "up":
                        aim -= speed;
                        break;
                    case "down":
                        aim += speed;
                        break;
                    default:
                        throw new Exception( "This sub can't move " + moveType + "!");
                }
            }

            var squareMiles = depth * distance;

            Console.WriteLine( "Sub current depth: " + depth.ToString() );
            Console.WriteLine( "Sub current distance: " + distance.ToString() );
            Console.WriteLine( "Sub aim: " + aim.ToString());
            Console.WriteLine( "Square miles traveled: " + squareMiles.ToString() );
        }
    }
}