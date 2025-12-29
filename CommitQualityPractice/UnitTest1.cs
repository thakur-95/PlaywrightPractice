// using System.Threading.Tasks;
// using Microsoft.Playwright;
// using NUnit.Framework;
// using NUnit.Framework.Internal;

// namespace CommitQualityPractice;

// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }

//     [Test]
//     public async Task Test1()
//     {
//         //Playwright
//         using var pw = await Playwright.CreateAsync();

//         //Browser
//         await using var browser = await pw.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false
//         });

//         //Page
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync("http://www.eaapp.somee.com");
//         await page.ClickAsync("text=Login");
//         await page.ScreenshotAsync(new PageScreenshotOptions{ Path = "screenshot.png" });
//         await page.FillAsync("#UserName", "admin");
//         await page.FillAsync("#Password", "password");
//         await page.ClickAsync("text=Log in");
//         var isExist = await page.Locator("text='Hello admin!'").IsVisibleAsync();
//         Assert.That(isExist, Is.True);

//     }
// }
