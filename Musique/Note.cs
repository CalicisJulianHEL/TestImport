using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique
{
    internal enum Frequence
    {
        Silence = 0,
        Do1 = 65, Do_1 = 69, Re1 = 73, Re_1 = 78, Mi1 = 82, Fa1 = 87, Fa_1 = 92,
        Sol1 = 98, Sol_1 = 104, La1 = 110, La_1 = 117, Si1 = 123,
        Do2 = 131, Do_2 = 139, Re2 = 147, Re_2 = 156, Mi2 = 165, Fa2 = 175, Fa_2 = 185,
        Sol2 = 196, Sol_2 = 208, La2 = 220, La_2 = 233, Si2 = 247,
        Do3 = 262, Do_3 = 277, Re3 = 294, Re_3 = 311, Mi3 = 330, Fa3 = 349, Fa_3 = 370,
        Sol3 = 392, Sol_3 = 415, La3 = 440, La_3 = 466, Si3 = 494,
        Do4 = 523, Do_4 = 554, Re4 = 587, Re_4 = 622, Mi4 = 659, Fa4 = 698, Fa_4 = 740,
        Sol4 = 784, Sol_4 = 831, La4 = 880, La_4 = 932, Si4 = 988,
        Do5 = 1046, Do_5 = 1109, Re5 = 1175, Re_5 = 1245, Mi5 = 1319, Fa5 = 1397, Fa_5 = 1480,
        Sol5 = 1568, Sol_5 = 1661, La5 = 1760, La_5 = 1865, Si5 = 1976,
        Do6 = 2093, Do_6 = 2217, Re6 = 2349, Re_6 = 2489, Mi6 = 2637, Fa6 = 2794, Fa_6 = 2960,
        Sol6 = 3136, Sol_6 = 3322, La6 = 3520, La_6 = 3729, Si6 = 3951,
        Do7 = 4186, Do_7 = 4435, Re7 = 4699, Re_7 = 4978, Mi7 = 5274, Fa7 = 5588, Fa_7 = 5920,
        Sol7 = 6272, Sol_7 = 6645, La7 = 7040, La_7 = 7459, Si7 = 7902,
    };

    internal enum Duree
    { Ronde = 1600, Blanche = Ronde / 2, Noire = Blanche / 2, Croche = Noire / 2, DoubleCroche = Croche / 2 };

    internal class Note
    {
        private Frequence ValFrequence;
        private Duree ValDuree;

        public Note(Frequence frequence, Duree duree)
        {
            ValFrequence = frequence;
            ValDuree = duree;
        }

        public Frequence FrequenceNote { get { return ValFrequence; } }
        public Duree DureeNote { get { return ValDuree; } }
    }
}