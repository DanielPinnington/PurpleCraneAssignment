using System;

namespace PurpleCraneAssignment
{
    public class Hoover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        public bool SuctionOn { get; set; }

        private int maxX;
        private int maxY;

        public Hoover(int x, int y, Direction direction, int maxX, int maxY)
        {
            X = x;
            Y = y;
            Direction = direction;
            SuctionOn = false; // Starts off
            this.maxX = maxX;
            this.maxY = maxY;
        }

        public void ProcessCommand(char command)
        {
            switch (char.ToUpper(command))
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
                case 'S':
                    SuctionOn = !SuctionOn;
                    break;
                default:
                    Console.WriteLine($"Invalid command: {command}");
                    break;
            }
        }

        private void TurnLeft()
        {
            SuctionOn = false;
            Direction = Direction switch
            {
                Direction.North => Direction.West,
                Direction.West => Direction.South,
                Direction.South => Direction.East,
                Direction.East => Direction.North,
                _ => Direction
            };
        }

        private void TurnRight()
        {
            SuctionOn = false;
            Direction = Direction switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => Direction
            };
        }

        private void Move()
        {
            switch (Direction)
            {
                case Direction.North:
                    if (Y < maxY) Y++;
                    break;
                case Direction.East:
                    if (X < maxX) X++;
                    break;
                case Direction.South:
                    if (Y > 0) Y--;
                    break;
                case Direction.West:
                    if (X > 0) X--;
                    break;
            }
        }

        public override string ToString()
        {
            string dirStr = Direction switch
            {
                Direction.North => "N",
                Direction.East => "E",
                Direction.South => "S",
                Direction.West => "W",
                _ => "?"
            };

            return $"{X} {Y} {dirStr}, S={(SuctionOn ? "On" : "Off")}";
        }
    }
}
