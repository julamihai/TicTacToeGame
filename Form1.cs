using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] GameBoard = new string[9];
        int currentturn = 0;

        public string ReturnSymbol(int turn)
        {
            //will return X or O
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void Winner()
        {
            //searching for the winner
            for (int i = 0; i < 9; i++)
            {
                string combination = "";
                int counter = 0;

                switch (i)
                {
                    case 0:
                        combination = GameBoard[0] + GameBoard[4] + GameBoard[8];
                        break;
                    case 1:
                        combination = GameBoard[2] + GameBoard[4] + GameBoard[6];
                        break;
                    case 2:
                        combination = GameBoard[0] + GameBoard[3] + GameBoard[6];
                        break;
                    case 3:
                        combination = GameBoard[1] + GameBoard[4] + GameBoard[7];
                        break;
                    case 4:
                        combination = GameBoard[2] + GameBoard[5] + GameBoard[8];
                        break;
                    case 5:
                        combination = GameBoard[0] + GameBoard[1] + GameBoard[2];
                        break;
                    case 6:
                        combination = GameBoard[3] + GameBoard[4] + GameBoard[5];
                        break;
                    case 7:
                        combination = GameBoard[6] + GameBoard[7] + GameBoard[8];
                        break;
                }
                
                //draw method
                for (int j = 0; j < GameBoard.Length; j++)
                {
                    if (GameBoard[j] != null)
                    {
                        counter++;
                    }
                    if (counter == 9 && combination == "OOO")
                    {
                        MessageBox.Show("O has won the game!", "We have a winner!");
                        break;
                    }
                    else if (counter == 9 && combination == "XXX")
                    {
                        MessageBox.Show("X has won the game!", "We have a winner!");
                        break;
                    }
                    else if (counter == 9 && combination != "OOO")
                    {
                        MessageBox.Show("We have a draw!", "Draw");
                        break;
                    }
                    else if (counter == 9 && combination != "XXX")
                    {
                        MessageBox.Show("We have a draw!", "Draw");
                        break;
                    }
                }
                
                if (combination == "OOO")
                {
                    MessageBox.Show("O has won the game!", "We have a winner!");
                    break;
                }
                else if (combination == "XXX")
                {
                    MessageBox.Show("X has won the game!", "We have a winner!");
                    break;

                }
            }
        }

        public void Restart()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            GameBoard = new string[9];
            currentturn = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[0] = ReturnSymbol(currentturn);
            button1.Text = GameBoard[0];
            Winner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[1] = ReturnSymbol(currentturn);
            button2.Text = GameBoard[1];
            Winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[2] = ReturnSymbol(currentturn);
            button3.Text = GameBoard[2];
            Winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[3] = ReturnSymbol(currentturn);
            button4.Text = GameBoard[3];
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[4] = ReturnSymbol(currentturn);
            button5.Text = GameBoard[4];
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[5] = ReturnSymbol(currentturn);
            button6.Text = GameBoard[5];
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[6] = ReturnSymbol(currentturn);
            button7.Text = GameBoard[6];
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[7] = ReturnSymbol(currentturn);
            button8.Text = GameBoard[7];
            Winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentturn++;
            GameBoard[8] = ReturnSymbol(currentturn);
            button9.Text = GameBoard[8];
            Winner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}