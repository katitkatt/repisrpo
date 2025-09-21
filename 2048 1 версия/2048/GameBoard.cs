using System;
using System.Collections.Generic;
using System.Drawing;


namespace _2048
{
    public class GameBoard
    {
        public int[,] Grid { get; private set; }
        public int GridSize { get; }
        private readonly Random random = new Random();

        public GameBoard(int size = 4)
        {
            GridSize = size;
            Grid = new int[GridSize, GridSize];
        }

        public void Initialize()
        {
            Grid = new int[GridSize, GridSize];
        }

        public void AddRandomTile()
        {
            var emptyCells = new List<Point>();

            for (int i = 0; i < GridSize; i++)
                for (int j = 0; j < GridSize; j++)
                    if (Grid[i, j] == 0)
                        emptyCells.Add(new Point(i, j));

            if (emptyCells.Count > 0)
            {
                var cell = emptyCells[random.Next(emptyCells.Count)];
                Grid[cell.X, cell.Y] = 2;
            }
        }
    }
}
