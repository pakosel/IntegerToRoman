using NUnit.Framework;

namespace IntegerToRoman
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Test_3()
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(3);

            Assert.AreEqual(ret, "III");
        }
        public void Test_4()
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(3);

            Assert.AreEqual(ret, "III");
        }

        public void Test_9()
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(9);

            Assert.AreEqual(ret, "IX");
        }

        public void Test_58()
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(3);

            Assert.AreEqual(ret, "LVIII");
        }

        public void Test_1994()
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(1994);

            Assert.AreEqual(ret, "MCMXCIV");
        }

    }
}