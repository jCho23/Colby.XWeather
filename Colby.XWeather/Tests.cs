using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Colby.XWeather
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void CheckLasVegasWeather()
		{
            app.Repl();
			app.Tap("floatingButton");
			app.Screenshot("Let's start by Tapping on the 'Floating Action Button'");
			app.Tap("Las Vegas");
			app.Screenshot("Then we Tapped on 'Las Vegas'");
			app.SwipeRightToLeft();
			app.Screenshot("We Swiped Left to get weather summary");
			app.ScrollDown();
			app.Screenshot("Lastly, we scrolled down for more information");
		}

		[Test]
		public void CheckMiamiWeather()
		{
			app.Tap("floatingButton");
			app.Screenshot("Let's start by Tapping on the 'Floating Action Button'");
			app.Tap("Miamii");
			app.Screenshot("Then we Tapped on 'Miamii'");
			app.SwipeRightToLeft();
			app.Screenshot("We Swiped Left to get weather summary");
			app.ScrollDown();
			app.Screenshot("Lastly, we scrolled down for more information");
		}

	}
}
