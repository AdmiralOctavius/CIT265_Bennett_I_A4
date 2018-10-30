/*
 * Name: Isaac Bennett
 * Class: Cit265
 * Professor: Davide Mauro
 * Assignment: 4
 * 
 * Notes: Linq is fun! Thanks to Philip Taylor for brief help in class with setting basic variables up.
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Bennett_I_A4
{
    class Program
    {
        
        //Found on pG 235 for assistance

        static List<Player> playerGenerator(params String[] inputPlayer)
        {
            //Should generate list
            List<Player> newList = new List<Player>();
            
            foreach (var IP in inputPlayer)
            {
                //Console.WriteLine(IP);
                Player player = new Player { NameMe = IP };
                //Console.WriteLine(player.NameMe);
                newList.Add(player);
                
            }

            return newList;
        }

        //Generic Play game method that will set matches for all players
        static public void PlayGame(List<Player> players)
        {
            for(int i = 0; i < 5; i++)
            {
                foreach(var player in players)
                {
                    foreach(var player2 in players)
                    {
                        if(player == player2)
                        {
                            //Console.WriteLine("Can't fight yourself!");
                        }
                        else
                        {
                            player.Match(player2);
                        }
                    }
                }
            }
        }


        static void Main(string[] args)
        {

            //Test values before the real testing
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player("Isabella");
            Player p4 = new Player("Connie");
            Player p5 = new Player("Ruby");

            p1.NameMe = "Steven";
            p2.NameMe = "Lars";
            

            List<Player> playerList = playerGenerator("Steven", "Rose", "Greg", "Connie", "Pearl");

            //Test output for the playernames
            /*foreach(var p in playerList)
            {
                Console.WriteLine(p.NameMe);
            }*/

            var playerQuery = from player in playerList orderby  player.Win descending select player;

            //A test output of the values unsorted
            /*foreach(var p in testQuery)
            {

                Console.WriteLine("Player: " + p.NameMe + " | Wins" + p.Win + " | Losses" + p.Loss);

            }*/

            PlayGame(playerList);

            foreach (var p in playerQuery)
            {

                Console.WriteLine("Player: " + p.NameMe + " | Wins" + p.Win + " | Losses" + p.Loss);

            }


            //I attempted to break into LINQ and find the equals method
            //or some similar method to satisfy the extra credit
            //Unfortunately I could not find a solution that would fit within LINQ that I really understood
            //var drawQuery = from player in playerList where      select player;
        }

       

    }
}
