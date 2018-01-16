using System;

namespace Rover.Models
{
    public class RoverOperation
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Direction { get; set; }

        public RoverOperation(Plateau surface, string assignedPosition, string controllerInput)
        {
            ParseRoverPosition(assignedPosition);
            ControllerCommand(controllerInput);
        }


        public static class ControllerKey
        {
            public const string MoveForward = "M";
            public const string RotateLeft = "L";
            public const string RotateRight = "R";
        }

        public static class FacingDirection
        {
            public const string North = "N";
            public const string East = "E";
            public const string South = "S";
            public const string West = "W";
        }


        private void ParseRoverPosition(string assignedPosition)
        {
            string[] currentPosition = assignedPosition.Split(' ');

            this.XCoordinate = Convert.ToInt32(currentPosition[0]);
            this.YCoordinate = Convert.ToInt32(currentPosition[1]);
            this.Direction = currentPosition[2];
        }

        private void ControllerCommand(string controllerInput)
        {
            foreach (char inputValue in controllerInput.ToCharArray())
            {
                switch (inputValue.ToString())
                {
                    case ControllerKey.MoveForward:
                        this.MoveForward();
                        break;

                    default:
                        this.RotateRover(inputValue.ToString());
                        break;
                }
            }
        }



        public void MoveForward()
        {
            switch (this.Direction)
            {
                case FacingDirection.North:
                    this.YCoordinate += 1;
                    break;

                case FacingDirection.East:
                    this.XCoordinate += 1;
                    break;

                case FacingDirection.South:
                    this.YCoordinate -= 1;
                    break;

                case FacingDirection.West:
                    this.XCoordinate -= 1;
                    break;
            }
        }

        public void RotateRover(string direction)
        {
            switch (direction.ToUpper())
            {
                case ControllerKey.RotateLeft:
                    TurnRoverLeft();
                    break;

                case ControllerKey.RotateRight:
                    TurnRoverRight();
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private void TurnRoverLeft()
        {
            switch (this.Direction)
            {
                case FacingDirection.North:
                    this.Direction = FacingDirection.West;
                    break;

                case FacingDirection.West:
                    this.Direction = FacingDirection.South;
                    break;

                case FacingDirection.South:
                    this.Direction = FacingDirection.East;
                    break;

                case FacingDirection.East:
                    this.Direction = FacingDirection.North;
                    break;
            }
        }

        private void TurnRoverRight()
        {
            switch (this.Direction)
            {
                case FacingDirection.North:
                    this.Direction = FacingDirection.East;
                    break;

                case FacingDirection.East:
                    this.Direction = FacingDirection.South;
                    break;

                case FacingDirection.South:
                    this.Direction = FacingDirection.West;
                    break;

                case FacingDirection.West:
                    this.Direction = FacingDirection.North;
                    break;
            }
        }
    }
}