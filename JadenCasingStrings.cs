using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    {
        bool flag = true;
        string newStr = "";

        foreach (char c in phrase)
        {
            if (flag)
            {
                newStr += char.ToUpper(c);
                flag = false;
            }
            else
            {
                newStr += c;
                if (char.IsWhiteSpace(c))
                {
                    flag = true;
                }
            }
        }

        return newStr;
    }
  }
}