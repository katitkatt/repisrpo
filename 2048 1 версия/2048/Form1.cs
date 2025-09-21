using System;
using System.Reflection;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        private GameBoard gameBoard;
        private GameLogic gameLogic;
        private Painter tileRenderer;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            SetupForm();
        }

        private void InitializeGame()
        {
            gameBoard = new GameBoard(4);
            gameLogic = new GameLogic(gameBoard);
            tileRenderer = new Painter();

            gameBoard.Initialize();
            gameBoard.AddRandomTile();
            gameBoard.AddRandomTile();

            tileRenderer.DrawGrid(panel1, gameBoard);
        }

        private void SetupForm()
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            radioButton1.Checked = true;
            radioButton1.TabStop = false;
            radioButton2.TabStop = false;
            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                panel1,
                new object[] { true });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool moved = false;

            switch (e.KeyCode)
            {
                case Keys.Left: moved = gameLogic.MoveLeft(); break;
                case Keys.Right: moved = gameLogic.MoveRight(); break;
                case Keys.Up: moved = gameLogic.MoveUp(); break;
                case Keys.Down: moved = gameLogic.MoveDown(); break;
            }

            if (moved)
            {
                gameBoard.AddRandomTile();
                tileRenderer.DrawGrid(panel1, gameBoard);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gameBoard = new GameBoard(4);
                gameLogic = new GameLogic(gameBoard);
                InitializeGame();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                gameBoard = new GameBoard(8);
                gameLogic = new GameLogic(gameBoard);
                InitializeGame();
            }
        }
    }
}
