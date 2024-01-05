using Microsoft.Playwright;

using var playWright=await Playwright.CreateAsync();
await using var browser=await playWright.Chromium.LaunchAsync();
var context = await browser.NewContextAsync();
var page=await browser.NewPageAsync();
Console.WriteLine("Open Browser");
await page.GotoAsync("https://www.google.com");
Console.WriteLine("Page Loaded Correctlyy");
string Title=await page.TitleAsync();   
await page.Locator("#APjFqb").FillAsync("hp laptop");
Console.WriteLine("Typed the search text");
await page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
Console.WriteLine("Google search button clicked");
var title=await page.TitleAsync();
Console.WriteLine(title);