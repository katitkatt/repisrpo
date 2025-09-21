
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public class Painter
    {
        private const int GridPadding = 5;

        public void DrawGrid(Panel panel, GameBoard board)
        {
            panel.Controls.Clear();
            int cellSize = CalculateCellSize(board.GridSize);
            int fontSize = CalculateFontSize(board.GridSize);

            for (int i = 0; i < board.GridSize; i++)
            {
                for (int j = 0; j < board.GridSize; j++)
                {
                    var label = new Label
                    {
                        Text = board.Grid[i, j] > 0 ? board.Grid[i, j].ToString() : "",
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(
                            GridPadding + j * (cellSize + GridPadding),
                            GridPadding + i * (cellSize + GridPadding)),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Comic Sans", fontSize, FontStyle.Bold),
                        BackColor = GetTileColor(board.Grid[i, j])
                    };
                    panel.Controls.Add(label);
                }
            }
        }

        private int CalculateCellSize(int gridSize) => gridSize == 4 ? 69 : 32;
        private int CalculateFontSize(int gridSize) => gridSize == 4 ? 14 : 7;

        private Color GetTileColor(int value)
        {
            switch (value)
            {
                case 2: return Color.MistyRose;
                case 4: return Color.Pink;
                case 8: return Color.Salmon;
                case 16: return Color.PaleVioletRed;
                case 32: return Color.Plum;
                case 64: return Color.Violet;
                case 128: return Color.MediumPurple;
                case 256: return Color.LimeGreen;
                case 512: return Color.MediumSlateBlue;
                case 1024: return Color.BlueViolet;
                case 2048: return Color.Indigo;
                default: return Color.WhiteSmoke;
            }
        }
    }
}
