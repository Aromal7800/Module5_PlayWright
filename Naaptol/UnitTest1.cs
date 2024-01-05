using System.Text;

namespace Naaptol
{
    [TestFixture]
    public class EATest:PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Console.Out.WriteLineAsync("Opened Browser");
            await Page
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}