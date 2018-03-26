using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace DemoAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {

            lbResult.Text = "Kết quả: Calculating...";
            lbTime.Text = "Thời gian: Running...";
            List<Task<BigInteger>> SumTaskList = new List<Task<BigInteger>>();
            List<Task<int>> FindTaskList = new List<Task<int>>();
            BigInteger n = BigInteger.Parse(tbN.Text);
            int taskNum = (int)(numCore.Value);
            BigInteger r = 0;
            BigInteger finalR = 0;
            if (n % taskNum != 0)
            {
                r = n - (n / taskNum) * taskNum;
            }
            BigInteger length = n / taskNum;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            
            for (int i = 0;i<taskNum;i++)
            {
                if (i == taskNum - 1)
                {
                    finalR = r;
                }
                if (chkSum.Checked)
                {
                    SumTaskList.Add(Task<BigInteger>.Factory.StartNew(SumN, new Vector((i * length), (i * length) + length + finalR)));
                }
                if (chkPrime.Checked)
                {
                    SumTaskList.Add(Task<BigInteger>.Factory.StartNew(CountPrime, new Vector((i * length), (i * length) + length + finalR)));
                }
                if (chkMax.Checked)
                {
                    FindTaskList.Add(Task<int>.Factory.StartNew(FindMaxRandomNum, new Vector((i * length), (i * length) + length + finalR)));
                }
            }

            Task.WaitAll(SumTaskList.ToArray());
            BigInteger result = 0;
            if (!chkMax.Checked)
            {
                for (int i = 0; i < taskNum; i++)
                {
                    result += SumTaskList[i].Result;
                }
            }
            else
            {
                result = FindTaskList[0].Result;
                for (int i = 1; i < taskNum; i++)
                {
                    result = result > FindTaskList[i].Result ? result : FindTaskList[i].Result;
                }
            }
            stopwatch.Stop();
            lbResult.Text = "Kết quả: " + result;
            lbTime.Text = "Thời gian: " + stopwatch.ElapsedMilliseconds + " (ms)";
            stopwatch.Reset();

        }
        public BigInteger SumN(object vec)
        {
            Vector v = (Vector)vec;
            BigInteger result = 0;
            for (BigInteger i = v.Start + 1; i <= v.End; i++)
            {
                result += i;

            }
            return result;
        }

        public BigInteger CountPrime(object vec)
        {

            Vector v = (Vector)(vec);
            BigInteger result = 0;
            for (BigInteger i = v.Start + 1; i <= v.End; i++)
            {
                result += IsPrime(i) ? 1 : 0;

            }
            return result;
        }

        public bool IsPrime(BigInteger n)
        {

            if (n % 2 == 0)
                return false;
            for (BigInteger i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public int FindMaxRandomNum(object vec)
        {
            Vector v = (Vector)(vec);
            Random rand = new Random();
            int result = 0;
            for (BigInteger i = v.Start + 1; i <= v.End; i++)
            {
                int randomNum = rand.Next(-10000, 10000);
                if (result < randomNum)
                    result = randomNum;
            }
            return result;
        }

    }
}
