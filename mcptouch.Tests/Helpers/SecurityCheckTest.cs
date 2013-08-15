using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mcptouch.Helpers;

namespace mcptouch.Tests.Controllers
{
    [TestClass]
    public class SecurityCheckTest
    {
        [TestMethod]
        public void UserOwnsCar()
        {
            Assert.IsTrue(SecurityCheck.UserOwnsCar(1, 2));
            Assert.IsFalse(SecurityCheck.UserOwnsCar(1, 99));
        }
    }
}
