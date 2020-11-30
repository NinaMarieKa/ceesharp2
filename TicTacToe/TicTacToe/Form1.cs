using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn, false Y turn
        int turn_count = 0;
        bool against_computer = false;
        //static String player1, player2;

        public Form1()
        {
            InitializeComponent();
        }
        /*
        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }
        */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Nina" + " Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((p1.Text == "Player 1") || (p2.Text == "Player 2"))
            {
                MessageBox.Show("You must specify the players name before you can start! \n Type Computer (for Player2)");
            }
            else
            {

                Button b = (Button)sender;
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";

                turn = !turn;
                b.Enabled = false;
                turn_count++;

                label2.Focus();
                checkForWinner();

            }
            if ((!turn) && (against_computer))
                {
                computer_make_move();
            }
        }

        private void computer_make_move()

        {
            // priority 1: get tic tac toe
            // prioroty 2: block x tic tac toe
            // priority 3: go for corner space
            // priority 4: pick open space

            Button move = null;

            // look for tic tac toe opportunities
            move = look_for_win_or_block("O"); // look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); // look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    } // end if
                } // end if
            } // end if

            move.PerformClick();

        }


        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                    return b;
                }// end if
            } //End if

            return null;

        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;

                if (C3.Text == "")
                    return C3;

                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;

                if (C3.Text == "")
                    return C3;

                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {

                if (A1.Text == "")
                    return A3;

                if (A3.Text == "")
                    return A3;

                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {

                if (A1.Text == "")
                    return A3;

                if (A3.Text == "")
                    return A3;

                if (C3.Text == "")
                    return C3;
            }


            if (A1.Text == "")
                return A1;

            if (A3.Text == "")
                return A3;

            if (C1.Text == "")
                return C1;

            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {

            Console.WriteLine("Looking for win or block:  " + mark);


            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;


            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

       

       


        // check to see if playing against computer and if it's O:s turn
         if((! turn) && (against_computer))
         {
            computer_make_move()
         }

    private void checkForWinner()
    {
        bool there_is_a_winner = false;

        // Horizontal checks
        if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            there_is_a_winner = true;
        else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            there_is_a_winner = true;

        // Vertical checks
        if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            there_is_a_winner = true;
        else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            there_is_a_winner = true;

        // Diagonal checks
        if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            there_is_a_winner = true;


        if (there_is_a_winner)
        {
            disableButtons();

            string winner = "";
            if (turn)
            {
                winner = p2.Text;
                o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
            }

            else
            {
                winner = p1.Text;
                x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
            }
            MessageBox.Show(winner + " Wins!", "Yay!");
            newGameToolStripMenuItem.PerformClick();
        } // end if
        else
        {
            if (turn_count == 9)
            {
                draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                MessageBox.Show(" Draw!", "Bummer!");
                newGameToolStripMenuItem.PerformClick();
            }
        }

    } // End checkForWinner

    private void disableButtons()
    {
        try
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            } //end foreach

        } //end try
        catch { }

    }

    private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        turn = true;
        turn_count = 0;



        foreach (Control c in Controls)
        {
            try
            {
                Button b = (Button)c;
                b.Enabled = true;
                b.Text = "";
            } //end try
            catch { }
        }// end foreach
    }

    private void button_enter(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        if (b.Enabled)
        {
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
        }// end if
    }

    private void button_leave(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        if (b.Enabled)
        {
            b.Text = "";
        }
    }

    private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        o_win_count.Text = "0";
        x_win_count.Text = "0";
        draw_count.Text = "0";

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        /* Form2 f2 = new Form2();
         f2.ShowDialog();
         label1.Text = player1;
         label3.Text = player2; */

        setPlayerDefaultsToolStripMenuItem.PerformClick();
    }

    private void p2_TextChanged(object sender, EventArgs e)
    {
        if (p2.Text.ToUpper() == "COMPUTER")
            against_computer = true;
        else
            against_computer = false;

    }

    private void setPlayerDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        p1.Text = "Nina";
        p2.Text = "Computer";
    }
}

    

