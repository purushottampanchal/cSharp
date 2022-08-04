using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Constructor
{
    internal class Building
    {
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string Dimension { get; set; }
        public string DateOfCompletion { get; set; }
        public int FloorNumber { get; set; }
        public string LandDimesion { get; set; }

        //if flat then this constr
        public Building(
            string type,
            string capacity,
            string dimension,
            string dateOfCompletion,
            int floorNumber)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimension;
            DateOfCompletion = dateOfCompletion;
            FloorNumber = floorNumber;
            LandDimesion = null;
        }


        //if Villa then this constr
        public Building(
            string type,
            string capacity,
            string dimension,
            string dateOfCompletion,
            string landDimesion)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimension;
            DateOfCompletion = dateOfCompletion;
            LandDimesion = landDimesion;
        }



        public void showData()
        {

            string str2 = 
                LandDimesion == null ? "\nFloor Number: "+FloorNumber : "\nLand Dimension"+LandDimesion;
                
            string str = "---------------------------" +
                "\nType: " +
                "\nCapacity: " +
                "\nDimensions: " +
                "\nDate of Completions: " +
                str2;

        }
    }
}
