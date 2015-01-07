using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBitLockerMain
{
	public class BitFolder
	{
		private static string targetDir;

		// Constructor
		public BitFolder(string path)
		{
			targetDir = path;
		}


		public static void CreateDir()
		{
			Directory.CreateDirectory(targetDir);

		}
						
	}
	public class test
	{
	}
}