using NantHealthAuthorize.Models;
using Xunit;
namespace NantHealthAuthorize.Tests
{
    public class LoginLogicTests
    {
        [Fact]
        public void ValidCredentials_ShouldValidateCorrectPassword()
        {
            bool expectedResult = true;

            User user = new User();
            string plainTextPassword = "th0thI4uz!F=uTh*7R_+";
            user.username = "test";
            user.password = "$2a$12$N.HhnzPp/SgxvaD0yRKdAeiQvYtfD9Ozrd0/X3/kuMZHkM8KOi/sa";//hashed password
            user.id = System.Guid.NewGuid();
            bool returnedResult = LoginLogic.ValidCredientials(user, plainTextPassword);

            Assert.Equal(expectedResult, returnedResult);
        }
        [Fact]
        public void ValidCredentials_ShouldValidateIncorrectPassword()
        {
            bool expectedResult = false;

            User user = new User();
            string plainTextPassword = "InC0rectP4s5w0rd";
            user.username = "test";
            user.password = "$2a$12$N.HhnzPp/SgxvaD0yRKdAeiQvYtfD9Ozrd0/X3/kuMZHkM8KOi/sa";//hashed incorrect password
            user.id = System.Guid.NewGuid();
            bool returnedResult = LoginLogic.ValidCredientials(user, plainTextPassword);

            Assert.Equal(expectedResult, returnedResult);
        }
    }
}