using System;
using System.Threading;

namespace HtmlParser.Core
{
	class ParserWorker<T> where T : class
	{
		readonly IParser<T> parser;
		readonly CancellationTokenSource token;
		IParserSettings parserSettings;
		HtmlLoader loader;
		

		#region Properties
		public IParser<T> Parser { get; set; }
		public IParserSettings ParserSettings
		{
			get
			{
				return parserSettings;
			}
			set
			{
				parserSettings = value;
				loader = new HtmlLoader(value);
			}
		}
		public bool IsActive { get; private set; }
		#endregion

		public event Action<object, T> OnNewData;
		public event Action<object> OnParseCompleted;

		public ParserWorker(IParser<T> parser)
		{
			this.parser = parser;
			this.token = new CancellationTokenSource();
		}

		public ParserWorker(IParser<T> parser, IParserSettings parserSettings) 
			: this(parser)
		{
			this.parserSettings = parserSettings;
		}

		public void Start()
		{
			IsActive = true;
			DoWork();
		}

		public void Abort()
		{
			IsActive = false;
			token.Cancel();
		}

		private async void DoWork()
		{
			for (int i = parserSettings.StartPoint; i < parserSettings.EndPoint; i++)
			{
				if(!IsActive)
				{
					OnParseCompleted?.Invoke(this);
					return;
				}

				var source = await loader.GetSourceByPageId(i);
				var domParser = new AngleSharp.Html.Parser.HtmlParser();

				var document = await domParser.ParseDocumentAsync(source, token.Token);
				var parseResult = parser.Parse(document);
				OnNewData?.Invoke(this, parseResult);
			}

			OnParseCompleted?.Invoke(this);
			IsActive = false;
		}
	}
}
