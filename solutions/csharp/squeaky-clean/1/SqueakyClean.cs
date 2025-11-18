public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = "";
        bool makeUpper = false;
        foreach(char c in identifier)
        {
            if(c == ' ')
            {
                result += "_";
            }
            else if(char.IsControl(c))
            {
                result += "CTRL";
            }
            else if(c == '-')
            {
                makeUpper = true;
            }
            else if (!char.IsLetter(c))
            {
                continue;
            }
            else if (c >= 'α' && c <=  'ω')
            {
                continue;
            }
            else
            {
                if(makeUpper)
                {
                    result += char.ToUpperInvariant(c);
                    makeUpper = false;
                }
                else
                {
                    result += c;
                }
            }
        }
        return result;
    }
}
