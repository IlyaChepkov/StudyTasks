using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case3
    {
        [Test]
        public void Case3_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Зима");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("2");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Зима");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("3");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Весна");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("4");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Весна");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("5");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Весна");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_6()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Лето");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_7()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("7");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Лето");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_8()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("8");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Лето");
            backInput.WriteLine();
        }
        [Test]
        public void Case3_9()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("9");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Осень");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_10()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("10");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Осень");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_11()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("11");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Осень");
            backInput.WriteLine();
        }

        [Test]
        public void Case3_12()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "3");
            backInput.WriteLine("12");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Зима");
            backInput.WriteLine();
        }
    }
}
