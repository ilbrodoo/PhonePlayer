using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhonePlayer
{
    internal class MusicPlayer : MediaPlayer
    {
        Player Player = new Player();
        public string autor;
        public MusicPlayer(string titolo, string autore) : base(titolo)
        {
            this.autor = autore;


        }
        public override void Print()
        {
          
            Console.WriteLine($"Titolo {base.title} - Autore {autor}");
        }
    }
}