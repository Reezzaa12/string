using Xunit;
namespace stringtest;

public class strTest
{
    public int stringSize (string text)
    {
        return text.Length;
    }

    public string stringRev (string text)
    {
        char [] nyString = text.ToCharArray();
        Array.Reverse(nyString);
        return new string(nyString);
    }

    public string tabortSpace(string text)
    {
        return text.Replace(" ", "");
    }
}