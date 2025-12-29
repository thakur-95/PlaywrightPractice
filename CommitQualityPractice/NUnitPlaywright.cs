using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CommitQualityPractice;

public class NUnitPlaywright : PageTest
{
    public override BrowserTypeLaunchOptions LaunchOptions
    {
        get
        {
            return new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 100  // Optional: slows down operations by 100ms to see what's happening
            };
        }
    }

    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("http://www.eaapp.somee.com");
    }

    [Test]
    public async Task Test1()
    {
        
        
        
        await Page.ClickAsync("text=Login");
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        await Page.ClickAsync("text=Log in");
        await Expect(Page.Locator("text='Hello admin!'")).ToBeVisibleAsync();
        await Task.Delay(7000);
        
    }
}
