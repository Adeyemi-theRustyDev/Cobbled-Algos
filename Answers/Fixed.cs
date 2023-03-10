namespace App.Answers
{
    public static class Fixed
    {
        public static void Ok()
        {
            Console.WriteLine("Each line you enter will be added to a sentence" +
             "unless you enter QUIT or EXIT");

            string sentence = String.Empty;
            bool canExit = false;

            while (!canExit)
            {
                Console.Write("Enter a string: ");
                string? line = Console.ReadLine();

                string[] terms = { "exit", "quit" };
                foreach (string term in terms)
                {
                    canExit = (String.Compare(line?.ToLower(), term) == 0);
                    if (canExit) break;
                    /*
                        This works now because the condition to break as been moved
                        into the foreach loop. Previously, it loops thriugh all the items and sets 
                        the can exit flag only based on the last term  in the loop so if your quit term is not the last term in the
                        quitTerms array it wouldn't break out of the loop previously.
                        */
                }

                if(!canExit)
                {
                    sentence = String.Concat(sentence, $" {line}"); 
                    /* white space is added to the line variable before concatenation
                        so the input looks better */
                }
                

                Console.WriteLine($"\nYou've entered: {sentence}");

            }

            Console.WriteLine($"\nTotal sentence: {sentence}");

        }
    }
}
