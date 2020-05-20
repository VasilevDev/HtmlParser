using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Core.Habr
{
	class HabrParserObject : IParser<HabrModel[]>
	{
		public HabrModel[] Parse(IHtmlDocument html)
		{
			var items = html.QuerySelectorAll("a").Where(x => x.ClassName != null && x.ClassName.Contains("post__title_link"));

			var list = new List<HabrModel>();
			foreach (var item in items)
			{
				list.Add(new HabrModel() { Title = item.TextContent, Url = item.GetAttribute("href") });
			}

			return list.ToArray();
		}
	}
}
