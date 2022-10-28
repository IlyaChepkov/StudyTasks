using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case9
    {
        [Test]
        public void Case9_1()
        {
            int m = 12, d = 31;
            byte[] array = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 1; j <= array[i - 1]; j++)
                {
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "9");
                    backInput.WriteLine(d);
                    backInput.WriteLine(m);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(j));
                    res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(i));
                    backInput.WriteLine();
                    d = j;
                    m = i;
                }
            }
        }
    }
}
