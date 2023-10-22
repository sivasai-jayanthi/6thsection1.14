using System;
using System.IO;

namespace _6thsection1._14
{
	internal class Program
	{
		static void Main(string[] args)
		{

			readtext();

			Console.ReadLine();
		}




		public static void readtext()
		{
			FileStream fs = new FileStream(@"C:\Users\sai\source\repos\6thsection1.14\student data.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			var data = sr.ReadToEnd();
			Console.WriteLine(data);
			sr.Close();
			sr.Dispose();


		}




	}
}