using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuscaVogalUnica.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string test = "aAbBABacfe";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('e', result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string test = "aAbBABacfeaAbBABacf";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('e', result);
        }

        [TestMethod]
        public void TestMethodOnlyVowels()
        {
            string test = "aAeEi";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('\0', result);
        }

        [TestMethod]
        public void TestMethodOnlyConsonants()
        {
            string test = "CdKyt";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('\0', result);
        }

        [TestMethod]
        public void TestMethodOnlyNumbers()
        {
            string test = "546789";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('\0', result);
        }

        [TestMethod]
        public void TestMethodWithNumbers()
        {
            string test = "aAbBcf5eaAbBABacf";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('\0', result);
        }

        [TestMethod]
        public void TestMethodWithNumbersAndSpecialCharacters()
        {
            string test = "aAb.Bcf5eaAbBABa+cf";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Assert.AreEqual('\0', result);
        }
    }
}
