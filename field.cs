using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crestic
{
    class Coord
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Field
    {
       public byte[,] field = new byte[3,3]; //оказывается оно изначально зануляется

        public void Print() {
          for(int i = 0; i < 3; i++)
          {
                for (int j = 0; j < 3; j++)
                {
                    switch (field[i, j])
                    {
                        case 0: Console.Write("# ");
                            break;
                        case 1: Console.Write("X ");
                            break;
                        case 2: Console.Write("O ");
                            break;
                    }
                    
                }
                Console.WriteLine();
            }
        }

    }
}
