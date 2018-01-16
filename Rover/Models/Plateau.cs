namespace Rover.Models
{
    public class Plateau
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Plateau(int width, int height)
        {
            Height = height;
            Width = width;
        }
    }
}
