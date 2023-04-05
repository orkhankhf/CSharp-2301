using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart4.MineFieldGame
{
    public partial class MineFieldGame : Form
    {
        public MineFieldGame()
        {
            InitializeComponent();
            scoreLbl.Text = "0";
            mineLbl.Text = "3";
        }

        private void MineFieldGame_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            int mineBox1 = rand.Next(1, 30);
            int mineBox2 = rand.Next(31, 60);
            int mineBox3 = rand.Next(61, 100);

            for (int i = 1; i <= 100; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new Size(35, 35);
                btnTemp.UseVisualStyleBackColor = true;
                btnTemp.BackColor = SystemColors.ControlDark;

                if(mineBox1 == i || mineBox2 == i || mineBox3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += OpenBox;
                minePanel.Controls.Add(btnTemp);
            }
        }

        private void resetGameBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int mineBox1 = rand.Next(1, 30);
            int mineBox2 = rand.Next(31, 60);
            int mineBox3 = rand.Next(61, 100);

            for (int i = 0; i < minePanel.Controls.Count; i++)
            {
                var button = (Button)minePanel.Controls[i];

                button.Enabled = true;
                button.BackColor = SystemColors.ControlDark;

                if (mineBox1 == i || mineBox2 == i || mineBox3 == i)
                {
                    button.Tag = true;
                }
                else
                {
                    button.Tag = false;
                }
            }

            scoreLbl.Text = "0";
            mineLbl.Text = "3";

            scoreLbl.ForeColor = Color.Black;
            mineLbl.ForeColor = Color.Green;
        }

        private void OpenBox(object sender, EventArgs e)
        {
            Button clickedButton = ((Button)sender);

            if(clickedButton.Tag != null)
            {
                bool? isBoxMine = (bool)clickedButton.Tag;

                if(isBoxMine == true)
                {
                    MessageBox.Show("Minaya düşdünüz!");
                    clickedButton.BackColor = Color.Red;

                    int mineCount = int.Parse(mineLbl.Text) - 1;
                    mineLbl.Text = mineCount.ToString();

                    if (mineCount == 2)
                        mineLbl.ForeColor = Color.DarkOrange;
                    else if(mineCount == 1)
                        mineLbl.ForeColor = Color.Red;
                    else
                    {
                        GameOver();
                    }
                }
                else if(isBoxMine == false)
                {
                    clickedButton.BackColor = Color.Green;

                    int score = int.Parse(scoreLbl.Text) + 1;
                    scoreLbl.Text = score.ToString();
                }

                clickedButton.Tag = null;
            }
        }

        private void GameOver()
        {
            foreach (var item in minePanel.Controls)
            {
                if(item is Button)
                {
                    ((Button)item).Enabled = false;
                }
            }

            MessageBox.Show("Uduzdunuz!");
        }
    }
}
