using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessin
{
    internal class Board
    {
        public readonly int width = 8;
        public readonly int height = 8;
        public GridValue[,] Grid;

        public Board()
        {
            Grid = new GridValue[width, height];
        }

        public void SetupBoard()
        {
            Grid[0,0] = GridValue.BLACK_ROOK; 
            Grid[0,1] = GridValue.BLACK_KNIGHT; 
            Grid[0,2] = GridValue.BLACK_BISHOP; 
            Grid[0,3] = GridValue.BLACK_QUEEN; 
            Grid[0,4] = GridValue.BLACK_KING; 
            Grid[0,5] = GridValue.BLACK_BISHOP; 
            Grid[0,6] = GridValue.BLACK_KNIGHT; 
            Grid[0,7] = GridValue.BLACK_ROOK;
            for (int i = 0; i < width; i++)
            {
                Grid[1,i] = GridValue.BLACK_PAWN;
            }

            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Grid[i,j] = GridValue.EMPTY;
                }
            }
            
            

            Grid[6, 0] = GridValue.WHITE_ROOK;
            Grid[6, 1] = GridValue.WHITE_KNIGHT;
            Grid[6, 2] = GridValue.WHITE_BISHOP;
            Grid[6, 3] = GridValue.WHITE_QUEEN;
            Grid[6, 4] = GridValue.WHITE_KING;
            Grid[6, 5] = GridValue.WHITE_BISHOP;
            Grid[6, 6] = GridValue.WHITE_KNIGHT;
            Grid[6, 7] = GridValue.WHITE_ROOK;
            for (int i = 0; i < width; i++)
            {
                Grid[7, i] = GridValue.WHITE_PAWN;
            }

        }
    }
}
