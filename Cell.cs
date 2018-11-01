
namespace GameOfLife
{
    class Cell
    {
        //Property that determine the Cell is Alive or not
        public bool Alive { get; set; }

        //Coordinates of the cell
        public int X { get; set; }
        public int Y { get; set; }

        //Constructor that creates Alive Cell on given X and Y coordinates
        public Cell(int X, int Y)
            : this(X, Y, true) { }

        //Master constructor
        public Cell(int X, int Y, bool Alive)
        {
            this.X = X;
            this.Y = Y;
            this.Alive = Alive;
        }
    }
}
