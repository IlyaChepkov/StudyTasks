using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case13
    {
        [Test]
        public void Case13_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "13");
            backInput.WriteLine(1);
            backInput.WriteLine(2);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2*Math.Sqrt(2)));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            backInput.WriteLine();
        }

        [Test]
        public void Case13_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "13");
            backInput.WriteLine(2);
            backInput.WriteLine(Convert.ToString(2 * Math.Sqrt(2)));
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            backInput.WriteLine();
        }

        [Test]
        public void Case13_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "13");
            backInput.WriteLine(3);
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2 * Math.Sqrt(2)));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            backInput.WriteLine();
        }

        [Test]
        public void Case13_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "13");
            backInput.WriteLine(4);
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, Convert.ToString(2 * Math.Sqrt(2)));
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            backInput.WriteLine();
        }
    }
}
