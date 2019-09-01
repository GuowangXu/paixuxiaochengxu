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

namespace _1651789_许国望_计算机科学与技术_算法实现9
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Sort s = new Sort();
        private bool InputData()
        {
            btnProcess.Enabled = false;
            string str = Interaction.InputBox("请输入数据,用空格隔开", "请输入数据", "",-1, -1);
            string[] sr = str.Split(' ');
            s.length = sr.Length;
            try
            {
                for (int i = 1; i <= s.length; i++)
                    s.r[i] = Convert.ToInt32(sr[i - 1]);
            }
            catch
            {
                MessageBox.Show("请输入合法数字！", "提示");
                return false;
            }
            btnProcess.Enabled = true;
            rtbxData1.Text = str;
            return true;
        }

        private void OutputData()
        {
            string str = "";
            for (int i = 1; i <= s.length; i++)
                str += s.r[i].ToString() + " ";
            rtbxData2.Text = str;
            MessageBox.Show("排序结果：" + str, "排序结果");
        }

        private void btnInsertSort_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                s.InsertSort();
                OutputData();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (s.process == "")
                MessageBox.Show("数据已排好序，无序排序", "提示");
            else
                MessageBox.Show(s.process, "排序过程");
        }

        private void btnBInsertSort_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                s.BInsertSort();
                OutputData();
            }
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            int[] dlta = { 5, 3, 1 };
            if (InputData())
            {
                s.ShellSort(dlta, 3);
                OutputData();
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                s.BubbleSort();
                OutputData();
                ;
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                s.QuickSort();
                OutputData();
            }
        }

        private void btnSelectSort_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                s.SelectSort();
                OutputData();
            }
        }
    }
}
