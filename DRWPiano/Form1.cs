using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Runtime.InteropServices;

namespace DRWPiano
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        public Form1()
        {
            InitializeComponent();
        }
        public enum notes
        {
            DO = 131, DOs = 139, RE = 147, REs = 156, MI = 165, FA = 175, FAs = 185, SOL = 196,
            SOLs = 207, LA =220 , LAs = 234, SI = 247,
            DO2 = 262, DO2s = 277, RE2 = 294, RE2s = 311, MI2 = 330, FA2 = 349, FA2s = 370, SOL2 = 392,
            SOL2s = 415, LA2 = 440, LA2s = 466, SI2 = 494,
            DO3 = 523, DO3s = 554, RE3 = 587, RE3s = 622, MI3 = 659, FA3 = 698, FA3s = 740, SOL3 = 784,
            SOL3s = 831, LA3 = 880, LA3s = 932, SI3 = 988
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1': Beep((int)notes.DO, 200); this.statusStrip1.Items[0].Text = "DO"; break;
                case '2': Beep((int)notes.DOs, 200); this.statusStrip1.Items[0].Text = "DOs"; break;
                case '3': Beep((int)notes.RE, 200); this.statusStrip1.Items[0].Text = "RE"; break;
                case '4': Beep((int)notes.REs, 200); this.statusStrip1.Items[0].Text = "REs"; break;
                case '5': Beep((int)notes.MI, 200); this.statusStrip1.Items[0].Text = "MI"; break;
                case '6': Beep((int)notes.FA, 200); this.statusStrip1.Items[0].Text = "FA"; break;
                case '7': Beep((int)notes.FAs, 200); this.statusStrip1.Items[0].Text = "FAs"; break;
                case '8': Beep((int)notes.SOL, 200); this.statusStrip1.Items[0].Text = "SOL"; break;
                case '9': Beep((int)notes.SOLs, 200); this.statusStrip1.Items[0].Text = "SOLs"; break;
                case '0': Beep((int)notes.LA, 200); this.statusStrip1.Items[0].Text = "LA"; break;
                case '-': Beep((int)notes.LAs, 200); this.statusStrip1.Items[0].Text = "LAs"; break;
                case '=': Beep((int)notes.SI, 200); this.statusStrip1.Items[0].Text = "SI"; break;
                case 'q': Beep((int)notes.DO2, 200); this.statusStrip1.Items[0].Text = "DO2"; break;
                case 'w': Beep((int)notes.DO2s, 200); this.statusStrip1.Items[0].Text = "DO2s"; break;
                case 'e': Beep((int)notes.RE2, 200); this.statusStrip1.Items[0].Text = "RE2"; break;
                case 'r': Beep((int)notes.RE2s, 200); this.statusStrip1.Items[0].Text = "RE2s"; break;
                case 't': Beep((int)notes.MI2, 200); this.statusStrip1.Items[0].Text = "MI2"; break;
                case 'y': Beep((int)notes.FA2, 200); this.statusStrip1.Items[0].Text = "FA2"; break;
                case 'u': Beep((int)notes.FA2s, 200); this.statusStrip1.Items[0].Text = "FA2s"; break;
                case 'i': Beep((int)notes.SOL2, 200); this.statusStrip1.Items[0].Text = "SOL2"; break;
                case 'o': Beep((int)notes.SOL2s, 200); this.statusStrip1.Items[0].Text = "SOL2S"; break;
                case 'p': Beep((int)notes.LA2, 200); this.statusStrip1.Items[0].Text = "LA2"; break;
                case '[': Beep((int)notes.LA2s, 200); this.statusStrip1.Items[0].Text = "LA2s"; break;
                case ']': Beep((int)notes.SI2, 200); this.statusStrip1.Items[0].Text = "SI2"; break;
                case 'a': Beep((int)notes.DO3, 200); this.statusStrip1.Items[0].Text = "DO3"; break;
                case 's': Beep((int)notes.DO3s, 200); this.statusStrip1.Items[0].Text = "DO3s"; break;
                case 'd': Beep((int)notes.RE3, 200); this.statusStrip1.Items[0].Text = "RE3"; break;
                case 'f': Beep((int)notes.RE3s, 200); this.statusStrip1.Items[0].Text = "RE3s"; break;
                case 'g': Beep((int)notes.MI3, 200); this.statusStrip1.Items[0].Text = "MI3"; break;
                case 'h': Beep((int)notes.FA3, 200); this.statusStrip1.Items[0].Text = "FA3"; break;
                case 'j': Beep((int)notes.FA3s, 200); this.statusStrip1.Items[0].Text = "FA3s"; break;
                case 'k': Beep((int)notes.SOL3, 200); this.statusStrip1.Items[0].Text = "SOL3"; break;
                case 'l': Beep((int)notes.SOL3s, 200); this.statusStrip1.Items[0].Text = "SOL3s"; break;
                case 'c': Beep((int)notes.LA3, 200); this.statusStrip1.Items[0].Text = "LA3"; break;
                case 'v': Beep((int)notes.LA3s, 200); this.statusStrip1.Items[0].Text = "LA3s"; break;
                case 'b': Beep((int)notes.SI3, 200); this.statusStrip1.Items[0].Text = "SI3"; break;
                case '/' :
                    {
                        Thread threadHB = new Thread(Happy); threadHB.Start(); break;
                    }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void OnButtons(object sender, EventArgs e)
        {
            string name = ((Button)sender).Text;
            switch (name)
            {
                case "DO": Beep((int)notes.DO, 200); this.statusStrip1.Items[0].Text = "DO"; break;
                case "DOs": Beep((int)notes.DOs, 200); this.statusStrip1.Items[0].Text = "DOs"; break;
                case "RE": Beep((int)notes.RE, 200); this.statusStrip1.Items[0].Text = "RE"; break;
                case "REs": Beep((int)notes.REs, 200); this.statusStrip1.Items[0].Text = "REs"; break;
                case "MI": Beep((int)notes.MI, 200); this.statusStrip1.Items[0].Text = "MI"; break;
                case "FA": Beep((int)notes.FA, 200); this.statusStrip1.Items[0].Text = "FA"; break;
                case "FAs": Beep((int)notes.FAs, 200); this.statusStrip1.Items[0].Text = "FAs"; break;
                case "SOL": Beep((int)notes.SOL, 200); this.statusStrip1.Items[0].Text = "SOL"; break;
                case "SOLs": Beep((int)notes.SOLs, 200); this.statusStrip1.Items[0].Text = "SOLs"; break;
                case "LA": Beep((int)notes.LA, 200); this.statusStrip1.Items[0].Text = "LA"; break;
                case "LAs": Beep((int)notes.LAs, 200); this.statusStrip1.Items[0].Text = "LAs"; break;
                case "SI": Beep((int)notes.SI, 200); this.statusStrip1.Items[0].Text = "SI"; break;
                case "DO2": Beep((int)notes.DO2, 200); this.statusStrip1.Items[0].Text = "DO2"; break;
                case "DO2s": Beep((int)notes.DO2s, 200); this.statusStrip1.Items[0].Text = "DO2s"; break;
                case "RE2": Beep((int)notes.RE2, 200); this.statusStrip1.Items[0].Text = "RE2"; break;
                case "RE2s": Beep((int)notes.RE2s, 200); this.statusStrip1.Items[0].Text = "RE2s"; break;
                case "MI2": Beep((int)notes.MI2, 200); this.statusStrip1.Items[0].Text = "MI2"; break;
                case "FA2": Beep((int)notes.FA2, 200); this.statusStrip1.Items[0].Text = "FA2"; break;
                case "FA2s": Beep((int)notes.FA2s, 200); this.statusStrip1.Items[0].Text = "FA2s"; break;
                case "SOL2": Beep((int)notes.SOL2, 200); this.statusStrip1.Items[0].Text = "SOL2"; break;
                case "SOL2s": Beep((int)notes.SOL2s, 200); this.statusStrip1.Items[0].Text = "SOL2S"; break;
                case "LA2": Beep((int)notes.LA2, 200); this.statusStrip1.Items[0].Text = "LA2"; break;
                case "LA2s": Beep((int)notes.LA2s, 200); this.statusStrip1.Items[0].Text = "LA2s"; break;
                case "SI2": Beep((int)notes.SI2, 200); this.statusStrip1.Items[0].Text = "SI2"; break;
                case "DO3": Beep((int)notes.DO3, 200); this.statusStrip1.Items[0].Text = "DO3"; break;
                case "DO3s": Beep((int)notes.DO3s, 200); this.statusStrip1.Items[0].Text = "DO3s"; break;
                case "RE3": Beep((int)notes.RE3, 200); this.statusStrip1.Items[0].Text = "RE3"; break;
                case "RE3s": Beep((int)notes.RE3s, 200); this.statusStrip1.Items[0].Text = "RE3s"; break;
                case "MI3": Beep((int)notes.MI3, 200); this.statusStrip1.Items[0].Text = "MI3"; break;
                case "FA3": Beep((int)notes.FA3, 200); this.statusStrip1.Items[0].Text = "FA3"; break;
                case "FA3s": Beep((int)notes.FA3s, 200); this.statusStrip1.Items[0].Text = "FA3s"; break;
                case "SOL3": Beep((int)notes.SOL3, 200); this.statusStrip1.Items[0].Text = "SOL3"; break;
                case "SOL3s": Beep((int)notes.SOL3s, 200); this.statusStrip1.Items[0].Text = "SOL3s"; break;
                case "LA3": Beep((int)notes.LA3, 200); this.statusStrip1.Items[0].Text = "LA3"; break;
                case "LA3s": Beep((int)notes.LA3s, 200); this.statusStrip1.Items[0].Text = "LA3s"; break;
                case "SI3": Beep((int)notes.SI3, 200); this.statusStrip1.Items[0].Text = "SI3"; break;
            }
        }
        private void Melody_HB(object sender, EventArgs e)
        {
            int hn = 1000;
            int qn = hn / 2;
            int en = hn / 4;
            int dqn = hn / 2 + hn / 4;
            int dhn = hn + hn / 2;


            object[] frequencyObj =
            {
                notes.SOL2, notes.SOL2, notes.LA2, notes.SOL2, notes.DO3, notes.SI2,
                notes.SOL2, notes.SOL2, notes.LA2, notes.SOL2, notes.RE3, notes.DO3,
                notes.SOL2, notes.SOL2, notes.SOL3, notes.MI3, notes.DO3, notes.SI2,
                notes.LA2, notes.FA3, notes.FA3, notes.MI3, notes.DO3, notes.RE3, notes.DO3
            };
            int[] durations =
            {
                dqn, qn, qn, qn, qn, hn, dqn, qn, qn, qn, qn, hn, dqn, qn, qn, qn, qn, dqn, qn, qn, en, 
                qn, qn, qn, hn 
            };
            for(int i = 0; i< frequencyObj.Length; i++)
            {
                Beep((int)frequencyObj[i], durations[i]);
            }
        }
        void Happy()
        {
            Melody_HB(this, new EventArgs());
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
