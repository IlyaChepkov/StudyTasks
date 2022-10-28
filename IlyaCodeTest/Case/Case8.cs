using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case8
    {
        [Test]
        public void Case8_1()
        {
            int m = 12, d = 31; 
            byte[] array = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 1; j <= array[i-1]; j++)
                {
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "8");
                    backInput.WriteLine(j);
                    backInput.WriteLine(i);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(d));
                    res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(m));
                    backInput.WriteLine();
                    d = j;
                    m = i;
                }
            }
        }
    }
}
