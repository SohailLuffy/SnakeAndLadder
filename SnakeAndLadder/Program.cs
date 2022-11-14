
namespace Day4SnakeAndLadder
{
    internal class UC2SnakeLadderGame
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int roll = random.Next(1, 7);

                Console.WriteLine("The Player roll is: " + roll);
            }
        }
    }
