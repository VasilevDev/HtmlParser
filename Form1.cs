using HtmlParser.Core;
using HtmlParser.Core.Habr;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HtmlParser
{
	public partial class Form1 : Form
	{
		ParserWorker<HabrModel[]> parser;
		HabrModel[] storeResult;

		public Form1()
		{
			InitializeComponent();

			parser = new ParserWorker<HabrModel[]>(new HabrParserObject());
			parser.OnNewData += Parser_OnNewData;
			parser.OnParseCompleted += Parser_OnParseCompleted;
		}

		private void Parser_OnParseCompleted(object obj)
		{
			MessageBox.Show("All works done!");
		}

		private void Parser_OnNewData(object arg1, HabrModel[] arg2)
		{
			storeResult = arg2;
			ListItemsView.Items.AddRange(arg2.Select(x => x.Title).ToArray());
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			parser.ParserSettings = new HabrSettings((int)StartPoint.Value, (int)EndPoint.Value);
			parser.Start();
		}

		private void AbortBtn_Click(object sender, EventArgs e)
		{
			parser.Abort();
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			ListItemsView.Items.Clear();
		}

		private void ListItemsView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ListItemsView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var senderConcrete = sender as ListBox;
			var result = storeResult.FirstOrDefault(x => x.Title == senderConcrete?.Text);

			if (result != null)
			{
				System.Diagnostics.Process.Start(result.Url);
			}
		}
	}
}
