namespace Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string str)
        {
            if (str == null)
                return "";
            else
                return str.Replace(" ", "");
        }
    }
}
