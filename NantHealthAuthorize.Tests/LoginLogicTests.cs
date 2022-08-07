using NantHealthAuthorize.Models;
using System;
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
            string plainTextPassword = "@=Up41&p?5tIsweSTIW&";
            user.username = "test";
            user.password = "$argon2i$v=19$m=4096,t=3,p=2$S7w8qWz7NJRwzx1KjKK9Kw$wenh6H9tgElXABO3jYUeV5tIw5Ec9dPGU1JIQY4BIUU";//hashed password
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
            user.password = "$argon2i$v=19$m=4096,t=3,p=2$S7w8qWz7NJRwzx1KjKK9Kw$wenh6H9tgElXABO3jYUeV5tIw5Ec9dPGU1JIQY4BIUU";//hashed incorrect password
            user.id = System.Guid.NewGuid();
            bool returnedResult = LoginLogic.ValidCredientials(user, plainTextPassword);

            Assert.Equal(expectedResult, returnedResult);
        }
        [Fact]
        public void NullUserException()
        {
            User user = null;
            var plainTextPassword = "test";
            Assert.Throws<ArgumentNullException>(() => LoginLogic.ValidCredientials(user, plainTextPassword));
        }
        [Fact]
        public void NullpasswordException()
        {
            User user = new User();
            user.username = "test";
            user.password = "$2a$12$N.HhnzPp/SgxvaD0yRKdAeiQvYtfD9Ozrd0/X3/kuMZHkM8KOi/sa";//hashed password
            user.id = System.Guid.NewGuid();
            string plainTextPassword = null;
            Assert.Throws<ArgumentNullException>(() => LoginLogic.ValidCredientials(user, plainTextPassword));
        }

    }
}