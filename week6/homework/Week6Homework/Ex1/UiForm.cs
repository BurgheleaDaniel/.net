namespace Week6Homework
{
	using System.Diagnostics;
	using System.Net;
	using System.Threading;
	using System.Threading.Tasks;
	using System.Windows.Forms;

	public partial class UiForm : Form
	{
		public UiForm()
		{
			this.InitializeComponent();
		}

		private void DownloadBtnLeft_Click(object sender, System.EventArgs e)
		{
			var url = this.urlTextBoxLeft.Text;

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

			var t = new Task<string>(() =>
			{
				return this.DownloadString(url);
			});

			t.ContinueWith(prev =>
			{
				this.contentTxbLeft.Text = prev.Exception.Message;
				this.logLabelLeft.Text = $@"Downloaded in {stopwatch.ElapsedMilliseconds} ms";
			}, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, uiScheduler);

			t.ContinueWith(prev =>
			{
				this.contentTxbRight.Text = prev.Result;
				this.logLabelRight.Text = $@"Downloaded in {stopwatch.ElapsedMilliseconds} ms";
			}, CancellationToken.None, TaskContinuationOptions.NotOnFaulted, uiScheduler);

			t.Start();

		}

		private async void DownloadBtnRight_Click(object sender, System.EventArgs e)
		{
			var url = this.urlTextBoxRight.Text;

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Task<string> task = this.DownloadStringAsync(url);
			var result = await task;

			this.contentTxbRight.Text = result;

			*//*var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

			var t = new Task<string>(() =>
			{
				return this.DownloadString(url);
			});

			t.ContinueWith(prev =>
			{
				this.contentTxbRight.Text = prev.Exception.Message;
				this.logLabelRight.Text = $@"Downloaded in {stopwatch.ElapsedMilliseconds} ms";
			}, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, uiScheduler);

			t.ContinueWith(prev =>
			{
				this.contentTxbRight.Text = prev.Result;
				this.logLabelRight.Text = $@"Downloaded in {stopwatch.ElapsedMilliseconds} ms";
			}, CancellationToken.None, TaskContinuationOptions.NotOnFaulted, uiScheduler);

			t.Start(); *//*

		}

		private string DownloadString(string url)
		{
			return new WebClient().DownloadString(url);
		}

		private Task<string> DownloadStringAsync(string url)
		{
			return Task.Run(() => { return DownloadString(url); });
		}
	}
}
