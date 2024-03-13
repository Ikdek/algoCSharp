using System;

public class Number
{
    public static int DigitalRoot(long n)
    {
        while (n >= 10)
        {
            int returnNumber = 0;
            string nStr = n.ToString();

            foreach (char digitChar in nStr)
            {
                int digit = digitChar - '0';
                returnNumber += digit;
            }

            n = returnNumber;
        }

        return (int)n;
    }
}