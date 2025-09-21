

namespace _2048
{
    public class GameLogic
    {
        private readonly GameBoard board;

        public GameLogic(GameBoard gameBoard)
        {
            board = gameBoard;
        }

        public bool MoveLeft()
        {
            bool moved = false;
            int size = board.GridSize;

            for (int row = 0; row < size; row++)
            {
                for (int col = 1; col < size; col++)
                {
                    if (board.Grid[row, col] == 0) continue;

                    int newCol = col;
                    while (newCol > 0 && board.Grid[row, newCol - 1] == 0)
                    {
                        board.Grid[row, newCol - 1] = board.Grid[row, newCol];
                        board.Grid[row, newCol] = 0;
                        newCol--;
                        moved = true;
                    }

                    if (newCol > 0 && board.Grid[row, newCol - 1] == board.Grid[row, newCol])
                    {
                        board.Grid[row, newCol - 1] *= 2;
                        board.Grid[row, newCol] = 0;
                        moved = true;
                    }
                }
            }
            return moved;
        }

        public bool MoveRight()
        {
            bool moved = false;
            int size = board.GridSize;

            for (int row = 0; row < size; row++)
            {
                for (int col = size - 2; col >= 0; col--)
                {
                    if (board.Grid[row, col] == 0) continue;

                    int newCol = col;
                    while (newCol < size - 1 && board.Grid[row, newCol + 1] == 0)
                    {
                        board.Grid[row, newCol + 1] = board.Grid[row, newCol];
                        board.Grid[row, newCol] = 0;
                        newCol++;
                        moved = true;
                    }

                    if (newCol < size - 1 && board.Grid[row, newCol + 1] == board.Grid[row, newCol])
                    {
                        board.Grid[row, newCol + 1] *= 2;
                        board.Grid[row, newCol] = 0;
                        moved = true;
                    }
                }
            }
            return moved;
        }

        public bool MoveUp()
        {
            bool moved = false;
            int size = board.GridSize;

            for (int col = 0; col < size; col++)
            {
                for (int row = 1; row < size; row++)
                {
                    if (board.Grid[row, col] == 0) continue;

                    int newRow = row;
                    while (newRow > 0 && board.Grid[newRow - 1, col] == 0)
                    {
                        board.Grid[newRow - 1, col] = board.Grid[newRow, col];
                        board.Grid[newRow, col] = 0;
                        newRow--;
                        moved = true;
                    }

                    if (newRow > 0 && board.Grid[newRow - 1, col] == board.Grid[newRow, col])
                    {
                        board.Grid[newRow - 1, col] *= 2;
                        board.Grid[newRow, col] = 0;
                        moved = true;
                    }
                }
            }
            return moved;
        }

        public bool MoveDown()
        {
            bool moved = false;
            int size = board.GridSize;

            for (int col = 0; col < size; col++)
            {
                for (int row = size - 2; row >= 0; row--)
                {
                    if (board.Grid[row, col] == 0) continue;

                    int newRow = row;
                    while (newRow < size - 1 && board.Grid[newRow + 1, col] == 0)
                    {
                        board.Grid[newRow + 1, col] = board.Grid[newRow, col];
                        board.Grid[newRow, col] = 0;
                        newRow++;
                        moved = true;
                    }

                    if (newRow < size - 1 && board.Grid[newRow + 1, col] == board.Grid[newRow, col])
                    {
                        board.Grid[newRow + 1, col] *= 2;
                        board.Grid[newRow, col] = 0;
                        moved = true;
                    }
                }
            }
            return moved;
        }

    }
}
