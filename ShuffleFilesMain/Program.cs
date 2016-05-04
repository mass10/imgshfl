using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle
{
	public sealed class Program
	{
		public static void Main(string[] args)
		{
			foreach (string path in args)
			{
				Controller.Enum(path);
			}
		}
	}
}
