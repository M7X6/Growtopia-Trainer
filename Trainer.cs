using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Input;
using Memory;
using System.Runtime.InteropServices;
using System.Diagnostics;

// THIS SOURCE IS MADE BY M7#1337, PLEASE DO NOT SELL OR SKID THIS SOURCE.
// IF YOU BOUGHT THIS SOURCE FROM SOMEONE YOU GOT SCAMMED, ITS 100% FREE!

namespace Siao_is_a_potato
{

    public partial class Trainer : MaterialForm
    {
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private readonly MaterialSkinManager materialSkinManager2 = MaterialSkinManager.Instance;
        Mem m = new Mem();
        public Trainer()
        {
            InitializeComponent();
            Theme();
        }
        public void Theme()
        {
            materialSkinManager2.AddFormToManage(this);
            materialSkinManager2.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager2.ColorScheme = new ColorScheme(
           Primary.BlueGrey600, Primary.BlueGrey900,
           Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Trainer_Load(object sender, EventArgs e)
        {
            try     
            {
                if (m.OpenProcess("growtopia"))
                {
                    MessageBox.Show("Im Not Responsible For Any Damage/Bans, There Are Features That Gonna Ban You!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Enabled = true;
                    this.Text = "M7-Trainer (RUNNING)";
                    m.WriteMemory(Program.Antiban, "bytes", "74 08");
                }
                else{
                    this.Enabled = false;
                    this.Close();
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void Func_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.S))
            {
                m.WriteMemory(Program.ModFlyV1, "bytes", "74 5D");
            }
            else
            {
                m.WriteMemory(Program.ModFlyV1, "bytes", "75 5D");
            }
        }

        private void ModFlyV1_CheckedChanged(object sender, EventArgs e)
        {
            if (ModFlyV1.Checked)
            {
                ModFly.Start();
            }
            else
            {
                ModFly.Stop();
                m.WriteMemory(Program.ModFlyV1, "bytes", "74 5D");
            }
        }

        private void GModeV1_CheckedChanged(object sender, EventArgs e)
        {
            if (GModeV1.Checked)
            {
                ModFly.Start();
                m.WriteMemory(Program.NoClip, "bytes", "90 90");
                m.WriteMemory(Program.AntiRes, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(Program.NoClip, "bytes", "75 0B");
                m.WriteMemory(Program.AntiRes, "bytes", "4F 6E");
                ModFly.Stop();
                m.WriteMemory(Program.ModFlyV1, "bytes", "74 5D");
            }
        }

        private void RGB_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            siao.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void topmost_CheckedChanged(object sender, EventArgs e)
        {
            if (topmost.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void AutoRes_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRes.Checked)
            {
                m.WriteMemory(Program.AutoRes, "bytes", "74 0B");
            }
            else
            {
                m.WriteMemory(Program.AutoRes, "bytes", "75 0B");
            }
        }

        private void NoClip_CheckedChanged(object sender, EventArgs e)
        {
            if (NoClip.Checked)
            {
                m.WriteMemory(Program.NoClip, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(Program.NoClip, "bytes", "75 0B");
            }
        }

        private void AntiRes_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiRes.Checked)
            {
                m.WriteMemory(Program.AntiRes, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(Program.AntiRes, "bytes", "4F 6E");
            }
        }

        private void ModZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (ModZoom.Checked)
            {
                m.WriteMemory(Program.ModZoom, "bytes", "74 13");
            }
            else
            {
                m.WriteMemory(Program.ModZoom, "bytes", "75 13");
            }
        }

        private void Airseed_CheckedChanged(object sender, EventArgs e)
        {
            if (Airseed.Checked)
            {
                m.WriteMemory(Program.AirSeed, "bytes", "0F 84 3C FE FF FF");
            }
            else
            {
                m.WriteMemory(Program.AirSeed, "bytes", "0F 85 3C FE FF FF");
            }
        }

        private void AntiPb_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiPb.Checked)
            {
                m.WriteMemory(Program.AntiPB, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(Program.AntiPB, "bytes", "E8 17 EF FD FF");
            }
        }

        private void OneHit_CheckedChanged(object sender, EventArgs e)
        {
            if (OneHit.Checked)
            {
                m.WriteMemory(Program.OneHit, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(Program.OneHit, "bytes", "E8 F6 E4 C9 FF");
            }
        }

        private void Ltitle_CheckedChanged(object sender, EventArgs e)
        {
            if (Ltitle.Checked)
            {
                m.WriteMemory(Program.Ltitle, "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(Program.Ltitle, "bytes", "48 8D 15 D9 9F 5F 00");
            }
        }

        private void GhostEffect_CheckedChanged(object sender, EventArgs e)
        {
            if (GhostEffect.Checked)
            {
                m.WriteMemory(Program.GhostEffect, "bytes", "74 58");
            }
            else
            {
                m.WriteMemory(Program.GhostEffect, "bytes", "75 58");
            }
        }

        private void BatEffect_CheckedChanged(object sender, EventArgs e)
        {
            if (BatEffect.Checked)
            {
                m.WriteMemory(Program.BatEffect, "bytes", "75 05");
            }
            else
            {
                m.WriteMemory(Program.BatEffect, "bytes", "74 05");
            }
        }

        private void AllInvis_CheckedChanged(object sender, EventArgs e)
        {
            if (AllInvis.Checked)
            {
                m.WriteMemory(Program.AllInvis, "bytes", "74 40");
            }
            else
            {
                m.WriteMemory(Program.AllInvis, "bytes", "75 40");
            }
        }

        private void PlaceEffect_CheckedChanged(object sender, EventArgs e)
        {
            if (PlaceEffect.Checked)
            {
                m.WriteMemory(Program.AntiPB, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(Program.AntiPB, "bytes", "E8 17 EF FD FF");
            }
        }

        private void NoName_CheckedChanged(object sender, EventArgs e)
        {
            if (NoName.Checked)
            {
                m.WriteMemory(Program.NoName, "bytes", "74 13");
            }
            else
            {
                m.WriteMemory(Program.NoName, "bytes", "75 13");
            }
        }

        private void GrowZ_CheckedChanged(object sender, EventArgs e)
        {
            if (GrowZ.Checked)
            {
                m.WriteMemory(Program.GrowZ, "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory(Program.GrowZ, "bytes", "F3 0F 5C D1");
            }
        }

        private void antiwater_CheckedChanged(object sender, EventArgs e)
        {
            if (antiwater.Checked)
            {
                m.WriteMemory(Program.AntiWater, "bytes", "EB 22");
            }
            else 
            {
                m.WriteMemory(Program.AntiWater, "bytes", "74 22");
            }
        }

        private void antiglue_CheckedChanged(object sender, EventArgs e)
        {
            if (antiglue.Checked)
            {
                m.WriteMemory(Program.AntiGlue, "bytes", "EB 29");
            }
            else
            {
                m.WriteMemory(Program.AntiGlue, "bytes", "74 29");
            }
        }

        private void antibounce_CheckedChanged(object sender, EventArgs e)
        {
            if (antibounce.Checked)
            {
                m.WriteMemory(Program.AntibounceV1, "bytes", "E9 04 01 00 00 00");
            }
            else
            {
                m.WriteMemory(Program.AntibounceV1, "bytes", "0F 84 03 01 00 00");
            }
        }

        private void anticheck_CheckedChanged(object sender, EventArgs e)
        {
            if (anticheck.Checked)
            {
                m.WriteMemory(Program.AntiCheckpoint, "bytes", "EB 3E");
            }
            else
            {
                m.WriteMemory(Program.AntiCheckpoint, "bytes", "74 3E");
            }
        }

        private void antiportal_CheckedChanged(object sender, EventArgs e)
        {
            if (antiportal.Checked)
            {
                m.WriteMemory(Program.AntiPortal, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(Program.AntiPortal, "bytes", "74 1C");
            }
        }

        private void Spam_CheckedChanged(object sender, EventArgs e)
        {         
            if (Spam.Checked)
            {
                Spammer.Start();
            }
            else
            {
                Spammer.Stop();
            }
        }

        private void Spammer_Tick(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcessesByName("Growtopia"))
            {
                foreach (char text in TxtSpam.Text)
                {
                   IntPtr edit = p.MainWindowHandle;
                   const uint WM_KEYDOWN = 0x100;
                   const uint WM_KEYUP = 0x0101;
                   foreach (char c in TxtSpam.Text)
                   {
                      PostMessage(edit, WM_KEYDOWN, (IntPtr)(c), IntPtr.Zero);
                   }
                    
                }
                   
            }
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            Spammer.Interval = materialSlider1.Value;
        }
    }
}
