using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case7
    {
        [Test]
        public void Case7_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "7");
            backInput.WriteLine("1");
            backInput.WriteLine("5,6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res.Remove(3), "5,6");
            backInput.WriteLine();
        }

        [Test]
        public void Case7_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "7");
            backInput.WriteLine("2");
            backInput.WriteLine("5600000");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res.Remove(3), "5,6");
            backInput.WriteLine();
        }

        [Test]
        public void Case7_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "7");
            backInput.WriteLine("3");
            backInput.WriteLine("5600");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res.Remove(3), "5,6");
            backInput.WriteLine();
        }

        [Test]
        public void Case7_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "7");
            backInput.WriteLine("4");
            backInput.WriteLine("0,0056");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res.Remove(3), "5,6");
            backInput.WriteLine();
        }

        [Test]
        public void Case7_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "7");
            backInput.WriteLine("5");
            backInput.WriteLine("0,056");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res.Remove(3), "5,6");
            backInput.WriteLine();
        }
    }
}
