using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Bennett_I_A4
{
    class Player
    {
        private string name;
        private int wins = 0;
        private int losses = 0;
        static private Random rand;

        public Player()
        {
            //Thanks to Philip Taylor for reminding me how random works

            rand = new Random();
        }

        public string NameMe
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Win
        {
            get
            {
                return wins;
            }
            set
            {
                //We can only win one game at a time!
                wins += 1;
            }
        }

        public int Loss
        {
            get
            {
                return losses;
            }
            set
            {
                //We can only lose one game at a time!
                losses += 1;
            }
        }

        public void Match(Player opponent)
        {
            if(opponent == this)
            {
                Console.WriteLine("Stop hitting yourself!");
                return;
            }

            int p1C = this.ChooseAction();
            int p2C = opponent.ChooseAction();

            Actions OneChoice = (Actions)p1C;
            Actions TwoChoice = (Actions)p2C;

            Console.WriteLine(p1C.ToString() + " : " + OneChoice.ToString() + " " + p2C.ToString() + " : " + TwoChoice.ToString());

            if(OneChoice == Actions.rock && TwoChoice == Actions.lego)
            {
                Console.WriteLine("Player 1 wins! Rock beats a lego!");
                Win = 1;
                opponent.Loss = 1;
                
            }
            else if(OneChoice == Actions.lego && TwoChoice == Actions.rock)
            {
                Console.WriteLine("Player 2 wins! Rock beats a lego!");
                Loss = 1;
                opponent.Win = 1;
            }
            else if(OneChoice == TwoChoice)
            {
                Console.WriteLine("Draw!");
                Match(opponent);
            }
            else if(OneChoice > TwoChoice)
            {
                int result = OneChoice.CompareTo(TwoChoice);
                Console.WriteLine(result + " This is the result of our game with 1 winning");

                int difference = OneChoice - TwoChoice;
                Console.WriteLine(difference + " The difference between two choices");

                if(difference > 1)
                {
                    Console.WriteLine("Draw! Play again!");
                    Match(opponent);
                }
                else
                {
                    Console.WriteLine("Player1 Wins!");
                    Win = 1;
                    opponent.Loss = 1;
                }
            }
            else
            {
                int result = TwoChoice.CompareTo(OneChoice);
                Console.WriteLine(result + " This is the result of our game with 2 winning");

                int difference = TwoChoice - OneChoice;
                Console.WriteLine(difference + " The difference between two choices");

                if (difference > 1)
                {
                    Console.WriteLine("Draw! Play again!");
                    Match(opponent);
                }
                else
                {
                    Console.WriteLine("Player1 Wins!");
                    Loss = 1;
                    opponent.Win = 1;
                }

            }

            Console.WriteLine("Results: \n P1 W: " + Win + "| L: " + Loss + "\n P2 W: " + opponent.Win + "| L: " + opponent.Loss);
        }

        public void FixedMatch(Player opponent, int res1, int res2)
        {
            int p1C = res1;
            int p2C = res2;

            Actions OneChoice = (Actions)p1C;
            Actions TwoChoice = (Actions)p2C;

            Console.WriteLine(p1C.ToString() + " : " + OneChoice.ToString() + " " + p2C.ToString() + " : " + TwoChoice.ToString());

            if (OneChoice == Actions.rock && TwoChoice == Actions.lego)
            {
                Console.WriteLine("Player 1 wins! Rock beats a lego!");
                Win = 1;
                opponent.Loss = 1;

            }
            else if (OneChoice == Actions.lego && TwoChoice == Actions.rock)
            {
                Console.WriteLine("Player 2 wins! Rock beats a lego!");
                Loss = 1;
                opponent.Win = 1;
            }
            else if (OneChoice == TwoChoice)
            {
                Console.WriteLine("Draw!");

            }
            else if (OneChoice > TwoChoice)
            {
                int result = OneChoice.CompareTo(TwoChoice);
                Console.WriteLine(result + " This is the result of our game with 1 winning");

                int difference = OneChoice - TwoChoice;
                Console.WriteLine(difference + " The difference between two choices");

                if (difference > 1)
                {
                    Console.WriteLine("Draw! Play again!");
                }
                else
                {
                    Console.WriteLine("Player1 Wins!");
                    Win = 1;
                    opponent.Loss = 1;
                }
            }
            else
            {
                int result = TwoChoice.CompareTo(OneChoice);
                Console.WriteLine(result + " This is the result of our game with 2 winning");

                int difference = TwoChoice - OneChoice;
                Console.WriteLine(difference + " The difference between two choices");

                if (difference > 1)
                {
                    Console.WriteLine("Draw! Play again!");
                }
                else
                {
                    Console.WriteLine("Player1 Wins!");
                    Loss = 1;
                    opponent.Win = 1;
                }

            }

            Console.WriteLine("Results: \n P1 W: " + Win + "| L: " + Loss + "\n P2 W: " + opponent.Win + "| L: " + opponent.Loss);
        }

        public int ChooseAction() {
            int result;
            
            result = rand.Next(0, 8);
            Console.WriteLine(result.ToString());
            
            return result;
        }

    }


    enum Actions
    {
        rock, paper, scissors, lizard, spock, battleship, god, buddha, lego
    };
}
