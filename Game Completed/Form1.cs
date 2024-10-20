using System;
using System.Windows.Forms;

namespace Game_Completed
{
    public partial class Form1 : Form
    {
        private bool isPlayer1Turn = true;
        private Button[,] buttons = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            ResetGame();
        }

        private void InitializeButtons()
        {
            buttons[0, 0] = btn1;
            buttons[0, 1] = btn2;
            buttons[0, 2] = btn3;
            buttons[1, 0] = btn4;
            buttons[1, 1] = btn5;
            buttons[1, 2] = btn6;
            buttons[2, 0] = btn7;
            buttons[2, 1] = btn8;
            buttons[2, 2] = btn9;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var button = buttons[row, col];
                    button.Click += Button_Click;

                    if ((row + col) % 2 == 0)
                    {
                        button.BackColor = Color.LightGray;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == "")
            {
                button.Text = isPlayer1Turn ? "X" : "O";
                button.Enabled = false;

                if (CheckForWinner())
                {
                    MessageBox.Show($"Player {(isPlayer1Turn ? "1 (X)" : "2 (O)")} wins!");
                    ResetGame();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("It's a draw!");
                    ResetGame();
                }
                else
                {
                    isPlayer1Turn = !isPlayer1Turn;
                    lblTurn.Text = $"Current Turn: Player {(isPlayer1Turn ? "1 (X)" : "2 (O)")}";
                }
            }
        }

        private bool CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text && buttons[i, 0].Text != "") || 
                    (buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text && buttons[0, i].Text != "")) 
                {
                    return true;
                }
            }
            if ((buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "") ||
                (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text && buttons[0, 2].Text != ""))
            {
                return true;
            }
            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var button in buttons)
            {
                if (button.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void ResetGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            isPlayer1Turn = true;
            lblTurn.Text = "Current Turn: Player 1 (X)";
        }

    }
}
