using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageAufbaukursCSharp.ServiceImplementations;

namespace SageAufbaukursCSharpTest
{
    [TestClass]
    public class SaveFileUtilTest
    {
        [TestMethod]
        public void TDD()
        {
            var mock = new SaveFileUtil();
            Assert.IsTrue(mock.Save(""));
        }
    }
}
