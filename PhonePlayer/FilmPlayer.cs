using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePlayer
{
    internal class FilmPlayer : MediaPlayer
    {
        Player Player = new Player();
        public string Regista;
        public FilmPlayer(string title, string regista) : base(title)
        {
            Regista = regista;
            
        }
        public override void Print()
        {
               
                Console.WriteLine($" Titolo {base.title} - Regista {Regista}");
           
        }
    }
}
