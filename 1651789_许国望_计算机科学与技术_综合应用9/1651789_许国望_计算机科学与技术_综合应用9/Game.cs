using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651789_许国望_计算机科学与技术_综合应用9
{
    class Game
    {
        public const int N = 100;
        public int n;  //人数
        public int c;  //当前序号
        public int d;  //淘汰人数
        public bool[] live = new bool[N];
        public int[] die =new int[N];
        public void Initial(int k)
        {
            n = k;
            c = k - 1;
            d = 0;
            for(int i = 0; i < k; i++)
            {
                live[i] = true;
            }
        }
        public int Dice()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
        public bool Once(int r)
        {
            if (d == n-1)
                return false;
            for(int i = 1; i <= r;)
            {
                c = (c + 1) % n;
                if (live[c])
                    i++;
            }
            live[c] = false;
            die[d] = c + 1;
            d++;
            return true;
        }
        public int Winner()
        {
            if (d != n - 1)
                return 0;
            for (int i = 0; i < n; i++)
                if (live[i])
                    return i;
            return 0;
        } 
    }
}
