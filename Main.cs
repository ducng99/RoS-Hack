using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace TheCheat
{
    public struct Vector2
    {
        public float X;
        public float Y;
    }
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;
    }
    public struct Vector4
    {
        public float W;
        public float X;
        public float Y;
        public float Z;
    }
    public class Main : Form
    {
        static Dictionary<int, string> items = new Dictionary<int, string>()
        {
            {0, "Nothing"},
            {1, "Lv 1 helmet"},
            {2, "Lv 2 helmet"},
            {3, "Lv 3 helmet"},
            {5, "Lv 1 Armor"},
            {6, "Lv 2 Armor"},
            {7, "Lv 3 Armor"},
            {8, "Lv 1 Backpack"},
            {9, "Lv 2 Backpack"},
            {10, "Lv 3 Backpack"},
            {19, "Ghillie Suit"},
            {50, "Fuel Barrel"},
            {101, "Bandage"},
            {102, "Med Kit"},
            {103, "First Aid Kit"},
            {105, "Sports Drink"},
            {106, "Cardio Tonic"},
            {1001, "M4A1 Rifle"},
            {1002, "AKM Rifle"},
            {1003, "M870 SG"},
            {1004, "M1887 SG"},
            {1005, "AA12 SG"},
            {1006, "AWM SR"},
            {1007, "Barett SR"},
            {1008, "M249 MG"},
            {1009, "M14EBR Rifle"},
            {1010, "AR15 Rifle"},
            {1011, "MP7 SMG"},
            {1012, "PP19 SMG"},
            {1013, "Thompson SMG"},
            {1014, "G18C Pistol"},
            {1015, "Desert Eagle"},
            {1017, "Vector"},
            {1018, "P90 SMG"},
            {1019, "SAIGA-12 Shotgun"},
            {1020, "WRO Hunting Rifle"},
            {1021, "SVD SR"},
            {1022, "M110 Sniper Rifle"},
            {1023, "ACR Rifle"},
            {1024, "AN94 Rifle"},
            {1025, "MP5 SMG"},
            {1026, "AUG Rifle"},
            {1027, "QBU Sniper Rifle"},
            {1031, "RPG Rocket Tube"},
            {1101, "SG Ammo"},
            {1102, "Rifle Ammo"},
            {1103, "SR Ammo"},
            {1104, "SMG Ammo"},
            {1105, "Pistol Ammo"},
            {1106, "RPG Ammo"},
            {1201, "Rifle Silencer"},
            {1202, "SR Silence"},
            {1204, "SMG Silencer"},
            {1211, "Rifle Compensator"},
            {1212, "SR Compensator"},
            {1213, "SMG Compensator"},
            {1221, "Rifle Flash Hider"},
            {1222, "SR Flash Hider"},
            {1223, "SMG Smoke Hider"},
            {1231, "SG Choke"},
            {1241, "Triangle Grip"},
            {1242, "Vertical Foregrip"},
            {1251, "Rifle QD-Mag"},
            {1252, "Rifle EX-Mag"},
            {1253, "Rifle EX-QD-Mag"},
            {1261, "SR Cheek Pad"},
            {1262, "Tactical Stock"},
            {1263, "SG Bullet Loop"},
            {1264, "SR EX-Mag"},
            {1265, "SR QD-Mag"},
            {1266, "SR EX-QD-Mag"},
            {1271, "Red Dot Sight"},
            {1272, "Holo-Sight"},
            {1273, "2x Scope"},
            {1274, "4x Scope"},
            {1275, "8x Scope"},
            {1276, "SMG QD-Mag"},
            {1277, "SMG EX-Mag"},
            {1278, "SMG QD-EX-Mag"},
            {1279, "Collapsible Stock"},
            {1303, "Crowbar"},
            {1306, "Frying Pan"},
            {1307, "Rubber Chicken"},
            {1401, "Grenade"},
            {1402, "Stun Grenade"},
            {1403, "Smoke Grenade"},
            {1404, "Molotov Cocktail"},
            {1405, "Chicken Grenade"},
            {1406, "Flash Grenade"}
        };
        List<string> item = new List<string>(items.Values);
        Menu menuGUI = new Menu();
        Process ros_p;
        public static int height = -15;
        public string WINDOW_NAME="null";
        public static int range = 400;
        public static int fov = 100;
        public static int localPlayer;
        public static int w = -1;//310;
        public static int scope = 0;

        private float dist = 0, equation0, equation1;
        private int enemyHP, pose;
        Vector2 center = new Vector2();
        Vector2 aim = new Vector2();
        bool aimbot_ok;
        Task draw;
        static CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token = tokenSource.Token;

        public static Vector3 MyPosition = new Vector3();
        public static Pen greenPen = new Pen(Color.Green, 2);
        public static Pen Dpen = new Pen(new SolidBrush(Color.Chartreuse));
        public Font font = new Font(Control.DefaultFont, FontStyle.Bold);
        public Main()
        {
            try
            {
                ros_p = Process.GetProcessesByName("ros")[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Game Not Found", "Please Start Rules of Survival");
                Close();
            }
            InitializeComponent();
        }
        
        [DllImport("User32.dll")]
        private static extern bool GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, long dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out Main.RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        private void Main_Load(object sender, EventArgs e)
        {
            DialogResult fc = MessageBox.Show("Enable Fullscreen?", "RoS", MessageBoxButtons.YesNo);
            if (fc == DialogResult.Yes)
            {
                SetWindowLong(ros_p.MainWindowHandle, -16, 0x80000000L + 0x01000000L + 0x10000000L);
                SetWindowPos(ros_p.MainWindowHandle, IntPtr.Zero, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 0x0040);
            }
            TopMost = true;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
            Mem.Initialize(ros_p);
            SetWindowLong(Handle, -20, GetWindowLong(Handle, -20) | 524288 | 32);
            draw = Task.Factory.StartNew(async () =>
                {
                    await Thread();
                    token.ThrowIfCancellationRequested();
                }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            Task.Factory.StartNew(() => HotKey(), CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            Task.Factory.StartNew(() => Aimbot(), CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            menuGUI.Show();
        }

        public async Task Thread()
        {
            Graphics graphics = CreateGraphics();
            int Adress1, Adress2, num2, nameLen;
            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics drawnawbrudda = Graphics.FromImage(bitmap);
            Point bottom = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2 + 200);
            int Entity, team_s, team_p, visible;
            string str, pname;
            float height_aim;
            bool Player, Bot, Vehicle, Item, Loot, Plane;

            while (true)
            {
                center.X = Width / 2;
                center.Y = (Height / 2) + 20;
                drawnawbrudda.Clear(Color.Black);
                localPlayer = Mem.ReadMemory<int>(Mem.BaseAddress + Offsets.LocalPlayer);
                Adress1 = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.BaseAddress + Offsets.Client) + Offsets.m_ppObjects);
                Adress2 = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Adress1))));
                num2 = Mem.ReadMemory<int>(Adress1 + 4);
                while (Adress2 != num2 && Adress2 != localPlayer)
                {
                    MyPosition.X = Mem.ReadMemory<float>(localPlayer + 16);
                    MyPosition.Y = Mem.ReadMemory<float>(localPlayer + 16 + 4);
                    MyPosition.Z = Mem.ReadMemory<float>(localPlayer + 16 + 8);
                    Entity = Mem.ReadMemory<int>(Adress2 + 12);
                    str = Mem.ReadString(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x4) + 0xC), 14);
                    Vector3 EnemyPos = Mem.ReadMemory<Vector3>(Entity + 16);
                    nameLen = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x380) + 0x8);
                    if (nameLen > 0 && nameLen <= 16)
                    {
                        pname = Mem.ReadString(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x380) + 0x8 + 0xC, nameLen);
                    }
                    else pname = "Player";
                    enemyHP = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x98) + 0x8);
                    pose = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x17C) + 0x8);
                    team_s = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(localPlayer + 0x100) + 0x14) + 0x578) + 0x8);
                    team_p = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x134) + 0x8);
                    //visible = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x6A4) + 0x8);
                    Player = str.Contains("Avatar");
                    Bot = str.Contains("Robot");
                    Vehicle = str.Contains("Land");
                    Item = str.Contains("DtsProp");
                    Loot = str.Contains("DtsPlayerHerit");
                    Plane = str.Contains("Plane");
                    Adress2 = Mem.ReadMemory<int>(Adress2);

                    if (Settings.ShowFOV)
                    {
                        Rectangle rect = new Rectangle((int)center.X - fov, ((int)center.Y) - fov, fov * 2, fov * 2);
                        drawnawbrudda.DrawEllipse(greenPen, rect);
                    }

                    if (Maths.WorldToScreen(EnemyPos, out Vector2 target, Width, Height))
                    {
                        dist = Maths.GetDistance(MyPosition, EnemyPos, 10);
                        if (Player && !Bot && enemyHP > 0 && dist > 0)
                        {
                            switch (scope)
                            {
                                case 0:
                                    equation0 = (float)Math.Pow(1.04975, -dist + 112.91);
                                    equation1 = (float)Math.Pow(1.04266, -dist + 108.898);
                                    break;
                                case 1:
                                    equation0 = (float)Math.Pow(1.04975, -(dist / 2) + 112.91) *1.5f;
                                    equation1 = (float)Math.Pow(1.04266, -(dist / 2) + 108.898) *1.5f;
                                    break;
                                case 2:
                                    equation0 = (float)Math.Pow(1.04975, -(dist / 4) + 112.91) *1.5f;
                                    equation1 = (float)Math.Pow(1.04266, -(dist / 4) + 108.898) *1.5f;
                                    break;
                                case 3:
                                    equation0 = (float)Math.Pow(1.04975, -(dist / 8) + 112.91) *1.5f;
                                    equation1 = (float)Math.Pow(1.04266, -(dist / 8) + 108.898) *1.5f;
                                    break;
                                default:
                                    equation0 = (float)Math.Pow(1.04975, -dist + 112.91);
                                    equation1 = (float)Math.Pow(1.04266, -dist + 108.898);
                                    break;
                            }
                            if (Maths.InsideCircle((int)center.X, (int)center.Y, fov, (int)target.X, (int)target.Y) && dist > 0 && dist <= range && Settings.Aimbot)
                            {
                                aim = target;
                                aimbot_ok = true;
                            }
                            else
                            {
                                aimbot_ok = false;
                            }
                            if (Settings.ESP)
                            {
                                if (Settings.PlayerESP)
                                {
                                    drawnawbrudda.DrawString(pname, font, Brushes.Red, target.X, target.Y - 20f);
                                }
                                if (Settings.PlayerHealth)
                                {
                                    drawnawbrudda.DrawString("[HP:" + enemyHP + "]", font, Brushes.Aqua, target.X - 15f, target.Y + 15f);
                                }
                                if (Settings.PlayerDistance)
                                {
                                    if (dist > 100)
                                    {
                                        drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.White, target.X - 10f, target.Y + 30f);
                                    }
                                    else
                                    {
                                        drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.Red, target.X - 10f, target.Y + 30f);
                                    }
                                }
                                if (Settings.PlayerBox)
                                {
                                    float width = 9f / (dist / 100f);
                                    switch (pose)
                                    {
                                        case 0:
                                            height_aim = equation0;
                                            break;
                                        case 1:
                                            height_aim = equation1;
                                            break;
                                        case 2:
                                            height_aim = equation1 + 5;
                                            break;
                                        default:
                                            height_aim = equation1;
                                            break;
                                    }
                                    drawnawbrudda.DrawRectangle(Dpen, target.X - width, target.Y - height_aim, width * 2, height_aim);
                                }
                                if (Settings.PlayerLines)
                                {
                                    if (team_p != team_s) drawnawbrudda.DrawLine(Dpen, bottom, new Point((int)target.X, (int)target.Y));
                                }
                            }
                            if (Settings.Assassinate)
                            {
                                if (dist > 0 && dist < range && Maths.InsideCircle((int)center.X, (int)center.Y, fov, (int)target.X, (int)target.Y))
                                {
                                    while (Settings.Assassinate && enemyHP > 0)
                                    {
                                        enemyHP = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 256) + 20) + 152) + 8);
                                        if (EnemyPos.X > MyPosition.X)
                                        {
                                            Mem.WriteMemory<float>(localPlayer + 16, EnemyPos.X - 15);
                                        }
                                        else
                                        {
                                            Mem.WriteMemory<float>(localPlayer + 16, EnemyPos.X + 15);
                                        }
                                        if (EnemyPos.Z > MyPosition.Z)
                                        {
                                            Mem.WriteMemory<float>(localPlayer + 16 + 8, EnemyPos.Z - 12);
                                        }
                                        else
                                        {
                                            Mem.WriteMemory<float>(localPlayer + 16 + 8, EnemyPos.Z + 12);
                                        }
                                        Mem.WriteMemory<float>(localPlayer + 16 + 4, EnemyPos.Y);
                                    }
                                    menuGUI.assassinToggle.Checked = false;
                                }
                            }
                            if (Settings.Magneto)
                            {
                                Mem.WriteMemory<float>(Entity + 16, MyPosition.X);
                                Mem.WriteMemory<float>(Entity + 16 + 4, MyPosition.Y - 20);
                                Mem.WriteMemory<float>(Entity + 16 + 8, MyPosition.Z);
                            }
                        }
                        if (Settings.ESP)
                        {
                            if (Settings.Debug && Maths.InsideCircle((int)center.X, (int)center.Y, fov, (int)target.X, (int)target.Y))
                            {
                                //drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.White, target.X - 10f, target.Y + 30f);
                                //drawnawbrudda.DrawString("[" + (target.Y - center.Y) + "]", font, Brushes.White, center.X - 10f, center.Y - 10f);
                                drawnawbrudda.DrawString(str, font, Brushes.White, target.X - 10f, target.Y - 15f);
                            }
                            if (Bot)
                            {
                                drawnawbrudda.DrawString("BOT", font, Brushes.Chartreuse, target.X, target.Y - 20f);
                            }
                            else if (Item)
                            {
                                int itemID = Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Entity + 0x100) + 0x14) + 0x2C) + 0x8);
                                items.TryGetValue(itemID, out string itemName);
                                if (Settings.ItemESP)
                                    drawnawbrudda.DrawString(itemName, font, Brushes.LightBlue, target.X - 10f, target.Y);
                                if (Settings.ItemDistance)
                                    drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.White, target.X - 10f, target.Y + 15f);
                            }
                            else if (Loot)
                            {
                                if (Settings.LootESP)
                                {
                                    drawnawbrudda.DrawString("LOOT", font, Brushes.Pink, target.X - 10f, target.Y);
                                }
                                if (Settings.LootDistance)
                                {
                                    drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.Chartreuse, target.X - 10f, target.Y + 15f);
                                }
                            }
                            else if (Vehicle)
                            {
                                if (Settings.VehicleESP && dist > 2)
                                    drawnawbrudda.DrawString("Vehicle", font, Brushes.Gold, target.X - 10f, target.Y);
                                if (Settings.VehicleDistance && dist > 2)
                                    drawnawbrudda.DrawString("[" + dist + "]", font, Brushes.White, target.X - 10f, target.Y + 15f);
                            }
                            else if (Plane)
                            {
                                drawnawbrudda.DrawString("PLANE", font, Brushes.Chocolate, target.X, target.Y - 20f);
                            }
                        }
                    }
                }
                graphics.DrawImage(bitmap, 0, 0);
                await Task.Delay(10);
            }
        }

        public async Task HotKey()
        {
            while (true)
            {
                if (Main.GetAsyncKeyState(Keys.Delete) && Main.GetAsyncKeyState(Keys.ControlKey))
                {
                    try
                    {
                        Close();
                    }
                    catch (Exception) { }
                    await Task.Delay(200);
                }
                if (Main.GetAsyncKeyState(Keys.ControlKey) && Main.GetAsyncKeyState(Keys.End))
                {
                    try
                    {
                        ros_p.CloseMainWindow();
                    }
                    catch (Exception) { }
                    await Task.Delay(200);
                }
                if (Main.GetAsyncKeyState(Keys.Insert))
                {
                    if (menuGUI.IsShow)
                    {
                        menuGUI.Hide();
                        menuGUI.TopMost = false;
                        menuGUI.IsShow = false;
                    }
                    else
                    {
                        menuGUI.Show();
                        menuGUI.TopMost = true;
                        menuGUI.IsShow = true;
                    }
                    await Task.Delay(200);
                }
                if (Main.GetAsyncKeyState(Keys.MButton))
                {
                    menuGUI.aimbotToggle.Checked = !menuGUI.aimbotToggle.Checked;
                    await Task.Delay(200);
                }
                if (Settings.NoClip)
                {
                    if (Main.GetAsyncKeyState(Keys.NumPad8))
                    {
                        menuGUI.X += 50;
                        await Task.Delay(200);
                    }
                    if (Main.GetAsyncKeyState(Keys.NumPad2))
                    {
                        menuGUI.X -= 50;
                        await Task.Delay(200);
                    }
                    if (Main.GetAsyncKeyState(Keys.NumPad9))
                    {
                        menuGUI.Y += 50;
                        await Task.Delay(200);
                    }
                    if (Main.GetAsyncKeyState(Keys.NumPad3))
                    {
                        menuGUI.Y -= 50;
                        await Task.Delay(200);
                    }
                    if (Main.GetAsyncKeyState(Keys.NumPad6))
                    {
                        menuGUI.Z += 50;
                        await Task.Delay(200);
                    }
                    if (Main.GetAsyncKeyState(Keys.NumPad4))
                    {
                        menuGUI.Z -= 50;
                        await Task.Delay(200);
                    }
                    Mem.WriteMemory<float>(localPlayer + 16, menuGUI.X);
                    Mem.WriteMemory<float>(localPlayer + 16 + 4, menuGUI.Y);
                    Mem.WriteMemory<float>(localPlayer + 16 + 8, menuGUI.Z);
                }
                if (Main.GetAsyncKeyState(Keys.F1))
                {
                    menuGUI.assassinToggle.Checked = !menuGUI.assassinToggle.Checked;
                    await Task.Delay(200);
                }
                if (Main.GetAsyncKeyState(Keys.F2))
                {
                    menuGUI.magnetoToggle.Checked = !menuGUI.magnetoToggle.Checked;
                    await Task.Delay(200);
                }
                if (Main.GetAsyncKeyState(Keys.F8))
                {
                    tokenSource.Cancel();
                    await Task.Delay(200);
                }
            }
        }

        private async Task Aimbot()
        {
            while (true)
            {
                if (aimbot_ok)
                {
                    Vector2 aim2;
                    aim2.X = aim.X + w;
                    if (Settings.SmartAim)
                    {
                        switch (pose)
                        {
                            case 0:
                                aim2.Y = aim.Y - equation0;
                                break;
                            case 1:
                                aim2.Y = aim.Y - equation1;
                                break;
                            case 2:
                                aim2.Y = aim.Y + equation1;
                                break;
                            default:
                                aim2.Y = aim.Y;
                                break;
                        }
                    }
                    else
                    {
                        aim2.Y = aim.Y + height;
                    }
                    Cursor.Position = new Point((int)aim2.X, (int)aim2.Y);
                }
                await Task.Delay(50);
            }
        }
        
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(317, 797);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Opacity = 0.85D;
            this.Text = "Something";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
    }
}
