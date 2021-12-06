using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleApi5.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase {
		[HttpGet]
		public IAsyncEnumerable<int> Get() {
			IAsyncEnumerable<int> value = GetData();
			return value;

		}
		private static async IAsyncEnumerable<int> GetData() {
			for (int counter = 0; counter < 10; counter++)
			{
				await Task.Delay(700);
				yield return counter;
			}

		}
	}
}
