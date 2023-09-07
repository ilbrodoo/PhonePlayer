using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePlayer
{
    public abstract class MediaPlayer
    {
        
        public string title;
        
        public MediaPlayer(string title) 
        { 
            this.title = title;
          
        }
        public abstract void Print();

    }
}
