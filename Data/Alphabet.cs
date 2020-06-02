namespace VanbaApp.Data{
    public static class Alphabet{
        public static string[] Consonants = {"s","d","b","g","v","m","n","y","l"};
        public static string[] Vowels = {"a", "u","i","oi","ai"};  

        public const string Regex = @"^([sdbgvmnylaiu]*|(ai)*|(oi)*)+$";
    }
}