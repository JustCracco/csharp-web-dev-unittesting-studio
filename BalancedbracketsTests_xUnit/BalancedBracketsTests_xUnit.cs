using BalancedBracketsNS;

namespace BalancedbracketsTests_xUnit
{
    public class BalancedBracketsTests_xUnit
    {
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

        [Fact]
        public void TestNum1()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("[[Test]"));
        }

        [Fact]
        public void TestNum2()
        {
            Assert.True(BalancedBrackets.HasBalancedBrackets("[Te]st"));
        }

        [Fact]
        public void TestNum3()
        {
            Assert.True(BalancedBrackets.HasBalancedBrackets("T[e]s[t]"));
        }

        [Fact]
        public void TestNum4()
        {
            Assert.True(BalancedBrackets.HasBalancedBrackets("T[e[s]t]"));
        }

        [Fact]
        public void TestNum5()
        {
            Assert.True(BalancedBrackets.HasBalancedBrackets("[Test test]"));
        }

        [Fact]
        public void TestNum6()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("T[es]t[ te]s[t"));
        }

        [Fact]
        public void TestNum7()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("Te[st te]s[t"));
        }

        [Fact]
        public void TestNum8()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("T[es[t t]es[t"));
        }

        [Fact]
        public void TestNum9()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("Te]st t[es[t]"));
        }

        [Fact]
        public void TestNum10()
        {
            Assert.True(BalancedBrackets.HasBalancedBrackets("Te[s[t ]tes]t"));
        }

        [Fact]
        public void TestNum11()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("Te[st)"));
        }

        [Fact]
        public void TestNum12()
        {
            Assert.False(BalancedBrackets.HasBalancedBrackets("T(es]t"));
        }
    }
}