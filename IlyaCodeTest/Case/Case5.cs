using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case5
    {
        [Test]
        public void Case5_1()
        {
            for (double a = -5; a <= 5; a++)
            {
                for (double b = -5; b <= 5; b++)
                {
                    if (b == 0) continue;
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "5");
                    backInput.WriteLine("1");
                    backInput.WriteLine(a);
                    backInput.WriteLine(b);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(a + b));
                    backInput.WriteLine();
                }
            }
        }
        [Test]
        public void Case5_2()
        {
            for (double a = -5; a <= 5; a++)
            {
                for (double b = -5; b <= 5; b++)
                {
                    if (b == 0) continue;
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "5");
                    backInput.WriteLine("2");
                    backInput.WriteLine(a);
                    backInput.WriteLine(b);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(a - b));
                    backInput.WriteLine();
                }
            }
        }
        [Test]
        public void Case5_3()
        {
            for (double a = -5; a <= 5; a++)
            {
                for (double b = -5; b <= 5; b++)
                {
                    if (b == 0) continue;
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "5");
                    backInput.WriteLine("3");
                    backInput.WriteLine(a);
                    backInput.WriteLine(b);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(a * b));
                    backInput.WriteLine();
                }
            }
        }
        [Test]
        public void Case5_4()
        {
            for (double a = -5; a <= 5; a++)
            {
                for (double b = -5; b <= 5; b++)
                {
                    if (b == 0) continue;
                    StreamWriter backInput;
                    StreamReader backOutput;
                    Main.Start(out backInput, out backOutput, "5", "5");
                    backInput.WriteLine("4");
                    backInput.WriteLine(a);
                    backInput.WriteLine(b);
                    string res = backOutput.ReadLine();
                    Assert.AreEqual(res, Convert.ToString(a / b));
                    backInput.WriteLine();
                }
            }
        }
    }
}
