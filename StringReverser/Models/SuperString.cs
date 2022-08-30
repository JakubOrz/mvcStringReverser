namespace StringReverser.Models
{
    public class SuperString
    {
        public SuperString(string baseString)
        {
            this.BaseString = baseString;
        }
        public string BaseString { get; set; }
        
        public SuperString Reverse()
        {
            BaseString = ReverseString(BaseString);
            return this;
        }

        public override string ToString()
        {
            return BaseString;
        }

        private static string ReverseString(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }
            return ReverseString(s.Substring(1)) + s[0];
        }
    }
}