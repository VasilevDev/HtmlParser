using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Core.Habr
{
	class HabrParser : IParser<string[]>
	{
		public string[] Parse(IHtmlDocument html)
		{
			var items = html.QuerySelectorAll("a").Where(x => x.ClassName != null && x.ClassName.Contains("post__title_link"));
			
			var list = new List<string>();
			foreach (var item in items)
			{
				list.Add(item.TextContent);
			}

			return list.ToArray();
		}
	}
}
