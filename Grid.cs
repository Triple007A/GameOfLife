using System;
using System.Collections.Generic;

namespace GameOfLife
{
    class Grid
    {
        //Array of Cells that creates the map
        private Cell[,] grid;

        //Fixed size of the grid (set in the constructor)
        public int sizeX { get; set; }
        public int sizeY { get; set; }

        public Grid(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;

            //Initialize the grid array with dead Cells
            grid = new Cell[sizeX, sizeY];
            for(int x = 0; x < sizeX; x++)
            {
                for(int y = 0; y < sizeY; y++)
                {
                    grid[x, y] = new Cell(x, y, false);
                }
            }
        }

        //Returns how many Alive cells surrounds given cell(on x, y coordinates)
        private byte cellNeighboursCount(int x, int y)
        {
            byte neighboursCount = 0;

            //We need to make sure that we are NOT refering to -1 row and -1 column
            //also we can't refer to size+1 row and size+1 column (ArrayOutOfBoundsException)
            
            //If the sourrounding cell is Alive we increment neighbours count
            if ((x > 0 && y > 0) && grid[x - 1,y - 1].Alive)
                neighboursCount++;
            if ((y > 0) && grid[x,y - 1].Alive)
                neighboursCount++;
            if ((y > 0 && x < sizeX-1) && grid[x + 1,y - 1].Alive)
                neighboursCount++;
            if ((x > 0) && grid[x - 1,y].Alive)
                neighboursCount++;
            if ((x < sizeX-1) && grid[x + 1,y].Alive)
                neighboursCount++;
            if ((x > 0 && y < sizeY-1) && grid[x - 1,y + 1].Alive)
                neighboursCount++;
            if ((y < sizeY-1) && grid[x,y + 1].Alive)
                neighboursCount++;
            if ((x < sizeX-1 && y < sizeY-1) && grid[x + 1,y + 1].Alive)
                neighboursCount++;

            return neighboursCount;
        }

        //Function that simulates the step in life of the ecosystem
        public void nextStep()
        {
            //Lists of cells to kill and cells to revive after all iterations
            List<Cell> dedCellsList = new List<Cell>();
            List<Cell> revivedCellsList = new List<Cell>();

            //We iterate through all cells
            for(int x = 0; x < sizeX; x++)
            {
                for(int y = 0; y < sizeY; y++)
                {
                    //Check how many neighbours have currect cell
                    byte neighboursCount = cellNeighboursCount(x, y);

                    //If currect cell is Alive
                    if(grid[x,y].Alive)
                    {
                        //and neighbours count is 1 or 0 the cell dies by underpopulation
                        //if there are more than 3 neighbours cell dies by overpopulation
                        if (neighboursCount == 1 || neighboursCount == 0 || neighboursCount > 3)
                            dedCellsList.Add(grid[x, y]);
                    }
                    else  //if current cell is Dead
                    {
                        //the cell sourounded by exactly 3 neighbours becomes alive by reproduction
                        if (neighboursCount == 3)
                            revivedCellsList.Add(grid[x, y]);
                    }
                }
            }

            //After all iterations we need to kill specific cells
            for (int i = 0; i < dedCellsList.Count; i++)
                grid[dedCellsList[i].X, dedCellsList[i].Y].Alive = false;

            //and revive cells that should become alive
            for (int i = 0; i < revivedCellsList.Count; i++)
                grid[revivedCellsList[i].X, revivedCellsList[i].Y].Alive = true;
        }

        //Function to add alive cell at given coordinates
        //Used to set the initial state of the ecosystem in main()
        public void addCellToMap(int x, int y)
        {
            grid[x, y].Alive = true;
        }

        //Displays the whole grid in Console
        public void printGrid()
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if(grid[x,y].Alive)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //Returns the count of alive cells in the whole ecosystem
        public int getAliveCellsCount()
        {
            int allive = 0;

            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if (grid[x, y].Alive)
                        allive++;
                }
            }

            return allive;
        }
    }
}
