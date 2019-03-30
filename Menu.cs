using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCheat
{
    public partial class Menu : Form
    {
        public float X, Y, Z;
        public bool IsShow = true;
        public Menu()
        {
            InitializeComponent();
            TopMost = true;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            this.scopeList.SelectedIndex = 0;
        }

        private void playerCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = playerCheckbox.SelectedIndex;
            playerCheckbox.ClearSelected();
            switch (selected)
            {
                case 0:
                    Settings.PlayerESP = !Settings.PlayerESP;
                    break;
                case 1:
                    Settings.PlayerHealth = !Settings.PlayerHealth;
                    break;
                case 2:
                    Settings.PlayerDistance = !Settings.PlayerDistance;
                    break;
                case 3:
                    Settings.PlayerBox = !Settings.PlayerBox;
                    break;
                case 4:
                    Settings.PlayerLines = !Settings.PlayerLines;
                    break;
                default:
                    break;
            }
        }

        private void itemCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = itemCheckbox.SelectedIndex;
            itemCheckbox.ClearSelected();
            switch (selected)
            {
                case 0:
                    Settings.ItemESP = !Settings.ItemESP;
                    break;
                case 1:
                    Settings.ItemDistance = !Settings.ItemDistance;
                    break;
                default:
                    break;
            }
        }

        private void vehicleCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = vehicleCheckbox.SelectedIndex;
            vehicleCheckbox.ClearSelected();
            switch (selected)
            {
                case 0:
                    Settings.VehicleESP = !Settings.VehicleESP;
                    break;
                case 1:
                    Settings.VehicleDistance = !Settings.VehicleDistance;
                    break;
                default:
                    break;
            }
        }

        private void lootCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lootCheckbox.SelectedIndex;
            lootCheckbox.ClearSelected();
            switch (selected)
            {
                case 0:
                    Settings.LootESP = !Settings.LootESP;
                    break;
                case 1:
                    Settings.LootDistance = !Settings.LootDistance;
                    break;
                default:
                    break;
            }
        }

        private void aimbotToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Aimbot = !Settings.Aimbot;
        }

        private void smartaimToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SmartAim = !Settings.SmartAim;
            if (Settings.SmartAim)
            {
                heightValue.Enabled = false;
            }
            else
            {
                heightValue.Enabled = true;
            }
        }

        private void showfovToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ShowFOV = !Settings.ShowFOV;
        }

        private void rangeValue_ValueChanged(object sender, EventArgs e)
        {
            Main.range = (int)rangeValue.Value;
        }

        private void fovValue_ValueChanged(object sender, EventArgs e)
        {
            Main.fov = (int)fovValue.Value;
        }

        private void heightValue_ValueChanged(object sender, EventArgs e)
        {
            Main.height = (int)heightValue.Value;
        }

        private void charmsToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Charms = !Settings.Charms;
        }

        private void magnetoToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Magneto = !Settings.Magneto;
        }

        private void assassinToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Assassinate = !Settings.Assassinate;
        }

        private void debugToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Debug = !Settings.Debug;
        }

        private void scopeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.scope = scopeList.SelectedIndex;
        }

        private void noGrassToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (noGrassToggle.Checked)
            {
                Mem.WriteMemory<float>(Mem.BaseAddress + 0xc37f80, -243773.5938);
                Mem.WriteMemory<float>(Mem.BaseAddress + 0xc37fe5, -2.774539006E-32);
            }
            else
            {
                Mem.WriteMemory<float>(Mem.BaseAddress + 0xc37f80, -3.719689846);
                Mem.WriteMemory<float>(Mem.BaseAddress + 0xc37fe5, -4.233610543E-37);
            }
        }

        private void noclipToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.NoClip = !Settings.NoClip;
            if (Settings.NoClip)
            {
                X = Main.MyPosition.X;
                Y = Main.MyPosition.Y;
                Z = Main.MyPosition.Z;
            }
        }

        private void EspToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP = !Settings.ESP;
        }
    }
}
