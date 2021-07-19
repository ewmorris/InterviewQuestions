using InterviewQuestions.UniqueEmail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewUnitTest
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void TestUniqueEmailWithLocalPeriod()
        {
            var uniqueTest = new Solution();
            var emails = new string[] { "mickeymouse@test.com", "mickey.mouse@test.com" };

            var uniqueEmails = uniqueTest.NumberofUniqueEmailAddresses(emails);

            Assert.AreEqual(1, uniqueEmails);
        }

        [TestMethod]
        public void TestUniqueEmailWithLocalPlus()
        {
            var uniqueTest = new Solution();
            var emails = new string[] { "mickeymouse@test.com", "mickeymouse+minnie@test.com" };

            var uniqueEmails = uniqueTest.NumberofUniqueEmailAddresses(emails);

            Assert.AreEqual(1, uniqueEmails);
        }

        [TestMethod]
        public void TestUniqueEmailsWithLocalPeriodAndPlus()
        {
            var uniqueTest = new Solution();
            var emails = new string[]
            {
                "mickeymouse@test.com",
                "mickey.mouse+minnie@test.com",
                "minniemouse@test.com",
                "minnie.mouse+mickey@test.com"
            };

            var uniqueEmails = uniqueTest.NumberofUniqueEmailAddresses(emails);
            Assert.AreEqual(2, uniqueEmails);
        }

        [TestMethod]
        public void TestUniqueEmailsWithDomainPeriods()
        {
            var uniqueTest = new Solution();
            var emails = new string[]
            {
                "mickeymouse@test.com",
                "mickeymouse@te.st.com"
            };

            var uniqueEmails = uniqueTest.NumberofUniqueEmailAddresses(emails);
            Assert.AreEqual(2, 2);
        }
    }
}
