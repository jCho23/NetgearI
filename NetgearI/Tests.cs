using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace NetgearI
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
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("main_login_netgear");

			app.Tap("login_username");

			app.EnterText("breckwight@gmail.com");

			app.DismissKeyboard();

			app.Tap("login_password");

			app.EnterText("Xamarin123");

			app.DismissKeyboard();

			app.Tap("login");


			app.Tap("add_new");
			app.Screenshot("Then we Tapped on 'Set Up New Devices'");

			app.Tap("ap_image");
			app.Screenshot("Next we Tapped on 'Access Point'");

			app.Tap("scan_qr_code");
			app.Screenshot("We Tapped 'Through QR Code'");

			app.Tap("scan_qr_code");
			app.Screenshot("Then we Tapped 'Scan QR Code'");
		}

	}
}
