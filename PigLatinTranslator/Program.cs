namespace PigLatinTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pigLatin_words = "";
            string engText_words = "";
            string option;
            Console.WriteLine("Enter letter L for Pig Latin translation OR\nEnter letter E for English Translation: ");
            option = Console.ReadLine();
            option = option.ToUpper();
           
            if (option == "L" )
            {
                Console.WriteLine("Enter text to get Pig Latin translation: ");
                string engText = Console.ReadLine();

                string[] sentence_array = engText.Split(" ");
                foreach (string word in sentence_array)
                {
                    pigLatin_words += " " + word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay";
                }

                Console.WriteLine("PigLatin Translation:" + pigLatin_words);

            }
            else if(option == "E")
            {
                Console.WriteLine("Enter Pig Latin text to get english translation: ");
                string latinText = Console.ReadLine();

                string[] sentence_array = latinText.Split(" ");
                foreach (string word in sentence_array)
                {
                    engText_words += " " + word.Substring(word.Length - 3, 1) + word.Substring(0, word.Length -3);
                }

                Console.WriteLine("English Translation:" + engText_words);
            }
            else
            {
                Console.WriteLine("You enter an invalid character");
            }
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();
        }
    }
}