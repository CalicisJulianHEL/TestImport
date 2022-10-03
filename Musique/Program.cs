using System;
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
                 new Note(Frequence.Re3, Duree.Blanche),
                 new Note(Frequence.Re3, Duree.Blanche),
                 new Note(Frequence.Re4, Duree.Blanche),
                 new Note(Frequence.Sol3, Duree.Croche),
                 new Note(Frequence.Fa_3, Duree.Blanche)};
    }
  }
}
