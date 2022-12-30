namespace ReverseAPI.Services
{
    public class ReverseService
    {
        // Reversing given string
        public string? ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
