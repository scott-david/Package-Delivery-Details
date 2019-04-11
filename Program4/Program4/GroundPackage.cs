using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage
    {
        private int _originzipcode; // origin zip code
        private int _destzipcode; // zip code for the destination
        private double _length; // length of package
        private double _width; // width of box
        private double _height; // height of package
        private double _weight; // weight of package
        const double specsDefault = 1.0; // constant to hold 1.0, in case user enters value <0

    // constructor
    //Precondition: origin and destination are >=00000 && <=99999
                    //length, width, height, weight are positive
    //Postcondition: a package has been constructed following these specifications
    public GroundPackage(int origin, int destination, double length, double width, double height, double weight)
        {
        OriginZip = origin;
        DestinationZip = destination;
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
        }
        // original zip code property
    public int OriginZip
    {// Precondition: none
     // Postcondtion: return origin zip code
        get
            {
                return _originzipcode;
            }
            // Precondition: value >=00000 && value <=99999
            // Postcondtion: origin zip set to specified value
        set
            {
            if (value >= 00000 && value <= 99999)
                _originzipcode = value;

            else
            {
               _originzipcode = 40202;
            }
        }
    }
        // Destination zip code property
    public int DestinationZip
        {// Precondition: none
         // Postcondtion: return destination zip code
            get
            {
                return _destzipcode;
            }
            // Precondition: value >=00000 && value <=99999
            // Postcondtion: destzipcode set to specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _destzipcode = value;
                else
                    _destzipcode = 90210;
            }
        }
      public double Length
        {// Precondition: none
         // Postcondtion: return length
            get
            {
                return _length;
            }
            // Precondition: value >=0
            // Postcondtion: length set to specified value
            set
            {
                if (value >= 0)
                    _length = value;
                else
                    _length = specsDefault;
            }
        }
        public double Width
        {// Precondition: none 
         // Postcondtion: return width
            get
            {
                return _width;
            }
            // Precondition: value >=0
            // Postcondtion: width set to specified value
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    _width = specsDefault;
            }
        }
        public double Height
        {// Precondition: none
         // Postcondtion: return height
            get
            {
                return _height;
            }
            // Precondition: value >= 0 
            // Postcondtion: height is set to specified value
            set
            {
                if (value >= 0)
                    _height = value;
                else
                    _height = specsDefault;
            }
        }
        public double Weight
        {// Precondition: none
         // Postcondtion: weight has been returned 
            get
            {
                return _weight;
            }
            // Precondition: value >= 0
            // Postcondtion: weight has been set to specified value
            set
            {
                if (value >= 0)
                    _weight = value;
                else
                    _weight = specsDefault;
            }
        }
        //read-only
        public int ZoneDistance
        {
            // Precondition: none
            // Postcondition: returns absolute value of the difference between (origin zip and dest zip)/10000
        get
            {
                return Math.Abs((_originzipcode / 10000) - (_destzipcode / 10000));
            }

        }
        //Preconditions: none
        //Postcontitions: must return a double
        public double CalcCost()
        {
            const double dimension = .20; // to hold the given number .20 from instructions
            const double weightFactor = .5; // to hold the given number from the instructions, .5
            double cost; // to hold the formula of the cost of package depending on its specifications
            cost = dimension * (Length + Width + Height) + (weightFactor*(ZoneDistance + 1) * (Weight));
            return cost;
        }
        //Preconditions:none 
        //Postconditons: must return a string, with package date on a separate line
        public override string ToString()
        {
            return "Origin: " + OriginZip + System.Environment.NewLine +
                "Destination: " + DestinationZip + System.Environment.NewLine +
                "Length: " + Length + System.Environment.NewLine +
                "Width: " + Width + System.Environment.NewLine +
                "Height: " + Height + System.Environment.NewLine +
                "Weight: " + Weight;
        }
    }

}
