using System;
using System.Diagnostics;
using System.Threading;
namespace l {
	class l {
		static void Main() {
			Console.WriteLine("l");
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "javac";
			processStartInfo.Arguments = "./l.java";
			process.StartInfo = processStartInfo;
			process.Start();
			process.WaitForExit();
			processStartInfo.FileName = "java";
			processStartInfo.Arguments = "l";
			process.StartInfo = processStartInfo;
			process.Start();
		}
	}
}