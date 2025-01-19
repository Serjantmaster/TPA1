using TPA_lectii;

namespace TestProject
{
    public class StringValidatorTest
    {
        [Fact]
        public void IsValidEmail_ShouldReturnTrue_WhenAnEmailHasAronAndDot()
        {
            //arrange
            var email = "utilizator@gmail.com";
            //act
            bool result = StringValidator.IsValidEmail(email);
            //asert
            Assert.True(result);
        }

        [Theory]
        [InlineData("utilizatorgmail.com")]
        [InlineData("utilizator@gmailcom")]
        public void IsValidEmail_ShouldReturnFalse_WhenAnEmailDoesntHasAronAndDot(string email)
        {
            //arrange +act
            bool result = StringValidator.IsValidEmail(email);
            //asert
            Assert.False(result);
        }

        [Fact]
        public void IsPhoneNumber_ShouldReturnTrue_WhenAPhoneNumberIsMadeOf10Digits()
        {
            //arrange
            var phoneNumber = "1234567892";
            //act
            bool result = StringValidator.IsPhoneNumber(phoneNumber);
            //asert
            Assert.True(result);
        }

        [Theory]
        [InlineData("123456789a")]
        [InlineData("1234")]
        public void IsPhoneNumber_ShouldReturnFalse_WhenAPhoneNumberIsntMadeOf10Digits(string phoneNumber)
        {
            //arrange +act
            bool result = StringValidator.IsPhoneNumber(phoneNumber);
            //asert
            Assert.False(result);
        }
    }
}