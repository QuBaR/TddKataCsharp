using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVerifier;

namespace PasswordVerifierTests
{
    [TestClass]
    public class PasswordVerifierTests
    {
        [DataRow("1234qwert",true)]
        [DataRow("1234qwer",false)]
        [TestMethod]
        public void TestPasswordLargerThenEightCharacters(string inputPassword, bool passwordShouldVerify)
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            var passwordVerified = passwordVerifier.IsMinLength(inputPassword);

            // Assert
            Assert.AreEqual(passwordVerified, passwordShouldVerify);
        }

        [DataRow("1", true)]
        [DataRow(null, false)]
        [TestMethod]
        public void TestPasswordNotNull(string inputPassword, bool passwordShouldVerify)
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            var passwordVerified = !passwordVerifier.ContainsNullOrWhiteSpace(inputPassword);

            // Assert
            Assert.AreEqual(passwordVerified, passwordShouldVerify);
        }

        [DataRow("abcder", false)]
        [DataRow("abcderA", true)]
        [TestMethod]
        public void TestPasswordShouldHaveOneUppercaseLetterAtLeast(string inputPassword, bool passwordShouldVerify)
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            var passwordVerified = passwordVerifier.ShouldHaveOneUppercaseLetterAtLeast(inputPassword);

            // Assert
            Assert.AreEqual(passwordVerified, passwordShouldVerify);
        }

    }
}
