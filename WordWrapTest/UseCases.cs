using NUnit.Framework;

namespace WordWrapTest
{
    public class UseCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstTest()
        {
            Assert.AreEqual(
"Your job\n" +
"is to\n" +
"write a\n" +
"function\n" +
"that takes\n" +
"a string\n" +
"and a\n" +
"maximum\n," +
"number",
                WordWrap.Warp("Your job is to write a function that takes a string and a maximum number", 10));
        }
    }
}