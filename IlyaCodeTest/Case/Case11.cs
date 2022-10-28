using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest.Case
{
    internal class Case11
    {
        [Test]
        public void Case11_1()
        {
            char[] chars = { 'С', 'З', 'Ю', 'В' };
            byte[] steps = { 3, 1, 2 };
            for(int i = 0; i < chars.Length; i++)
            {
                for(int j = 0; j < steps.Length; j++)
                {
                    for(int k = 0; k < steps.Length; k++)
                    {
                        StreamWriter backInput;
                        StreamReader backOutput;
                        Main.Start(out backInput, out backOutput, "5", "11");
                        backInput.WriteLine(chars[i]);
                        backInput.WriteLine(i == 0 ? -1 : steps[i]);
                        backInput.WriteLine(j == 0 ? -1 : steps[j]);
                        string res = backOutput.ReadLine();
                        Assert.AreEqual(res, Convert.ToString(chars[(i + steps[i] + steps[j]) % 4]));
                        backInput.WriteLine();
                    }
                }
            }
        }
    }
}
