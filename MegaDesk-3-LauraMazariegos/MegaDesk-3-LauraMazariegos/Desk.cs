using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDesk_3_LauraMazariegos
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DeskFinish DeskFinish { get; set; }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

    }
    public enum DeskFinish
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    public enum Drawers
    {
        None = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7
    };

    public enum FinishTime
    {
        None = 0,
        Three = 3,
        Five = 5,
        Seven = 7
    };

}
