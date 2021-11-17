using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVerifier;

namespace PasswordVerifierTests
{
    [TestClass]
    public class PasswordVerifierTests
    {
        [TestMethod]
        public void TestPasswordShouldBeLargerThan8chars()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            var passwordVerified = passwordVerifier.Verify("qwer12345");

            // Assert
            Assert.IsTrue(passwordVerified);
        }
    }
}
