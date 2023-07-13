class Program
{
    private static void Main(string[] args)
    {
        int playerDeck = 0;
        int dealerDeck = 0;
        Random random = new Random();
        Options option = Options.menu;

        while (true)
        {
            switch (option)
            {
                case Options.menu:
                    Console.WriteLine("Welcome to P L A T Z I N O");
                    Console.WriteLine("1. Blackjack");
                    Console.WriteLine("2. Exit\n");
                    string optionSelected = Console.ReadLine();
                    if (optionSelected == "1")
                    {
                        option = Options.blackjack;
                    }
                    else if (optionSelected == "2")
                    {
                        option = Options.exit;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                        return;
                    }
                    break;
                case Options.blackjack:
                    do
                    {
                        playerDeck += random.Next(1, 11);
                        Console.WriteLine("\nYour deck is: " + playerDeck);
                        if (playerDeck > 21)
                        {
                            Console.WriteLine("You lost");
                            break;
                        }
                        Console.WriteLine("Do you want another card? (y/n)\n");
                    } while (Console.ReadLine().ToLower() == "y");

                    Console.WriteLine("\nYour final deck is: " + playerDeck + "\n");
                    dealerDeck = random.Next(15, 22);

                    if (playerDeck == 21 ||
                        dealerDeck > 21 ||
                        playerDeck > dealerDeck)
                    {
                        Console.WriteLine("¡You win!");
                    }
                    else if (dealerDeck == 21 ||
                        playerDeck < dealerDeck)
                    {
                        Console.WriteLine("¡You lost!");
                    }
                    else
                    {
                        Console.WriteLine("Draw");
                    }

                    Console.WriteLine("Your deck is: " + playerDeck);
                    Console.WriteLine("Dealer deck is: " + dealerDeck);
                    Console.WriteLine("\nDo you want to play again? (y/n)\n");
                    string playAgain = Console.ReadLine();
                    playerDeck = 0;
                    dealerDeck = 0;
                    if (playAgain == "y")
                    {
                        option = Options.blackjack;
                    }
                    else
                    {
                        option = Options.menu;
                    }
                    break;
                case Options.exit:
                    Console.WriteLine("\nBye");
                    return;
                default:
                    break;
            }
        }
    }
}

enum Options
{
    menu = 0,
    blackjack = 1,
    exit = 2
};
