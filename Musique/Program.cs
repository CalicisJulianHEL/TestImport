using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Musique
{
    internal class Program
    {
        private static void Play(Note[] Melodie)
        {
            foreach (Note n in Melodie)
                if (n.FrequenceNote == Frequence.Silence)
                    Thread.Sleep((int)n.DureeNote);
                else
                    Console.Beep((int)n.FrequenceNote, (int)n.DureeNote);
        }

        private static void Main(string[] args)
        {
            Note[] SotW = {new Note(Frequence.Silence, Duree.Croche),
                 new Note(Frequence.Mi3, Duree.Blanche),
                 new Note(Frequence.Sol3, Duree.Blanche),
                 new Note(Frequence.La3, Duree.Blanche),
                 new Note(Frequence.Silence, Duree.Croche),
                 new Note(Frequence.Mi3, Duree.Blanche),
                 new Note(Frequence.Sol_3, Duree.Blanche),
                 new Note(Frequence.La_3, Duree.Noire),
                 new Note(Frequence.La3, Duree.Noire),
                 new Note(Frequence.Silence, Duree.Croche),
                 new Note(Frequence.Mi3, Duree.Blanche),
                 new Note(Frequence.Sol3, Duree.Blanche),
                 new Note(Frequence.La3, Duree.Blanche),
                 new Note(Frequence.Silence, Duree.Croche),
                 new Note(Frequence.Sol3, Duree.Blanche),
                 new Note(Frequence.Mi3, Duree.Blanche)};
            Play(SotW);
        }
    }
}