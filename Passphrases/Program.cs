using System;
using System.Text;


public class Solution
{
    static void Main(string[] args)
    {
        string input = "BORN IN 2015!";
        int shift = 1;
        char c1 = (char)97;
        char c = Convert.ToChar(2);
        Console.WriteLine(PlayPass.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));



    }
}



public class PlayPass
{

    public static string playPass(string inputString, int shiftNumber)
    {
        StringBuilder transformed = new StringBuilder();


        foreach (char c in inputString)
        {
            if (char.IsLetter(c))
            {
                
                if (char.IsLower(c))
                {
                    char shifted = (char)('a' + (c - 'a' + shiftNumber) % 26);
                    transformed.Append(shifted);
                }
                else
                {
                    char shifted = (char)('A' + (c - 'A' + shiftNumber) % 26);
                    transformed.Append(char.ToUpper(shifted));
                }
            }
            else if (char.IsDigit(c))
            {
                transformed.Append(9 - (c - '0')).ToString();
            }
            else
            {
                transformed.Append(c);
            }
        }

        char[] chars = transformed.ToString().ToCharArray();

        for(int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                if (i % 2 == 0)
                {
                    chars[i] = char.ToUpper(chars[i]);
                } else
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }
        }

        Array.Reverse(chars);

        return new string(chars);



    }

}
