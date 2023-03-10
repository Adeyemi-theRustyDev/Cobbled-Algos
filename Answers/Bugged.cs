namespace App.Answers
{
    public static class Bugged
    {
        public static void Oops()
        {
            Console.WriteLine("Each line you enter will be added to a sentence" +
             "unless you enter QUIT or EXIT");

             string sentence = String.Empty;
             bool canExit = false;

             while(!canExit)
             {
                Console.Write("Enter a string: ");
                string? line = Console.ReadLine();

                string[] terms = { "exit", "quit" };
                foreach (string term in terms)
                {
                    // Compare function returns 0 if both strings are equal hence the code below
                    canExit = (String.Compare(line, term) == 0);
                }
                if (canExit) break;

                sentence = String.Concat(sentence, line);

                Console.WriteLine($"\nYou've entered: {sentence}");

             }

             Console.WriteLine($"\nTotal sentence: {sentence}");

            //  Console.WriteLine($"Press any key to exit...");
            //  Console.ReadKey();
             
             
        }
    }
}