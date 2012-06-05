using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colectica.BlaiseToDdi.Converter;
using Colectica.BlaiseToDdi.Model;

namespace Colectica.BlaiseToDdi
{
	class Program
	{
		static int Main(string[] args)
		{
			if (args.Length != 2)
			{
				PrintUsage();
				return 1;
			}

			string fileName = args[0];
			string outputFileName = args[1];

			BlaiseImportOptions options = new BlaiseImportOptions();

			try
			{
				BlaiseConverter converter = new BlaiseConverter()
				{
					AgencyId = Properties.Settings.Default.AgencyId,
					MainLanguage = Properties.Settings.Default.MainLanguage
				};

				converter.ConvertPhase1(fileName);
				converter.ConvertPhase2(options, outputFileName);

				foreach (string msg in converter.Messages)
				{
					Console.WriteLine(msg);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return 2;
			}

			return 0;
		}

		private static void PrintUsage()
		{
			Console.WriteLine("BlaiseToDDI - Convert Blaise(r) source code to DDI 3.1");
			Console.WriteLine();
			Console.WriteLine("Usage: BlaiseToDDI.exe inputFileName.bla outputFileName.xml");
		}
	}
}