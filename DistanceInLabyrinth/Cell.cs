using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceInLabyrinth
{
    public class Cell
    {
        public Cell( int row, int col, bool isVisited, int moves)
        {
            this.Row = row;
            this.Col = col;
            this.IsVisited = isVisited;
            this.Moves = moves;
        }
        public int Row { get; set; }
        public int Col { get; set; }

        public bool IsVisited { get; set; }

        public int Moves { get; set; }
    }
}
