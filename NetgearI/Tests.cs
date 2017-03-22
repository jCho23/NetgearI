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
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			#region LoginTests
			app.Tap("main_login_netgear");
			app.Screenshot("Let's start by Tapping on the 'Sign In' Button");
			app.Tap("login_username");
			app.Screenshot("Then we Tapped on the 'Username' Text Field");
			app.EnterText("breckwight@gmail.com");
			app.Screenshot("Next we entered our e-mail, 'breckwight@gmail.com'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("login_password");
			app.Screenshot("We Tapped on the 'Password' Login Text Field");
			app.EnterText("Xamarin123");
			app.Screenshot("Next we entered in our password, 'Xamarin123'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("login");
			app.Screenshot("Then we Tapped on the 'Login Button'");
			#endregion


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
