using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case15
    {
        [Test]
        public void Case15_1()
        {
            string[] side = new string[] { "пик", "треф", "бубен", "червей" };
            string[] power = new string[] { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };
            for (int i = 0; i < side.Length; i++)
            {
                for (int j = 0; j < power.Length; j++)
                {
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "15");
                    backInput.WriteLine(j + 6);
                    backInput.WriteLine(i + 1);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, $"{power[j]} {side[i]}");
                    backInput.WriteLine();
                }
            }
        }
    }
}
