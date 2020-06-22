using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week6Homework
{
	class Ex3
	{
		static CancellationTokenSource source = new CancellationTokenSource();
		static CancellationToken token = source.Token;
		static ConcurrentQueue<string> filesQueue = new ConcurrentQueue<string>();
		static ConcurrentQueue<string> contentQueue = new ConcurrentQueue<string>();
		static CountdownEvent cde = new CountdownEvent(10);

		public static void Main(string[] args)
		{
			Task producer = Task.Factory.StartNew(() =>
			{
				FileSystemWatcher watcher = new FileSystemWatcher();
				watcher.Path = @"C:\Users\Webbeds1\Downloads";

				watcher.Created += OnCreated;

				watcher.EnableRaisingEvents = true;

			}, token);

			Task consumer = Task.Factory.StartNew(() =>
			{
				while (!token.IsCancellationRequested)
				{
					if (filesQueue.Count > 0)
					{
						if (filesQueue.TryDequeue(out string file))
						{
							try
							{
								string content = File.ReadAllText(file);
								contentQueue.Enqueue(content);
								cde.Signal();
							}
							catch (Exception e)
							{
								Console.WriteLine(e.ToString());
							}
						}
					}
				}
			}, token);

			cde.Wait();
			source.Cancel();
			cde.Dispose();

			foreach (var content in contentQueue)
			{
				Console.WriteLine(content);
			}
		}

		private static void OnCreated(object source, FileSystemEventArgs e)
		{
			Console.WriteLine($"File: {e.FullPath}");
			filesQueue.Enqueue(e.FullPath);
		}

	}
}
