using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HtmlParser.Core
{
	/// <summary>
	/// Класс для загрузки необходимой html страницы
	/// </summary>
	class HtmlLoader
	{
		readonly HttpClient client;
		readonly string url;

		public HtmlLoader(IParserSettings settings)
		{
			this.client = new HttpClient();
			this.url = $"{settings.BaseUrl}/{settings.Prefix}/";
		}

		/// <summary>
		/// Получение разметки для определенной страницы
		/// </summary>
		/// <param name="id">ид страницы</param>
		/// <returns></returns>
		public async Task<string> GetSourceByPageId(int id)
		{
			var currentUrl = url.Replace("{CurrentId}", id.ToString());
			var response = await client.GetAsync(currentUrl);
			string source = null;

			if(response != null && response.StatusCode == HttpStatusCode.OK)
			{
				source = await response.Content.ReadAsStringAsync();
			}

			return source;
		}
	}
}
