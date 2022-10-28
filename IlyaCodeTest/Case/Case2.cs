using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case2
    {
        [Test]
        public void Case2_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Плохо");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("2");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Неудовлетворительно");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("3");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Удовлетворительно");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("4");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Хорошо");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("5");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Отлично");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_6()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ошибка");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_7()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("7");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ошибка");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_8()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("0");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ошибка");
            backInput.WriteLine();
        }

        [Test]
        public void Case2_9()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "2");
            backInput.WriteLine("-1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ошибка");
            backInput.WriteLine();
        }
    }
}
