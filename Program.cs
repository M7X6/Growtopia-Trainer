using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siao_is_a_potato
{
    internal static class Program
    {
        public static string Antiban = "base+55E1B9";
        public static string ModFlyV1 = "base+6C7597";
        public static string NoClip = "base+6B7545";
        public static string AntiRes = "base+C54298";
        public static string AutoRes = "base+6B7545";
        public static string Ltitle = "base+65A780";
        public static string ModZoom = "base+54E73F";
        public static string AirSeed = "base+56C9CF";
        public static string AntiPB = "base+56BF24";
        public static string OneHit = "base+56BEF5";
        public static string GrowZ = "base+666C01";
        public static string AntiWater = "base+666C12";
        public static string AntiGlue = "base+666CB5";
        public static string AntibounceV1 = "base+6C85AA";
        public static string AntiCheckpoint = "base+66A517";
        public static string AntiPortal = "base+66A48B";

        // --------------------- VISUALS -----------------------

        public static string GhostEffect = "base+213924";
        public static string BatEffect = "base+2139A3";
        public static string AllInvis = "base+22A602";
        public static string NoName = "base+65A93D";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Trainer());
        }
    }
}
