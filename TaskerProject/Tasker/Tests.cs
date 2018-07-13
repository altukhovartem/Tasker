using System;
using Xunit;

namespace Tasker
{
	public class Tests
	{
		[Fact]
		public void CheckDBConnection()
		{
			using (DataBaseContext DataBaseContext = new DataBaseContext())
			{
				bool result = DataBaseContext.Database.Exists();
				Assert.True(result);
			}
		}
	}
}
