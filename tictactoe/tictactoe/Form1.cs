using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        int control = 1;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            btnA1.Text = "";
            btnA1.Enabled = false;
            btnA2.Text = "";
            btnA2.Enabled = false;
            btnA3.Text = "";
            btnA3.Enabled = false;

            btnB1.Text = "";
            btnB1.Enabled = false;
            btnB2.Text = "";
            btnB2.Enabled = false;
            btnB3.Text = "";
            btnB3.Enabled = false;

            btnC1.Text = "";
            btnC1.Enabled = false;
            btnC2.Text = "";
            btnC2.Enabled = false;
            btnC3.Text = "";
            btnC3.Enabled = false;

            btnReset.Enabled = false;

            btnA11.Enabled = false;
            btnA22.Enabled = false;
            btnA33.Enabled = false;

            btnB11.Enabled = false;
            btnB22.Enabled = false;
            btnB33.Enabled = false;

            btnC11.Enabled = false;
            btnC22.Enabled = false;
            btnC33.Enabled = false;

            btnReset1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            control = 1;

            btnA1.Text = "";
            btnA1.Enabled = true;
            btnA2.Text = "";
            btnA2.Enabled = true;
            btnA3.Text = "";
            btnA3.Enabled = true;

            btnB1.Text = "";
            btnB1.Enabled = true;
            btnB2.Text = "";
            btnB2.Enabled = true;
            btnB3.Text = "";
            btnB3.Enabled = true;

            btnC1.Text = "";
            btnC1.Enabled = true;
            btnC2.Text = "";
            btnC2.Enabled = true;
            btnC3.Text = "";
            btnC3.Enabled = true;
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnA1.Text = "X";
                btnA1.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnA1.Text = "O";
                btnA1.Enabled = false;
            }

            control = control + 1;

            


        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnA2.Text = "X";
                btnA2.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnA2.Text = "O";
                btnA2.Enabled = false;
            }

            control = control + 1;

            if ((btnA2.Text == btnA1.Text) & (btnA2.Text == btnA3.Text))
            {
                if (btnA2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA2.Text == btnB2.Text) & (btnB2.Text == btnC2.Text))
            {
                if (btnA2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnA3.Text = "X";
                btnA3.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnA3.Text = "O";
                btnA3.Enabled = false;
            }

            control = control + 1;
            if ((btnA1.Text == btnA2.Text) & (btnA2.Text == btnA3.Text))
            {
                if (btnA3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA3.Text == btnB2.Text) & (btnB2.Text == btnC1.Text))
            {
                if (btnA3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA3.Text == btnB3.Text) & (btnB3.Text == btnC3.Text))
            {
                if (btnA3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnB1.Text = "X";
                btnB1.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnB1.Text = "O";
                btnB1.Enabled = false;
            }

            control = control + 1;

            if ((btnA1.Text == btnB1.Text) & (btnB1.Text == btnC1.Text))
            {
                if (btnB1.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB1.Text == btnB2.Text) & (btnB2.Text == btnB3.Text))
            {
                if (btnB1.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnB2.Text = "X";
                btnB2.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnB2.Text = "O";
                btnB2.Enabled = false;
            }

            control = control + 1;

            if ((btnA1.Text == btnB2.Text) & (btnB2.Text == btnC3.Text))
            {
                if (btnB2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA2.Text == btnB2.Text) & (btnB2.Text == btnC2.Text))
            {
                if (btnB2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA3.Text == btnB2.Text) & (btnB2.Text == btnC1.Text))
            {
                if (btnB2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB1.Text == btnB2.Text) & (btnB2.Text == btnB3.Text))
            {
                if (btnB2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnB3.Text = "X";
                btnB3.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnB3.Text = "O";
                btnB3.Enabled = false;
            }

            control = control + 1;

            if ((btnA3.Text == btnB3.Text) & (btnB3.Text == btnC3.Text))
            {
                if (btnB3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB1.Text == btnB2.Text) & (btnB2.Text == btnB3.Text))
            {
                if (btnB3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnC1.Text = "X";
                btnC1.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnC1.Text = "O";
                btnC1.Enabled = false;
            }

            control = control + 1;

            if ((btnC1.Text == btnC2.Text) & (btnC2.Text == btnC3.Text))
            {
                if (btnC1.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC1.Text == btnB2.Text) & (btnB2.Text == btnA3.Text))
            {
                if (btnC1.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC1.Text == btnB1.Text) & (btnB1.Text == btnA1.Text))
            {
                if (btnC1.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnC2.Text = "X";
                btnC2.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnC2.Text = "O";
                btnC2.Enabled = false;
            }

            control = control + 1;

            if ((btnC1.Text == btnC2.Text) & (btnC2.Text == btnC3.Text))
            {
                if (btnC2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA2.Text == btnB2.Text) & (btnB2.Text == btnC2.Text))
            {
                if (btnC2.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            int reminder = 0;

            reminder = control % 2;

            //player1?
            if (reminder == 1)
            {
                //if its player1, then do this:
                btnC3.Text = "X";
                btnC3.Enabled = false;
            }
            //player2?
            else if (reminder == 0)
            {
                //if player2 , then do this:
                btnC3.Text = "O";
                btnC3.Enabled = false;
            }

            control = control + 1;

            if ((btnC1.Text == btnC2.Text) & (btnC2.Text == btnC3.Text))
            {
                if (btnC3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA1.Text == btnB2.Text) & (btnB2.Text == btnC3.Text))
            {
                if (btnC3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA3.Text == btnB3.Text) & (btnB3.Text == btnC3.Text))
            {
                if (btnC3.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                else
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA1.Enabled == false) && (btnA2.Enabled == false)
                && (btnA3.Enabled == false) && (btnB1.Enabled == false)
                && (btnB2.Enabled == false) && (btnB3.Enabled == false)
                && (btnC1.Enabled == false) && (btnC2.Enabled == false)
                && (btnC3.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btn1vs1_Click(object sender, EventArgs e)
        {

            control = 1;

            btnA1.Enabled = true;
            btnA2.Enabled = true;
            btnA3.Enabled = true;

            btnB1.Enabled = true;
            btnB2.Enabled = true;
            btnB3.Enabled = true;

            btnC1.Enabled = true;
            btnC2.Enabled = true;
            btnC3.Enabled = true;

            btnReset.Enabled = true;

            btnA11.Enabled = false;
            btnA22.Enabled = false;
            btnA33.Enabled = false;

            btnB11.Enabled = false;
            btnB22.Enabled = false;
            btnB33.Enabled = false;

            btnC11.Enabled = false;
            btnC22.Enabled = false;
            btnC33.Enabled = false;

            btnReset1.Enabled = false;

        }

        private void btn1vspc_Click(object sender, EventArgs e)
        {
            control = 1;

            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;

            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;

            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;

            btnReset.Enabled = false;

            btnA11.Enabled = true;
            btnA22.Enabled = true;
            btnA33.Enabled = true;

            btnB11.Enabled = true;
            btnB22.Enabled = true;
            btnB33.Enabled = true;

            btnC11.Enabled = true;
            btnC22.Enabled = true;
            btnC33.Enabled = true;

            btnReset1.Enabled = true;

        }

        private void btnA11_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnA11.Text = "X";
                btnA11.Enabled = false;

            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }

            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }

        }

        private void btnA22_Click(object sender, EventArgs e)
        {
          
                //if its player1, then do this:
                btnA22.Text = "X";
                btnA22.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }

        }

        private void btnA33_Click(object sender, EventArgs e)
        {
            
                //if its player1, then do this:
                btnA33.Text = "X";
                btnA33.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
               if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            
                //if its player1, then do this:
                btnB11.Text = "X";
                btnB11.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB22_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnB22.Text = "X";
                btnB22.Enabled = false;

            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
               if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnB33_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnB33.Text = "X";
                btnB33.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
               if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }

        }

        private void btnC11_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnC11.Text = "X";
                btnC11.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }
        }

        private void btnC22_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnC22.Text = "X";
                btnC22.Enabled = false;

            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
               || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
               || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                {
                    if (btnA33.Enabled == true)
                    {
                        btnA33.Text = "O";
                        btnA33.Enabled = false;
                    }
                }

                else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                {
                    if (btnA11.Enabled == true)
                    {
                        btnA11.Text = "O";
                        btnA11.Enabled = false;
                    }
                }

                else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                {

                    if (btnA22.Enabled == true)
                    {
                        btnA22.Text = "O";
                        btnA22.Enabled = false;
                    }
                }

                else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                {

                    if (btnB33.Enabled == true)
                    {
                        btnB33.Text = "O";
                        btnB33.Enabled = false;
                    }
                }

                else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                {

                    if (btnB11.Enabled == true)
                    {
                        btnB11.Text = "O";
                        btnB11.Enabled = false;
                    }
                }

                else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                {

                    if (btnB22.Enabled == true)
                    {
                        btnB22.Text = "O";
                        btnB22.Enabled = false;
                    }
                }

                else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                {

                    if (btnC33.Enabled == true)
                    {
                        btnC33.Text = "O";
                        btnC33.Enabled = false;
                    }
                }

                else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                {

                    if (btnC11.Enabled == true)
                    {
                        btnC11.Text = "O";
                        btnC11.Enabled = false;
                    }

                }

                else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                {

                    if (btnC22.Enabled == true)
                    {
                        btnC22.Text = "O";
                        btnC22.Enabled = false;
                    }
                }

                else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                {

                    if (btnC11.Enabled == true)
                    {
                        btnC11.Text = "O";
                        btnC11.Enabled = false;
                    }
                }

                else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                {

                    if (btnB11.Enabled == true)
                    {
                        btnB11.Text = "O";
                        btnB11.Enabled = false;
                    }
                }

                else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                {

                    if (btnA11.Enabled == true)
                    {
                        btnA11.Text = "O";
                        btnA11.Enabled = false;
                    }
                }

                else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                {

                    if (btnC22.Enabled == true)
                    {
                        btnC22.Text = "O";
                        btnC22.Enabled = false;
                    }
                }

                else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                {

                    if (btnA22.Enabled == true)
                    {
                        btnA22.Text = "O";
                        btnA22.Enabled = false;
                    }
                }

                else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                {

                    if (btnB22.Enabled == true)
                    {
                        btnB22.Text = "O";
                        btnB22.Enabled = false;
                    }
                }

                else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                {

                    if (btnC33.Enabled == true)
                    {
                        btnC33.Text = "O";
                        btnC33.Enabled = false;
                    }
                }

                else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                {

                    if (btnA33.Enabled == true)
                    {
                        btnA33.Text = "O";
                        btnA33.Enabled = false;
                    }
                }

                else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                {

                    if (btnB33.Enabled == true)
                    {
                        btnB33.Text = "O";
                        btnB33.Enabled = false;
                    }
                }

                else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                {

                    if (btnC33.Enabled == true)
                    {
                        btnC33.Text = "O";
                        btnC33.Enabled = false;
                    }
                }

                else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                {

                    if (btnB11.Enabled == true)
                    {
                        btnB22.Text = "O";
                        btnB22.Enabled = false;
                    }
                }

                else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                {

                    if (btnA11.Enabled == true)
                    {
                        btnA11.Text = "O";
                        btnA11.Enabled = false;
                    }
                }

                else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                {

                    if (btnC11.Enabled == true)
                    {
                        btnC11.Text = "O";
                        btnC11.Enabled = false;
                    }
                }

                else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                {

                    if (btnA33.Enabled == true)
                    {
                        btnA33.Text = "O";
                        btnA33.Enabled = false;
                    }
                }

                else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                {

                    if (btnB22.Enabled == true)
                    {
                        btnB22.Text = "O";
                        btnB22.Enabled = false;
                    }
                }

                string whilecontrol = "F";//F=continue   T=Stop

                while (whilecontrol == "F")
                {
                    int a;
                    a = random.Next(1, 10);

                    switch (a)
                    {
                        case 1:
                            {
                                if (btnA11.Enabled == true)
                                {
                                    btnA11.Text = "O";
                                    btnA11.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 2:
                            {
                                if (btnA22.Enabled == true)
                                {
                                    btnA22.Text = "O";
                                    btnA22.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 3:
                            {
                                if (btnA33.Enabled == true)
                                {
                                    btnA33.Text = "O";
                                    btnA33.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 4:
                            {
                                if (btnB11.Enabled == true)
                                {
                                    btnB11.Text = "O";
                                    btnB11.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 5:
                            {
                                if (btnB22.Enabled == true)
                                {
                                    btnB22.Text = "O";
                                    btnB22.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 6:
                            {
                                if (btnB33.Enabled == true)
                                {
                                    btnB33.Text = "O";
                                    btnB33.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 7:
                            {
                                if (btnC11.Enabled == true)
                                {
                                    btnC11.Text = "O";
                                    btnC11.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 8:
                            {
                                if (btnC22.Enabled == true)
                                {
                                    btnC22.Text = "O";
                                    btnC22.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                        case 9:
                            {
                                if (btnC33.Enabled == true)
                                {
                                    btnC33.Text = "O";
                                    btnC33.Enabled = false;
                                    whilecontrol = "T";
                                }
                            }
                            break;
                            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
                            {

                                //AI
                                try
                                {
                                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                                    {
                                        if (btnA33.Enabled == true)
                                        {
                                            btnA33.Text = "O";
                                            btnA33.Enabled = false;
                                        }
                                    }

                                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                                    {
                                        if (btnA11.Enabled == true)
                                        {
                                            btnA11.Text = "O";
                                            btnA11.Enabled = false;
                                        }
                                    }

                                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                                    {

                                        if (btnA22.Enabled == true)
                                        {
                                            btnA22.Text = "O";
                                            btnA22.Enabled = false;
                                        }
                                    }

                                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnB33.Enabled == true)
                                        {
                                            btnB33.Text = "O";
                                            btnB33.Enabled = false;
                                        }
                                    }

                                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnB11.Enabled == true)
                                        {
                                            btnB11.Text = "O";
                                            btnB11.Enabled = false;
                                        }
                                    }

                                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                                    {

                                        if (btnB22.Enabled == true)
                                        {
                                            btnB22.Text = "O";
                                            btnB22.Enabled = false;
                                        }
                                    }

                                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                                    {

                                        if (btnC33.Enabled == true)
                                        {
                                            btnC33.Text = "O";
                                            btnC33.Enabled = false;
                                        }
                                    }

                                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                                    {

                                        if (btnC11.Enabled == true)
                                        {
                                            btnC11.Text = "O";
                                            btnC11.Enabled = false;
                                        }

                                    }

                                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                                    {

                                        if (btnC22.Enabled == true)
                                        {
                                            btnC22.Text = "O";
                                            btnC22.Enabled = false;
                                        }
                                    }

                                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                                    {

                                        if (btnC11.Enabled == true)
                                        {
                                            btnC11.Text = "O";
                                            btnC11.Enabled = false;
                                        }
                                    }

                                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                                    {

                                        if (btnB11.Enabled == true)
                                        {
                                            btnB11.Text = "O";
                                            btnB11.Enabled = false;
                                        }
                                    }

                                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                                    {

                                        if (btnA11.Enabled == true)
                                        {
                                            btnA11.Text = "O";
                                            btnA11.Enabled = false;
                                        }
                                    }

                                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnC22.Enabled == true)
                                        {
                                            btnC22.Text = "O";
                                            btnC22.Enabled = false;
                                        }
                                    }

                                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                                    {

                                        if (btnA22.Enabled == true)
                                        {
                                            btnA22.Text = "O";
                                            btnA22.Enabled = false;
                                        }
                                    }

                                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                                    {

                                        if (btnB22.Enabled == true)
                                        {
                                            btnB22.Text = "O";
                                            btnB22.Enabled = false;
                                        }
                                    }

                                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                                    {

                                        if (btnC33.Enabled == true)
                                        {
                                            btnC33.Text = "O";
                                            btnC33.Enabled = false;
                                        }
                                    }

                                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                                    {

                                        if (btnA33.Enabled == true)
                                        {
                                            btnA33.Text = "O";
                                            btnA33.Enabled = false;
                                        }
                                    }

                                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                                    {

                                        if (btnB33.Enabled == true)
                                        {
                                            btnB33.Text = "O";
                                            btnB33.Enabled = false;
                                        }
                                    }

                                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnC33.Enabled == true)
                                        {
                                            btnC33.Text = "O";
                                            btnC33.Enabled = false;
                                        }
                                    }

                                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                                    {

                                        if (btnB11.Enabled == true)
                                        {
                                            btnB22.Text = "O";
                                            btnB22.Enabled = false;
                                        }
                                    }

                                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnA11.Enabled == true)
                                        {
                                            btnA11.Text = "O";
                                            btnA11.Enabled = false;
                                        }
                                    }

                                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnC11.Enabled == true)
                                        {
                                            btnC11.Text = "O";
                                            btnC11.Enabled = false;
                                        }
                                    }

                                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                                    {

                                        if (btnA33.Enabled == true)
                                        {
                                            btnA33.Text = "O";
                                            btnA33.Enabled = false;
                                        }
                                    }

                                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                                    {

                                        if (btnB22.Enabled == true)
                                        {
                                            btnB22.Text = "O";
                                            btnB22.Enabled = false;
                                        }
                                    }
                                }
                                catch
                                {
                                    string whilecontrol = "F";//F=continue   T=Stop

                                    while (whilecontrol == "F")
                                    {
                                        int a;
                                        a = random.Next(1, 10);

                                        switch (a)
                                        {
                                            case 1:
                                                {
                                                    if (btnA11.Enabled == true)
                                                    {
                                                        btnA11.Text = "O";
                                                        btnA11.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 2:
                                                {
                                                    if (btnA22.Enabled == true)
                                                    {
                                                        btnA22.Text = "O";
                                                        btnA22.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 3:
                                                {
                                                    if (btnA33.Enabled == true)
                                                    {
                                                        btnA33.Text = "O";
                                                        btnA33.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 4:
                                                {
                                                    if (btnB11.Enabled == true)
                                                    {
                                                        btnB11.Text = "O";
                                                        btnB11.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 5:
                                                {
                                                    if (btnB22.Enabled == true)
                                                    {
                                                        btnB22.Text = "O";
                                                        btnB22.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 6:
                                                {
                                                    if (btnB33.Enabled == true)
                                                    {
                                                        btnB33.Text = "O";
                                                        btnB33.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 7:
                                                {
                                                    if (btnC11.Enabled == true)
                                                    {
                                                        btnC11.Text = "O";
                                                        btnC11.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 8:
                                                {
                                                    if (btnC22.Enabled == true)
                                                    {
                                                        btnC22.Text = "O";
                                                        btnC22.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;
                                            case 9:
                                                {
                                                    if (btnC33.Enabled == true)
                                                    {
                                                        btnC33.Text = "O";
                                                        btnC33.Enabled = false;
                                                        whilecontrol = "T";
                                                    }
                                                }
                                                break;

                                        }
                                    }
                                }
                            }

                    }
                }
            }
            //win?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }

        }

        private void btnC33_Click(object sender, EventArgs e)
        {
           
                //if its player1, then do this:
                btnC33.Text = "X";
                btnC33.Enabled = false;


            if ((btnA11.Enabled == true) || (btnA22.Enabled == true) || (btnA33.Enabled == true)
                || (btnB11.Enabled == true) || (btnB22.Enabled == true) || (btnB33.Enabled == true)
                || (btnC11.Enabled == true) || (btnC22.Enabled == true) || (btnC33.Enabled == true))
            {

                //AI
                try
                {
                    if ((btnA11.Text == btnA22.Text) && (btnA11.Text == "O"))

                    {
                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {
                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnA11.Text) && (btnA33.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnB11.Text) && (btnB33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnC22.Text) && (btnC11.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnC33.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }

                    }

                    else if ((btnC33.Text == btnC11.Text) && (btnC33.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC11.Text) && (btnA11.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB11.Text = "O";
                            btnB11.Enabled = false;
                        }
                    }

                    else if ((btnB11.Text == btnC11.Text) && (btnB11.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnA22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC22.Enabled == true)
                        {
                            btnC22.Text = "O";
                            btnC22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC22.Text) && (btnC22.Text == "O"))
                    {

                        if (btnA22.Enabled == true)
                        {
                            btnA22.Text = "O";
                            btnA22.Enabled = false;
                        }
                    }

                    else if ((btnC22.Text == btnA22.Text) && (btnA22.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnB33.Text == btnC33.Text) && (btnB33.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnC33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB33.Enabled == true)
                        {
                            btnB33.Text = "O";
                            btnB33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC33.Enabled == true)
                        {
                            btnC33.Text = "O";
                            btnC33.Enabled = false;
                        }
                    }

                    else if ((btnA11.Text == btnC33.Text) && (btnC33.Text == "O"))
                    {

                        if (btnB11.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC33.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA11.Enabled == true)
                        {
                            btnA11.Text = "O";
                            btnA11.Enabled = false;
                        }
                    }

                    else if ((btnA33.Text == btnB22.Text) && (btnB22.Text == "O"))
                    {

                        if (btnC11.Enabled == true)
                        {
                            btnC11.Text = "O";
                            btnC11.Enabled = false;
                        }
                    }

                    else if ((btnB22.Text == btnC11.Text) && (btnB22.Text == "O"))
                    {

                        if (btnA33.Enabled == true)
                        {
                            btnA33.Text = "O";
                            btnA33.Enabled = false;
                        }
                    }

                    else if ((btnC11.Text == btnA33.Text) && (btnA33.Text == "O"))
                    {

                        if (btnB22.Enabled == true)
                        {
                            btnB22.Text = "O";
                            btnB22.Enabled = false;
                        }
                    }
                }
                catch
                {
                    string whilecontrol = "F";//F=continue   T=Stop

                    while (whilecontrol == "F")
                    {
                        int a;
                        a = random.Next(1, 10);

                        switch (a)
                        {
                            case 1:
                                {
                                    if (btnA11.Enabled == true)
                                    {
                                        btnA11.Text = "O";
                                        btnA11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (btnA22.Enabled == true)
                                    {
                                        btnA22.Text = "O";
                                        btnA22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (btnA33.Enabled == true)
                                    {
                                        btnA33.Text = "O";
                                        btnA33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 4:
                                {
                                    if (btnB11.Enabled == true)
                                    {
                                        btnB11.Text = "O";
                                        btnB11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 5:
                                {
                                    if (btnB22.Enabled == true)
                                    {
                                        btnB22.Text = "O";
                                        btnB22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 6:
                                {
                                    if (btnB33.Enabled == true)
                                    {
                                        btnB33.Text = "O";
                                        btnB33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 7:
                                {
                                    if (btnC11.Enabled == true)
                                    {
                                        btnC11.Text = "O";
                                        btnC11.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 8:
                                {
                                    if (btnC22.Enabled == true)
                                    {
                                        btnC22.Text = "O";
                                        btnC22.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;
                            case 9:
                                {
                                    if (btnC33.Enabled == true)
                                    {
                                        btnC33.Text = "O";
                                        btnC33.Enabled = false;
                                        whilecontrol = "T";
                                    }
                                }
                                break;

                        }
                    }
                }
            }

            //won?
            if ((btnA11.Text == btnA22.Text) & (btnA22.Text == btnA33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB22.Text) & (btnB22.Text == btnC33.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA11.Text == btnB11.Text) & (btnB11.Text == btnC11.Text))
            {
                if (btnA11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnA11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnB11.Text == btnB22.Text) & (btnB22.Text == btnB33.Text))
            {
                if (btnB11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnB11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnC22.Text) & (btnC22.Text == btnC33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                 if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnC11.Text == btnB22.Text) & (btnB22.Text == btnA33.Text))
            {
                if (btnC11.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC11.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }
            else if ((btnA22.Text == btnB22.Text) & (btnB22.Text == btnC22.Text))
            {
                if (btnC22.Text == "X")
                {
                    MessageBox.Show("player X wins");
                }
                if (btnC22.Text == "O")
                {
                    MessageBox.Show("player O wins");

                }
            }

            else if ((btnA11.Enabled == false) && (btnA22.Enabled == false)
                            && (btnA33.Enabled == false) && (btnB11.Enabled == false)
                            && (btnB22.Enabled == false) && (btnB33.Enabled == false)
                            && (btnC11.Enabled == false) && (btnC22.Enabled == false)
                            && (btnC33.Enabled == false))
            {
                MessageBox.Show("even game");
            }

        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            control = 1;

            btnA11.Text = "";
            btnA11.Enabled = true;
            btnA22.Text = "";
            btnA22.Enabled = true;
            btnA33.Text = "";
            btnA33.Enabled = true;

            btnB11.Text = "";
            btnB11.Enabled = true;
            btnB22.Text = "";
            btnB22.Enabled = true;
            btnB33.Text = "";
            btnB33.Enabled = true;

            btnC11.Text = "";
            btnC11.Enabled = true;
            btnC22.Text = "";
            btnC22.Enabled = true;
            btnC33.Text = "";
            btnC33.Enabled = true;
        }
    }
}
