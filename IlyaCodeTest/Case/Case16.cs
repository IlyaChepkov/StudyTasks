namespace IlyaCodeTest.Case
{
    internal class Case16
    {
        [Test]
        public void Case16_1()
        {
            string[] tens = new string[] { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят" };
            string[] ones = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            for (int i = 20; i < 70; i++)
            {
                StreamWriter backInput;
                StreamReader backOutput;
                Main.Start(out backInput, out backOutput, "5", "16");
                backInput.WriteLine(i);
                string res = backOutput.ReadLine();
                Assert.AreEqual(res, $"{tens[i/10]} " + 
                                        (i % 10 == 0 ? "лет" : ($"{ones[(i%10)-1]} " + 
                                        (i % 10 == 1 ? "год" : (i % 10 < 5 ? "года" : "лет")))));
                backInput.WriteLine();
            }
        }
    }
}
