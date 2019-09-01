using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1651789_许国望_计算机科学与技术_综合应用9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bg = ptbxGame.Image;
        }
        Game g=new Game();
        public const int N = 100;
        public double space;
        public const float r1 = 180;
        public const float r2 = 240;
        public Image bg;
        private void btnNum_Click(object sender, EventArgs e)
        {
            int k;
            try
            {
                k = Convert.ToInt32(Interaction.InputBox("请输入人数（2~100）", "人数", "12", -1, -1).Trim());
            }
            catch
            {
                MessageBox.Show("请输入合法数字！", "提示");
                return;
            }
            if (k < 2 || k > N)
            {
                MessageBox.Show("请输入合法数字！", "提示");
                return;
            }

            lblNum.Text = k.ToString();
            g.Initial(k);
            Font font1 = new Font("宋体", 12);
            Font font2 = new Font("宋体", 8);
            Graphics gp = ptbxGame.CreateGraphics();
            space = 2 * Math.PI / k;
            for (int i = 1; i <= k; i++)
            {
                if (k <= N / 2)
                    gp.DrawString(i.ToString(), font1, new SolidBrush(Color.Black), ptbxGame.Width / 2 + r1 * (float)Math.Sin(space * (i - 1)), ptbxGame.Width / 2 - r1 * (float)Math.Cos(space * (i - 1)));
                else
                    gp.DrawString(i.ToString(), font2, new SolidBrush(Color.Black), ptbxGame.Width / 2 + r2 * (float)Math.Sin(space * (i - 1)), ptbxGame.Width / 2 - r2 * (float)Math.Cos(space * (i - 1)));

            }
            btnNum.Enabled = false;
            btnOnce.Enabled = true;
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            ptbxGame.Image = bg;
            rtbxDead.Text = "";
            btnNum.Enabled = true;
            btnOnce.Enabled = false;
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            Graphics gp = ptbxGame.CreateGraphics();
            Font font1 = new Font("宋体", 12);
            Font font2 = new Font("宋体", 8);
            

            int c = g.c;
            int j = g.Dice();
            if (g.Once(j))
            {
                lblDice.Text = j.ToString();

                if (g.n <= N / 2)
                    gp.DrawString((g.c+1).ToString(), font1, new SolidBrush(Color.Red), ptbxGame.Width / 2 + r1 * (float)Math.Sin(space * g.c), ptbxGame.Width / 2 - r1 * (float)Math.Cos(space * g.c));
                else
                    gp.DrawString((g.c+1).ToString(), font2, new SolidBrush(Color.Red), ptbxGame.Width / 2 + r2 * (float)Math.Sin(space * g.c), ptbxGame.Width / 2 - r2 * (float)Math.Cos(space * g.c));
                rtbxDead.AppendText((g.c + 1).ToString() + " ");
            }
            else
            {
                MessageBox.Show("游戏已结束！", "提示");
            }
            if (g.d == g.n - 1)
            {
                btnOnce.Enabled = false;
                MessageBox.Show("游戏已结束，"+(g.Winner()+1).ToString()+"号胜出！", "提示");    
            }
        }
    }
}
