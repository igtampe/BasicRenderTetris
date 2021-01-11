using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igtampe.BasicRender;

namespace Igtampe.Tetris {
    class Board {

        int score;
        int linesCleared;

        /// <summary>16x10 array of booleans that will hold the playing field</summary>
        public bool[,] BoardArray { get; private set; }

        /// <summary>Creates the board</summary>
        public Board() { 
            BoardArray= new bool[16,10];
            ResetBoard();
        }

        /// <summary>Resets the board. Everything is now false</summary>
        public void ResetBoard() {for(int i = 0; i < 16; i++) {for(int j = 0; j < 10; j++) {BoardArray[i,j] = false;}}}

        /// <summary>Draws the board </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Render(int x,int y) { 
            
            //Tick the board


        }




    }
}
