using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case4
    {
        [Test]
        public void Case4_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("2");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "28");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("3");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("4");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "30");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("5");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_6()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "30");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_7()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("7");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_8()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("8");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }
        [Test]
        public void Case4_9()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("9");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "30");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_10()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("10");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_11()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("11");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "30");
            backInput.WriteLine();
        }

        [Test]
        public void Case4_12()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "4");
            backInput.WriteLine("12");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "31");
            backInput.WriteLine();
        }
    }
}
