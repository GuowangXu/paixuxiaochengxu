using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651789_许国望_计算机科学与技术_算法实现9
{
    class Sort
    {
        public Sort()
        {
            length = 0;
            sorttime = 0;
            process = "";
        }
        private const int N = 10000;
        private const int ERROR = 0;
        private const int TRUE = 1;
        private const int FALSE = 0;
        public string process;
        private int sorttime;
        public int[] r = new int[N + 1]; //记录
        public int length;               //表长

        //----------直接插入排序----------
        public void InsertSort()
        {
            process = "";
            sorttime = 1;
            for (int i = 2; i <= length; i++)
                if (r[i] < r[i - 1])
                {
                    r[0] = r[i];
                    r[i] = r[i - 1];
                    int j;
                    for (j = i - 2; r[0] < r[j]; j--)
                        r[j + 1] = r[j];
                    r[j + 1] = r[0];
                    //-----
                    process += "第" + sorttime.ToString() + "趟：";
                    for (int m = 1; m <= length; m++)
                        process += r[m].ToString()+" ";
                    process += "\n";
                    sorttime++;
                }
        }

        //----------折半插入排序----------
        public void BInsertSort()
        {
            process = "";
            sorttime = 1;
            for (int i = 2; i <= length; i++)
            {
                r[0] = r[i];
                int low = 1, high = i - 1;
                while (low <= high)
                {
                    int m = (low + high) / 2;
                    if (r[0] < r[m])
                        high = m - 1;
                    else low = m + 1;
                }
                for (int j = i - 1; j >= high + 1; j--)
                    r[j + 1] = r[j];
                r[high + 1] = r[0];
                //-----
                process += "第" + sorttime.ToString() + "趟：";
                for (int m = 1; m <= length; m++)
                    process += r[m].ToString() + " ";
                process += "\n";
                sorttime++;
            }
        }

        //----------希尔排序----------
        private void ShellInsert(int dk)
        {
            //对顺序表L作一趟希尔排序
            for (int i = dk + 1; i <= length; i++)
                if (r[i] < r[i - dk])
                {
                    r[0] = r[i];
                    int j;
                    for (j = i - dk; j > 0 && r[0] < r[j]; j -= dk)
                        r[j + dk] = r[j];
                    r[j + dk] = r[0];
                    //-----
                    process += "第" + sorttime.ToString() + "趟：";
                    for (int m = 1; m <= length; m++)
                        process += r[m].ToString() + " ";
                    process += "\n";
                    sorttime++;
                }
        }

        public void ShellSort(int[] dlta, int t)
        {
            process = "";
            sorttime = 1;
            for (int k = 0; k < t; k++)
                ShellInsert(dlta[k]);
        }

        //----------冒泡排序----------
        public void BubbleSort()
        {
            process = "";
            sorttime = 1;
            bool change = true;
            for (int i = length; i > 1 && change; i--)
            {
                change = false;
                for (int j = 1; j < i; j++)
                    if (r[j + 1] < r[j])
                    {
                        int temp = r[j];
                        r[j] = r[j + 1];
                        r[j + 1] = temp;
                        change = true;
                        //-----
                        process += "第" + sorttime.ToString() + "趟：";
                        for (int m = 1; m <= length; m++)
                            process += r[m].ToString() + " ";
                        process += "\n";
                        sorttime++;
                    }
            }
        }

        //----------快速排序----------
        private int Partition(int low, int high)
        {
            r[0] = r[low];
            int pivokey = r[low];
            while (low < high)
            {
                while (low < high && r[high] >= pivokey)
                    high--;
                r[low] = r[high];
                while (low < high && r[low] <= pivokey)
                    low++;
                r[high] = r[low];
            }
            r[low] = r[0];
            //-----
            process += "第" + sorttime.ToString() + "趟：";
            for (int m = 1; m <= length; m++)
                process += r[m].ToString() + " ";
            process += "\n";
            sorttime++;
            //-----
            return low;
        }

        private void QSort(int low, int high)
        {
            if (low < high)
            {
                int pivotloc = Partition(low, high);
                QSort(low, pivotloc - 1);
                QSort(pivotloc + 1, high);
            }
        }

        public void QuickSort()
        {
            process = "";
            sorttime = 1;
            QSort(1, length);
        }

        //----------简单选择排序----------
        private int SelectMinkey(int i)
        {
            int min = i;
            for (int j = i + 1; j <= length; j++)
                if (r[j] < r[min])
                    min = j;
            return min;
        }

        public void SelectSort()
        {
            process = "";
            sorttime = 1;
            for (int i = 1; i < length; i++)
            {
                int j = SelectMinkey(i);
                if (i != j)
                {
                    r[0] = r[i];
                    r[i] = r[j];
                    r[j] = r[0];
                    //-----
                    process += "第" + sorttime.ToString() + "趟：";
                    for (int m = 1; m <= length; m++)
                        process += r[m].ToString() + " ";
                    process += "\n";
                    sorttime++;
                }
            }
        }

    }
}
