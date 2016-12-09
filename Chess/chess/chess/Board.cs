using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{

    class Board
    {
        public int Size;
        public string[][] Grid;

        

        public Board(int size)
        {
            this.Size = size;
            this.Grid = new string[size][];
            for (int i=0; i < size; i++)
            {
                this.Grid[i] = new string[size];
            }
        }
        public void Fill()
        {
            for (int i=0; i<8; i++)
            {
                for (int j=0; j < 8; j++)
                {
                 
                    this.Grid[i][j] = " X";
                    
                    if (i < 6 && i > 1 )
                    {
                        this.Grid[i][j] = "  ";
                        
                    }
                    
                }
            }
            
        }
        public void Print()
        {
            foreach (string[] row in Grid)
            {
                System.Console.WriteLine();
                foreach (string stringValue in row)
                {
                    System.Console.Write(stringValue);
                }
            }
            }

            public void ddestination(int tx, int ty, int dx, int dy)
        {
            Grid[tx][ty] = Grid[dx][dy];
            Grid[tx][ty] = "  ";
            Grid[dx][dy] = " X";

        }
        public void Question()
        {
            System.Console.WriteLine("         ");
            System.Console.WriteLine("         ");
            System.Console.WriteLine("Enter a X coordinate between 0 to 7.");
            int TargetX = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter a Y Coordinate between 0 to 7.");
            int TargetY = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter Endpoint X coordinate between 0 to 7.");
            int DestinationX = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter Endpoint Y coordinate between 0 to 7.");
            int DestinationY = int.Parse(System.Console.ReadLine());


            ddestination(TargetX, TargetY, DestinationX, DestinationY);
            Console.Clear();

            while(true)
            {

                Print();
                Question();
                ddestination(TargetX, TargetY, DestinationX, DestinationY);
                Console.Clear();

            }

        }
    }
        
    
         }

    

