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
			if (System.IO.Directory.Exists(path))
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
			else if (System.IO.File.Exists(path))
			{
				Rename(path);
			}
			else
			{
				Console.WriteLine("[{0}] not found.", path);
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
