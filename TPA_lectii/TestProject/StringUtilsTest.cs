using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using TPA_lectii;

namespace TestProject
{
    public class StringUtilsTest
    {
        [Fact]
        public void Reverse_ShouldReturnTheReversedVariantOfText_WhenATextIsGiven() 
        {
            //arrange
            var reverse = new StringUtils();
            string text = "abcde";
            //act
            var result= reverse.Reverse(text);
            //asert
            Assert.Equal("edcba", result);
        }
        [Fact]
        public void IsPalindrome_ShouldReturnTrue_WhenTheTextIsAPalindrom()
        {
            //arrange
            var reverse = new StringUtils();
            string text = "abcba";
            //act
            var result = reverse.IsPalindrome(text);
            //asert
            Assert.True(result);
        }
        [Fact]
        public void IsPalindrome_ShouldReturnFalse_WhenTheTextIsNotAPalindrom()
        {
            //arrange
            var reverse = new StringUtils();
            string text = "abcda";
            //act
            var result = reverse.IsPalindrome(text);
            //asert
            Assert.False(result);
        }
    }
}
