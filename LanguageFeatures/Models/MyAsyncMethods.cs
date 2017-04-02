using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public class MyAsyncMethods
	{
		public async static Task<long?> GetPageLength()
		{
			HttpClient client = new HttpClient();
			//var httpTask = client.GetAsync("http://apress.com");
			var httpMessage = await client.GetAsync("http://apress.com");

			// another task while completing http request.

			//return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
			//{
			//	return antecedent.Result.Content.Headers.ContentLength;
			//});

			return httpMessage.Content.Headers.ContentLength;
		}
	}
}