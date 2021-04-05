namespace Net5FeaturesTest
{
    public class RelationalOperators
    {
        public bool IsValidPercentage(int x) => x is >= 0 and <= 100;
        public bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        public bool IsLetterOrSeparator(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
        public bool IsNull(object e)
        {
            if(e is not null)
            {
                return false;
            }
            return true;
        }
        // New way to write the above method
        public bool IsNull2(object e) => e is null;
    }
}
