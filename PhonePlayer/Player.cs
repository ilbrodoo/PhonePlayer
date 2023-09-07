using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePlayer
{
     public  class Player
    {
         public    List<MediaPlayer> PlayList = new List<MediaPlayer>();
         private MediaPlayer currentMedia = null;
        private int i = 0;
         public void Add(MediaPlayer player)
        {
            PlayList.Add(player);
        }

        public void  Play(int i)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            currentMedia = PlayList[i - 1];
                this.i = i - 1;
                string titolo = currentMedia.title;

                Console.WriteLine("Riproduzione di: " + titolo);
                Console.ResetColor();
        }


        public void   Choosemedia ()
        {
            while (true)
            {
                Console.WriteLine("Inserisci numero del Media che vuoi riprodurre :");
                int i = Convert.ToInt32(Console.ReadLine());
                
                if (i >= 1 && i <= PlayList.Count)
                {
                    this.i = i;
                    Play(i);
                    
                    break;
                    
                    
                }
                else { Console.WriteLine("Numero non presente , riprova ");
                }
            }
         
        }
        public void Print()
        {
            int i = 1;
            foreach ( var media in PlayList) 
            {
                Console.Write(i + " - ");
                i++;
                media.Print();

                
            }
        }

       
        public  void Stop() 
        {

            if (currentMedia != null)
            {
                this.currentMedia = PlayList[i];
                
                string titolo = currentMedia.title;
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Stop di: " + titolo);
                // Esegui qui le operazioni di stop specifiche.
                currentMedia = null; // Resetta l'elemento corrente dopo la stop.
            }
            else
            {
                Console.WriteLine("Nessun elemento in riproduzione.");
            }
        }
        public  void Next() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.i = i + 1;
            if (i >= 0 && i < PlayList.Count)
            {
                this.currentMedia = PlayList[i];
                
                string titolo = currentMedia.title;
               
                Console.WriteLine("Riproduzione  di: " + titolo);
                
                
                // Esegui qui le operazioni di stop specifiche.
                currentMedia = null;
            }
            else
            {


                currentMedia = PlayList.First();
                this.i = 0;
                string titolo = currentMedia.title;

                Console.WriteLine("Riproduzione  di: " + titolo);

            }
        }
        public  void Previous()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            this.i = i - 1;
            if (i >= 0 && i < PlayList.Count)
            {
                this.currentMedia = PlayList[i];

                string titolo = currentMedia.title;

                Console.WriteLine("Riproduzione  di: " + titolo);
                // Esegui qui le operazioni di stop specifiche.
                currentMedia = null;
            }
            else
            {


                currentMedia = PlayList.Last();
                this.i = 2;
                string titolo = currentMedia.title;

                Console.WriteLine("Riproduzione  di: " + titolo);

            }
        }

    }
}
