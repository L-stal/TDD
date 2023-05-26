namespace WordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class WordChecker
    {
        public string LengthChecker(string input)//Check the lenght
        {
            int numLetters = input.Length;

            return numLetters.ToString();
        }
        public string CheckPalin(string input)//Checks if the word i a Palndrome word , mening you spell is the same forward and backwards
        {
            string inputstr, reverse = string.Empty;
            inputstr = input;


            for (int i = inputstr.Length - 1; i >= 0; i--)
            {
                reverse += inputstr[i].ToString();
            }
            return reverse;
        }
        public bool IsEmpty(string input)
        {
            return input.Length == 0 ? true : false;
        }
    }
}