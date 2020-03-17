using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class FileLogger : Ilogger
	{
		private string path;

		public string Path
		{
			get
			{
				return this.path;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid path!");
				}
				this.path = value;
			}

		}

		public void Log(string message)
		{
			if (!File.Exists(this.path))
			{
				using (StreamWriter sw = File.CreateText(this.path))
				{
					sw.WriteLine(message);
				}
			}
			else
			{
				using (StreamWriter sw = File.AppendText(this.path))
				{
					sw.WriteLine(message);
				}
			}
		}
	}
}
