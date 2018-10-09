using Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Test
{
    [TestClass]
    public class StringService_CutString_Tests
    {
        StringService s = new StringService();
        [TestMethod]
        public void Should_add_dots_when_cut_is_made_within_string()
        {
            Assert.AreEqual("acad...", s.CutString("academy", 4));
        }
        [TestMethod]
        public void Should_return_empty_string()
        {
            Assert.AreEqual("", s.CutString(null, 4));
        }
        [TestMethod]
        public void Should_empty_string()
        {
            Assert.AreEqual("...", s.CutString("Academy", 0));
        }
        [TestMethod]
        public void Should_string_asitis()
        {
            Assert.AreEqual("Academy", s.CutString("Academy", 50));
        }
    }
}
