
namespace GameOfLife
{
    static class Patterns
    {
        public static void Block(Grid grid, int x, int y)
        {
            if((x < grid.sizeX - 2) && (y < grid.sizeY - 2))
            {
                grid.addCellToMap(x, y);
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 1, y + 1);
                grid.addCellToMap(x, y + 1);
            }
        }

        public static void Beehive(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 4) && (y < grid.sizeY - 3))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 3, y + 1);
                grid.addCellToMap(x + 1, y + 2);
                grid.addCellToMap(x + 2, y + 2);
            }
        }

        public static void Loaf(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 3) && (y < grid.sizeY - 3))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 3, y + 1);
                grid.addCellToMap(x + 1, y + 2);
                grid.addCellToMap(x + 3, y + 2);
                grid.addCellToMap(x + 2, y + 3);

            }
        }

        public static void Boat(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 2) && (y < grid.sizeY - 2))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 2, y + 1);
                grid.addCellToMap(x + 1, y + 2);
            }
        }

        public static void Blinker(Grid grid, int x, int y)
        {
            if (x < grid.sizeX - 3)
            {
                grid.addCellToMap(x, y);
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);
            }
        }

        public static void Toad(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 3) && (y < grid.sizeY - 1))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);
                grid.addCellToMap(x + 3, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 1, y + 1);
                grid.addCellToMap(x + 2, y + 1);
            }
        }

        public static void Beacon(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 3) && (y < grid.sizeY - 3))
            {
                grid.addCellToMap(x, y);
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 1, y + 1);
                grid.addCellToMap(x + 2, y + 2);
                grid.addCellToMap(x + 3, y + 2);
                grid.addCellToMap(x + 2, y + 3);
                grid.addCellToMap(x + 3, y + 3);
            }
        }

        public static void Pulsar(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 12) && (y < grid.sizeY - 12))
            {
                //Horizontal lines
                grid.addCellToMap(x + 2, y);
                grid.addCellToMap(x + 3, y);
                grid.addCellToMap(x + 4, y);

                grid.addCellToMap(x + 8, y);
                grid.addCellToMap(x + 9, y);
                grid.addCellToMap(x + 10, y);

                grid.addCellToMap(x + 2, y + 5);
                grid.addCellToMap(x + 3, y + 5);
                grid.addCellToMap(x + 4, y + 5);

                grid.addCellToMap(x + 8, y + 5);
                grid.addCellToMap(x + 9, y + 5);
                grid.addCellToMap(x + 10, y + 5);

                grid.addCellToMap(x + 2, y + 7);
                grid.addCellToMap(x + 3, y + 7);
                grid.addCellToMap(x + 4, y + 7);

                grid.addCellToMap(x + 8, y + 7);
                grid.addCellToMap(x + 9, y + 7);
                grid.addCellToMap(x + 10, y + 7);

                grid.addCellToMap(x + 2, y + 12);
                grid.addCellToMap(x + 3, y + 12);
                grid.addCellToMap(x + 4, y + 12);

                grid.addCellToMap(x + 8, y + 12);
                grid.addCellToMap(x + 9, y + 12);
                grid.addCellToMap(x + 10, y + 12);

                //Vertical lines
                grid.addCellToMap(x, y + 2);
                grid.addCellToMap(x, y + 3);
                grid.addCellToMap(x, y + 4);

                grid.addCellToMap(x, y + 8);
                grid.addCellToMap(x, y + 9);
                grid.addCellToMap(x, y + 10);

                grid.addCellToMap(x + 5, y + 2);
                grid.addCellToMap(x + 5, y + 3);
                grid.addCellToMap(x + 5, y + 4);

                grid.addCellToMap(x + 5, y + 8);
                grid.addCellToMap(x + 5, y + 9);
                grid.addCellToMap(x + 5, y + 10);

                grid.addCellToMap(x + 7, y + 2);
                grid.addCellToMap(x + 7, y + 3);
                grid.addCellToMap(x + 7, y + 4);

                grid.addCellToMap(x + 7, y + 8);
                grid.addCellToMap(x + 7, y + 9);
                grid.addCellToMap(x + 7, y + 10);

                grid.addCellToMap(x + 12, y + 2);
                grid.addCellToMap(x + 12, y + 3);
                grid.addCellToMap(x + 12, y + 4);

                grid.addCellToMap(x + 12, y + 8);
                grid.addCellToMap(x + 12, y + 9);
                grid.addCellToMap(x + 12, y + 10);
            }
        }

        public static void Pentadecathlon(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 2) && (y < grid.sizeY - 7))
            {
                grid.addCellToMap(x, y);
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);

                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 2, y + 1);

                grid.addCellToMap(x, y + 2);
                grid.addCellToMap(x + 1, y + 2);
                grid.addCellToMap(x + 2, y + 2);

                grid.addCellToMap(x, y + 3);
                grid.addCellToMap(x + 1, y + 3);
                grid.addCellToMap(x + 2, y + 3);

                grid.addCellToMap(x, y + 4);
                grid.addCellToMap(x + 1, y + 4);
                grid.addCellToMap(x + 2, y + 4);

                grid.addCellToMap(x, y + 5);
                grid.addCellToMap(x + 1, y + 5);
                grid.addCellToMap(x + 2, y + 5);

                grid.addCellToMap(x, y + 6);
                grid.addCellToMap(x + 2, y + 6);

                grid.addCellToMap(x, y + 7);
                grid.addCellToMap(x + 1, y + 7);
                grid.addCellToMap(x + 2, y + 7);

            }
        }

        public static void LightweightSpaceship(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 4) && (y < grid.sizeY - 3))
            {
                grid.addCellToMap(x, y);
                grid.addCellToMap(x + 3, y);
                grid.addCellToMap(x + 4, y + 1);
                grid.addCellToMap(x, y + 2);
                grid.addCellToMap(x + 4, y + 2);
                grid.addCellToMap(x + 1, y + 3);
                grid.addCellToMap(x + 2, y + 3);
                grid.addCellToMap(x + 3, y + 3);
                grid.addCellToMap(x + 4, y + 3);
            }
        }

        public static void R_pentomino(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 2) && (y < grid.sizeY - 2))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 2, y);

                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 1, y + 1);

                grid.addCellToMap(x + 1, y + 2);
            }
        }

        public static void Diehard(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 7) && (y < grid.sizeY - 2))
            {
                grid.addCellToMap(x + 6, y);
                grid.addCellToMap(x, y + 1);
                grid.addCellToMap(x + 1, y + 1);
                grid.addCellToMap(x + 1, y + 2);
                grid.addCellToMap(x + 5, y + 2);
                grid.addCellToMap(x + 6, y + 2);
                grid.addCellToMap(x + 7, y + 2);
            }
        }

        public static void Acorn(Grid grid, int x, int y)
        {
            if ((x < grid.sizeX - 6) && (y < grid.sizeY - 2))
            {
                grid.addCellToMap(x + 1, y);
                grid.addCellToMap(x + 3, y + 1);
                grid.addCellToMap(x, y + 2);
                grid.addCellToMap(x + 1, y + 2);
                grid.addCellToMap(x + 4, y + 2);
                grid.addCellToMap(x + 5, y + 2);
                grid.addCellToMap(x + 6, y + 2);
            }
        }
    }
}
