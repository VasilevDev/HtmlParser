namespace HtmlParser.Core
{
	interface IParserSettings
	{
		/// <summary>
		/// Url сайта, который парсим
		/// </summary>
		string BaseUrl { get; set; }

		/// <summary>
		/// Префикс для парсинга страниц
		/// </summary>
		string Prefix { get; set; }

		/// <summary>
		/// С какой страницы будем начинать парсинг
		/// </summary>
		int StartPoint { get; set; }

		/// <summary>
		/// До какой страницы будем выполнять парсинг
		/// </summary>
		int EndPoint { get; set; }
	}
}
