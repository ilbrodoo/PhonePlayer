using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PhonePlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player();
           
            Console.WriteLine("Per Iniziare un brano premi 'M' , per iniziare un film premi 'V': ");
            string charinsert = Console.ReadLine();
            while (true)
            {

                if (charinsert.ToUpper() == "M" )
                {

                    MediaPlayer Song1 = new MusicPlayer("Vetri Neri", "Anna");
                    MediaPlayer Song2 = new MusicPlayer("House of The Rising Sun", "pippo");
                    MediaPlayer Song3 = new MusicPlayer("Hope ", "NF");
                    player.Add(Song3);
                    player.Add(Song1);
                    player.Add(Song2);

                    player.Print();
                    break;
                   

                }
                else if  (charinsert.ToUpper() == "V" )
                {
                    MediaPlayer film1 = new FilmPlayer("Avatar ", " bo");
                    MediaPlayer film2 = new FilmPlayer("star wars", "pippo");
                    MediaPlayer film3 = new FilmPlayer("cars", "si");
                    player.Add(film3);
                    player.Add(film2);
                    player.Add(film1);
                    player.Print();
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Carattere inserito non valido , riprova");
                    Console.BackgroundColor = ConsoleColor.Black;
                    charinsert = Console.ReadLine();
                }
                
            }
            player.Choosemedia();
            
            Console.WriteLine("---------------------------------------------------------------------------------");
            while(true)
            {
                Console.WriteLine("Inserisci azione desiderata  : Stop , Next , Previous , Exit ");
                string actionselect = Console.ReadLine().ToLower();
                switch (actionselect)
                {
                    case "stop":
                        player.Stop();
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        break;
                    case "next":
                      player.Next();
                        Console.WriteLine("---------------------------------------------------------------------------------"); break;

                    case "previous": 
                        player.Previous();
                        Console.WriteLine("---------------------------------------------------------------------------------"); break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Azione Non Riconosciuta ");
                       break;

                }
            }

        }
        
    }
}
