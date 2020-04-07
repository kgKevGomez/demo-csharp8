namespace DemoApp.Topics
{
    public class PatternMatching
    {
        /*//No pattern matching, no OOP
        public static double ComputeArea(object shape)
        {
            if (shape.GetType() == typeof(Square))
            {
                var s = (Square)shape;
                return s.Side * s.Side;
            } 
            else if (shape.GetType() == typeof(Circle))
            {
                var c = (Circle)shape;
                return c.Radius * c.Radius * Math.PI;
            }
            
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }*/
        
        /*//Is pattern matching
        public static double ComputeAreaModernIs(object shape)
        {
            if (shape is Square s)
                return s.Side * s.Side;
            else if (shape is Circle c)
                return c.Radius * c.Radius * Math.PI;
            else if (shape is Rectangle r)
                return r.Height * r.Length;
            
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
            //Also now, switch supports type pattern matching
        }*/
         
        /*// Switch expression
        public static int GetPriorityLevel(Light light)
        {
            switch (light)
            {
                case Light.Red: //Only constant pattern matching (Compile time)
                    return 1;
                case Light.Orange:
                    return 2;
                case Light.Yellow:
                    return 3;
                case Light.Green:
                    return 4;
                case Light.Blue:
                case Light.Indigo:
                    return 5;
                case Light.Violet:
                    return 6;
                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(light));
            }
        }*/

        /*//Property patterns
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { TaxParadise: true} => 0,
                { Country: "NL" } when location.Code > 0 => salePrice * 0.50M,
                { Country: "BE" } => salePrice * 0.25M,
                { Country: "SV" } => salePrice * 0.13M,
                _ => throw new NotImplementedException("Missing tax setup")
            };*/
    }
    
    #region Helper classes
    #nullable disable
    public class Address
    {
        public string Country { get; set; }
        public bool TaxParadise { get; set; }
        public int Code { get; set; }
    }
    #nullable restore
    
    public enum Light
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }
    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public struct Rectangle
    {
        public double Length { get; }
        public double Height { get; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    public class Triangle
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
    #endregion
}