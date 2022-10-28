using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case14
    {
        [Test]
        public void Case14_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "14");
            backInput.WriteLine(1);
            backInput.WriteLine(2);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2 * Math.Sqrt(3) / 6));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 6));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 4));
            backInput.WriteLine();
        }

        [Test]
        public void Case14_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "14");
            backInput.WriteLine(2);
            backInput.WriteLine(Convert.ToString(2 * Math.Sqrt(2)));
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 6));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 4));
            backInput.WriteLine();
        }

        [Test]
        public void Case14_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "14");
            backInput.WriteLine(3);
            backInput.WriteLine(Convert.ToString(4 * Math.Sqrt(3) / 6));
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2 * Math.Sqrt(2)));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 4));
            backInput.WriteLine();
        }

        [Test]
        public void Case14_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "14");
            backInput.WriteLine(4);
            backInput.WriteLine(Convert.ToString(4 * Math.Sqrt(3) / 4));
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2 * Math.Sqrt(2)));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(4 * Math.Sqrt(3) / 6));
            backInput.WriteLine();
        }
    }
}
