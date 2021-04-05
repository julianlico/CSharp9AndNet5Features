using System;

namespace Net5FeaturesTest
{
    public class SwitchExamples
    {
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static Orientation GetOrientation()
        {
            var direction = Directions.Right;

            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Right => Orientation.East,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
                _ => throw new Exception("You code in something else I don't recognize."),
            };

            return orientation;
        }

        public static decimal GetFuelCost(GasPrice price) => price.MaxPrice switch
        {
            1 or 2 => 1.00m,
            < 1000 and < 5000 => 10.00m,
            <= 10000 => 7.00m,
            _ => 12.00m
        };
    }

    public record GasPrice(int MinPrice, int MaxPrice);
}
