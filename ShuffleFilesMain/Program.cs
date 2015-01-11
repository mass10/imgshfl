using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle
{
	public sealed class Program
	{
		private static void Rename(string left)
		{
			System.Guid id = System.Guid.NewGuid();
			System.IO.FileInfo file = new System.IO.FileInfo(left);
			string new_name = file.DirectoryName + "\\" + id + file.Extension;
			Console.WriteLine(new_name);
			file.MoveTo(new_name);
		}

		private static void Enum(string path)
		{
			foreach (string name in System.IO.Directory.EnumerateFiles(path))
			{
				Rename(name);
			}
			foreach (string name in System.IO.Directory.EnumerateDirectories(path))
			{
				Enum(name);
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
