using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWNUnit
{
    public  class GHPTest : PageTest
    {
        [SetUp]
        public void setUp()
        {

        }
        [Test]
        public async Task Test2()
        {
            Console.WriteLine("Opened Browser");
            await Page.GotoAsync("https://www.google.com");
            Console.WriteLine("Page Loaded");

            string title = await Page.TitleAsync();
            Console.WriteLine(title);

            //await page.GetByTitle("Search").FillAsync("hp laptop");
            await Page.Locator("#APjFqb").FillAsync("selenium");
            Console.WriteLine("Typed Search text");

            ///await page.GetByRole("button").ClickAsync();
            await Page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
            Console.WriteLine("Clicked Google Search Button");

            //title = await Page.TitleAsync();
            //Console.WriteLine(title);

            //Assert.That(title, Does.Contain("selenium"));
            await Expect(Page).ToHaveTitleAsync("selenium - Google Search");
        }
    }
}
