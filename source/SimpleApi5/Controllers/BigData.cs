using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace SimpleApi5.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class BigData : ControllerBase {
		[HttpGet]
		public IAsyncEnumerable<DemoData> Get() {
			IAsyncEnumerable<DemoData> value = GetData();
			return value;

		}


		private static async IAsyncEnumerable<DemoData> GetData() {
			DemoData demoData;
			for (int counter = 0; counter < 1000; counter++)
			{
				demoData = new DemoData();
				await Task.Delay(4);
				demoData.Id = counter;
				demoData.BlogTitle = $"Title {counter}";

				yield return demoData;
			}

		}
		public class DemoData {
			Random _random = new();
			public DemoData() {
				BlogContent = RandomString(1600);
			}
			public int Id { get; set; }
			public string BlogTitle { get; set; }
			public string BlogContent { get; set; }
			private string RandomString(int length) {
				const string chars = "ABC DEF GHI JKL MNO PQR STU VWX YZ abc def ghi jkl mno pqr stu vwy z01 234 567 89";
				return new string(Enumerable.Repeat(chars, length)
			.Select(s => s[_random.Next(s.Length)]).ToArray());

			}
		}
	}
}
