using stringtest;
using Xunit;
namespace strintest;
public class Teststringtest
{
    [Fact]
    public void TestStringSize()
    {
        //given
         strTest tester =new strTest();
         string enString = "Hello!";

         int resultat = tester.stringSize(enString);
         Assert.Equal(enString.Length, resultat); 

    }
}