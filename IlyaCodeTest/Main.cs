using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCodeTest
{
    internal static class Main
    {
        internal static void Start(out StreamWriter backInput, out StreamReader backOutput, string paragraph, string task)
        {
            Process process = new Process();
            process.StartInfo.FileName = "IlyaCode.exe";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            backOutput = process.StandardOutput;
            backInput = process.StandardInput;
            backOutput.ReadLine();
            backInput.WriteLine(paragraph);
            backOutput.ReadLine();
            backInput.WriteLine(task);
            backOutput.ReadLine();
        }
    }
}
