using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode09.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsPalindrome_n2147483648_ShouldBe_False()
        {
            int input = -2147483648;
            Solution solution = new Solution();
            Assert.AreEqual(false, solution.IsPalindrome(input));
        }

        [TestMethod()]
        public void IsPalindrome_10_ShouldBe_False()
        {
            int input = 10;
            Solution solution = new Solution();
            Assert.AreEqual(false,solution.IsPalindrome(input));
        }
    }
}