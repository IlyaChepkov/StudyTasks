namespace IlyaCodeTest.Case
{
    public class Case1
    {

        [Test]
        public void Case1_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Понедельник");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("2");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Вторник");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("3");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Среда");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("4");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Четверг");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("5");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Пятница");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_6()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Суббота");
            backInput.WriteLine();
        }

        [Test]
        public void Case1_7()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "1");
            backInput.WriteLine("7");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Воскресенье");
            backInput.WriteLine();
        }

    }
}
