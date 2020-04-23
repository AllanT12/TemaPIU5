using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    [Flags]
    public enum Dotari
    {
        WIFI=1,
        Parcare=2,
        Restaurant=4
    }
    public enum Climat
    {
        Mediteranian = 1,
        Ecuatoriala = 2,
        Subtropical = 3,
        Subpolar = 4,
        Polar = 5
    };
    public enum Distanta
    {
        Mare=1,
        Medie=2,
        Mica=3
    };
}
