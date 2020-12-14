using JeopardyGame.Contracts;
using System;

namespace JeopardyGame
{
    public class GameRunner
    {
        private JeopardyApiClient jeopardyClient { get; set; } = new JeopardyApiClient();

        public void PlayJeopardy()
        {
            Console.WriteLine(@"
░░░░░██╗███████╗░█████╗░██████╗░░█████╗░██████╗░██████╗░██╗░░░██╗██╗
░░░░░██║██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝██║
░░░░░██║█████╗░░██║░░██║██████╔╝███████║██████╔╝██║░░██║░╚████╔╝░██║
██╗░░██║██╔══╝░░██║░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░░╚██╔╝░░╚═╝
╚█████╔╝███████╗╚█████╔╝██║░░░░░██║░░██║██║░░██║██████╔╝░░░██║░░░██╗
░╚════╝░╚══════╝░╚════╝░╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝");
            bool stillPlaying = true;
            while (stillPlaying)
            {
                Clue clue = jeopardyClient.GetRandomClueAsync().GetAwaiter().GetResult();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Category is: {clue.Category.Title}");
                Console.WriteLine();
                Console.WriteLine($"Clue: {clue.Question}");

                Console.Write("Answer: ");
                string answer = Console.ReadLine();

                if (answer.Equals(clue.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! Answer was: {clue.Answer}");
                }

                Console.WriteLine();
                Console.WriteLine("Want to play again? \"y\" for yes, anything else for no");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    stillPlaying = false;
                }               
            }
        }
    }
}
