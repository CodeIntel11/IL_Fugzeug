using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IL_Flugzeug
{
    public interface IVerkehrsflugzeug
    {
        bool getLooping();
        int getAnzahlPassagiere();
        int setAnzahlPassagiere(string anzahl);
    }
}