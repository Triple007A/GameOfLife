using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static int gridSizeX = 57;
        static int gridSizeY = 57;

        //New grid, 57x57 cells
        static Grid grid = new Grid(gridSizeX, gridSizeY);

        static void Main(string[] args)
        {
            //Simple choice variables to use in switch()
            byte mainMenuChoice = 0;
            byte subMenuChoice = 0;

            //do-while loop to print and handle the menu
            do
            {
                //Print Main Menu
                DrawMenu();

                //Get the user choice
                Console.Write("Choice: ");
                mainMenuChoice = Convert.ToByte(Console.ReadLine());

                switch(mainMenuChoice)
                {
                    case 1: //1. Add Pattern case
                        //Prints Patterns list
                        DrawPatternsMenu();

                        //Get the user choice
                        Console.Write("Choice: ");
                        subMenuChoice = Convert.ToByte(Console.ReadLine());

                        //Variables for pattern coordinates
                        int x, y;

                        //Print warning
                        Console.WriteLine("WARNING: X and Y can't be greater than: X:{0}, y:{1}",
                            gridSizeX, gridSizeY);

                        //Get the coordinates for chosen pattern
                        Console.Write("Coordinate X=");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Coordinate Y=");
                        y = Convert.ToInt32(Console.ReadLine());

                        //Based on user choice we are adding selected Pattern on given coordinates
                        switch (subMenuChoice)
                        {
                            case 1:
                                Patterns.Block(grid, x, y);
                                break;
                            case 2:
                                Patterns.Beehive(grid, x, y);
                                break;
                            case 3:
                                Patterns.Loaf(grid, x, y);
                                break;
                            case 4:
                                Patterns.Boat(grid, x, y);
                                break;
                            case 5:
                                Patterns.Blinker(grid, x, y);
                                break;
                            case 6:
                                Patterns.Beacon(grid, x, y);
                                break;
                            case 7:
                                Patterns.Pulsar(grid, x, y);
                                break;
                            case 8:
                                Patterns.Pentadecathlon(grid, x, y);
                                break;
                            case 9:
                                Patterns.LightweightSpaceship(grid, x, y);
                                break;
                            case 10:
                                Patterns.R_pentomino(grid, x, y);
                                break;
                            case 11:
                                Patterns.Diehard(grid, x, y);
                                break;
                            case 12:
                                Patterns.Acorn(grid, x, y);
                                break;
                            default:
                                Console.WriteLine("Wrong number!");
                                break;
                        }
                        break;
                    case 2:
                        StartSimulation(grid);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }

            } while (mainMenuChoice != 3);
        }

        //Function with infinite loop that starts the simulation, breaks only if there are no Cells Alive
        static void StartSimulation(Grid grid)
        {
            while (true)
            {
                //Printing grid with all cells
                grid.printGrid();

                //If there are no Alive Cells, we break from infinite loop
                if (grid.getAliveCellsCount() <= 0)
                    break;

                //Wait for 30ms so we can see the step result
                Thread.Sleep(30);

                //Clear console window
                Console.Clear();

                //Simulate the next step
                grid.nextStep();
            }
        }

        static void DrawHeader()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("****     GAME OF LIFE    ****");
            Console.WriteLine("**** Arkadiusz Kowalczyk ****");
            Console.WriteLine("*****************************");
        }

        //Simple Main Menu
        static void DrawMenu()
        {
            Console.Clear();

            DrawHeader();
            Console.WriteLine();
            Console.WriteLine("1. Add Pattern");
            Console.WriteLine("2. Start simulation");
            Console.WriteLine("3. Exit");
        }

        //Patterns menu
        static void DrawPatternsMenu()
        {
            Console.Clear();

            DrawHeader();

            Console.WriteLine("1. Block");
            Console.WriteLine("2. Beehive");
            Console.WriteLine("3. Loaf");
            Console.WriteLine("4. Boat");
            Console.WriteLine("5. Blinker");
            Console.WriteLine("6. Toad");
            Console.WriteLine("6. Beacon");
            Console.WriteLine("7. Pulsar");
            Console.WriteLine("8. Pentadecathlon");
            Console.WriteLine("9. Lightweight Spaceship");
            Console.WriteLine("10. R-pentomino");
            Console.WriteLine("11. Diehard");
            Console.WriteLine("12. Acorn");
        }
    }
}
