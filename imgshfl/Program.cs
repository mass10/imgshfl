using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imgshfl
{
	public sealed class Program
	{
		private static void Enum(string path)
		{
			foreach (string name in System.IO.Directory.EnumerateFiles(path))
			{
				Console.WriteLine(name);
			}
			foreach (string name in System.IO.Directory.EnumerateDirectories(path))
			{
				//Enum(name);
			}
		}

		public static void Main(string[] args)
		{
			foreach (string path in args)
			{
				Enum(path);
			}
		}
	}
}
