using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using HP.LFT.Verifications;
using NUnit.Framework;
using System;

namespace NUnit3Tests
{
    [TestFixture]
    public class UftDeveloperTest : UnitTestClassBase
    {
		IBrowser browser;
		[OneTimeSetUp]
        public void TestFixtureSetUp()
        {
			// Setup once per fixture
			browser = BrowserFactory.Launch(BrowserType.EdgeChromium);
		}

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        [Test]
        public void TestMethod1()
        {
//			var browser = BrowserFactory.Launch(BrowserType.EdgeChromium);
			browser.Sync();
			browser.Navigate("https://www.biovita.ro/");
/*			var image = browser.Describe<IImage>(new ImageDescription
			{
				Alt = @"Purificatoare de aer",
				TagName = @"IMG",
				Type = ImageType.Link,
				Index = 1
			});
			image.Click();

			var purificatorDeAerBiovitaAirfresh7200Link = browser.Describe<ILink>(new LinkDescription
			{
				InnerText = @"Purificator de aer Biovita Airfresh-7200",
				TagName = @"A"
			});
			purificatorDeAerBiovitaAirfresh7200Link.Click();

			var adaugNCoButton = browser.Describe<IButton>(new ButtonDescription
			{
				AccessibilityName = string.Empty,
				ButtonType = @"submit",
				Name = @"                        Adaugă în coș                ",
				Role = string.Empty,
				TagName = @"BUTTON",
				Index = 0
			});
			adaugNCoButton.Click();

			var continuCumpRTurileButton = browser.Describe<IButton>(new ButtonDescription
			{
				ButtonType = @"button",
				Name = @"Continuă cumpărăturile",
				TagName = @"BUTTON"
			});
			continuCumpRTurileButton.Click();
			//browser.Close();
*/
		}

		[Test]
		public void TestMethod2_Fail()
		{
			browser.Sync();
			browser.Navigate("https://www.emag.ro/");
			Assert.Fail("expected error .... no real message");
		}

		[Test]
		public void TestMethod3_Pass()
		{
			browser.Sync();
			browser.Navigate("https://www.booking.com/");
			Assert.Pass("success message");
		}
		[Test]
		public void TestMethod4_Pass()
		{
			browser.Sync();
			browser.Navigate("https://www.eon.ro/");
			Assert.Pass("success message");
		}
		[Test]
		public void TestMethod5_Fail()
		{
			browser.Sync();
			browser.Navigate("https://www.abc.ro/");
			Assert.Fail("error message, unknown or invalid URL... ");
		}

		[Test]
		public void TestMethod6_Warning()
		{
			browser.Sync();
			browser.Navigate("https://www.re.ro/");
			Assert.Warn("Warning message, this is for test only... ");
		}

		[Test]
		public void TestMethod7_Error()
		{
			throw new Exception("Expected error, this is for test only... ");
		}

		[Test]
		public void TestMethod8_Error()
		{
			throw new Exception("Another expected error, this is for test only... ");
		}

		[Test]
		public void TestMethod9_Fail()
		{
			Assert.Throws<NullReferenceException>(() => throw new ArgumentException());
		}

		[Test]
		public void TestMethod10_Fail()
		{
			Assert.Fail("Another error message, any details can be provided here ... ");
		}

		[Test]
		[Ignore("for testing porposes")]
		public void TestMethod11_Ignore()
		{
			//test will be skipped
		}

		[Test]
		[Ignore("for testing porposes")]
		public void TestMethod12_Ignore()
		{
			//test will be skipped
		}

		[TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
			// Clean up once per fixture
			browser?.Close();
		}
	}
}
