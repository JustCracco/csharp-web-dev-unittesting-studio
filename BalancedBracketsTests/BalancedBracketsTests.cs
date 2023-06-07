using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        /*
         Test 1: [[Test]
         Test 2: [Te]st
         Test 3: T[e]s[t]
         Test 4: T[e[s]t]
         Test 5: [Test test]
         Test 6: T[es]t[ te]s[t
         Test 7: Te[st te]s[t
         Test 8: T[es[t t]es[t
         Test 9: Te]st t[es[t]
         Test 10: Te[s[t ]tes]t
         Test 11: Te[st)
         Test 12: T(es]t 
         */

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Test]"));
        }

        [TestMethod]
        public void TestNum2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Te]st"));
        }

        [TestMethod]
        public void TestNum3()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("T[e]s[t]"));
        }

        [TestMethod]
        public void TestNum4()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("T[e[s]t]"));
        }

        [TestMethod]
        public void TestNum5()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Test test]"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum6()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("T[es]t[ te]s[t"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum7()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Te[st te]s[t"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("T[es[t t[es[t"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum9()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Te]st t[es[t]"));
        }

        [TestMethod]
        public void TestNum10()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Te[s[t ]tes]t"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum11()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Te[st)"));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestNum12()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("T(es]t"));
        }
    }
}
