using System.Diagnostics;
using System.IO;
using System.Text;

namespace IlyaCodeTest
{
    public class Begin
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Begin1_1()
        {
            for (int i = 1; i < 10; i++)
            {
                StreamWriter backInput;
                StreamReader backOutput;
                Main.Start(out backInput, out backOutput, "1", "1");
                backInput.WriteLine("1");
                string res = backOutput.ReadLine();
                Assert.AreEqual(int.Parse(res), 4);
            }
        }

        [Test]
        public void Begin1_2()
        {
            for (int i = 1; i < 10; i++)
            {
                StreamWriter backInput;
                StreamReader backOutput;
                Main.Start(out backInput, out backOutput, "1", "1");
                backInput.WriteLine("2");
                string res = backOutput.ReadLine();
                Assert.AreEqual(int.Parse(res), 8);
            }
        }

        [Test]
        public void Begin1_3()
        {
            for (int i = 1; i < 10; i++)
            {
                StreamWriter backInput;
                StreamReader backOutput;
                Main.Start(out backInput, out backOutput, "1", "1");
                backInput.WriteLine("3");
                string res = backOutput.ReadLine();
                Assert.AreEqual(int.Parse(res), 12);
            }
        }
    }
}