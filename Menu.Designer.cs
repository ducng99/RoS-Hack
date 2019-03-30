using System;

namespace TheCheat
{
    public partial class Menu
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.heightText = new System.Windows.Forms.Label();
            this.heightValue = new System.Windows.Forms.NumericUpDown();
            this.nocoilToggle = new System.Windows.Forms.CheckBox();
            this.charmsToggle = new System.Windows.Forms.CheckBox();
            this.rangeText = new System.Windows.Forms.Label();
            this.rangeValue = new System.Windows.Forms.NumericUpDown();
            this.fovText = new System.Windows.Forms.Label();
            this.fovValue = new System.Windows.Forms.NumericUpDown();
            this.smartaimToggle = new System.Windows.Forms.CheckBox();
            this.showfovToggle = new System.Windows.Forms.CheckBox();
            this.aimbotToggle = new System.Windows.Forms.CheckBox();
            this.aimbotTitle = new System.Windows.Forms.Label();
            this.othersTitle = new System.Windows.Forms.Label();
            this.lootCheckbox = new System.Windows.Forms.CheckedListBox();
            this.espTitle = new System.Windows.Forms.Label();
            this.vehicleCheckbox = new System.Windows.Forms.CheckedListBox();
            this.itemCheckbox = new System.Windows.Forms.CheckedListBox();
            this.playerCheckbox = new System.Windows.Forms.CheckedListBox();
            this.title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scopeList = new System.Windows.Forms.ComboBox();
            this.EspToggle = new System.Windows.Forms.CheckBox();
            this.debugToggle = new System.Windows.Forms.CheckBox();
            this.magnetoToggle = new System.Windows.Forms.CheckBox();
            this.assassinToggle = new System.Windows.Forms.CheckBox();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.noGrassToggle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // heightText
            // 
            this.heightText.AutoSize = true;
            this.heightText.BackColor = System.Drawing.Color.Transparent;
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightText.ForeColor = System.Drawing.Color.White;
            this.heightText.Location = new System.Drawing.Point(22, 300);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(53, 17);
            this.heightText.TabIndex = 14;
            this.heightText.Text = "Height:";
            // 
            // heightValue
            // 
            this.heightValue.Enabled = false;
            this.heightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightValue.Location = new System.Drawing.Point(143, 298);
            this.heightValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(60, 23);
            this.heightValue.TabIndex = 13;
            this.heightValue.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.heightValue.ValueChanged += new System.EventHandler(this.heightValue_ValueChanged);
            // 
            // nocoilToggle
            // 
            this.nocoilToggle.AutoSize = true;
            this.nocoilToggle.BackColor = System.Drawing.Color.Transparent;
            this.nocoilToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nocoilToggle.ForeColor = System.Drawing.Color.White;
            this.nocoilToggle.Location = new System.Drawing.Point(4, 358);
            this.nocoilToggle.Name = "nocoilToggle";
            this.nocoilToggle.Size = new System.Drawing.Size(72, 21);
            this.nocoilToggle.TabIndex = 12;
            this.nocoilToggle.Text = "No Clip";
            this.nocoilToggle.UseVisualStyleBackColor = false;
            this.nocoilToggle.CheckedChanged += new System.EventHandler(this.noclipToggle_CheckedChanged);
            // 
            // charmsToggle
            // 
            this.charmsToggle.AutoSize = true;
            this.charmsToggle.BackColor = System.Drawing.Color.Transparent;
            this.charmsToggle.Enabled = false;
            this.charmsToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmsToggle.ForeColor = System.Drawing.Color.White;
            this.charmsToggle.Location = new System.Drawing.Point(141, 385);
            this.charmsToggle.Name = "charmsToggle";
            this.charmsToggle.Size = new System.Drawing.Size(75, 21);
            this.charmsToggle.TabIndex = 12;
            this.charmsToggle.Text = "Charms";
            this.charmsToggle.UseVisualStyleBackColor = false;
            this.charmsToggle.CheckedChanged += new System.EventHandler(this.charmsToggle_CheckedChanged);
            // 
            // rangeText
            // 
            this.rangeText.AutoSize = true;
            this.rangeText.BackColor = System.Drawing.Color.Transparent;
            this.rangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeText.ForeColor = System.Drawing.Color.White;
            this.rangeText.Location = new System.Drawing.Point(22, 235);
            this.rangeText.Name = "rangeText";
            this.rangeText.Size = new System.Drawing.Size(54, 17);
            this.rangeText.TabIndex = 11;
            this.rangeText.Text = "Range:";
            // 
            // rangeValue
            // 
            this.rangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeValue.Location = new System.Drawing.Point(143, 233);
            this.rangeValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.rangeValue.Name = "rangeValue";
            this.rangeValue.Size = new System.Drawing.Size(60, 23);
            this.rangeValue.TabIndex = 10;
            this.rangeValue.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.rangeValue.ValueChanged += new System.EventHandler(this.rangeValue_ValueChanged);
            // 
            // fovText
            // 
            this.fovText.AutoSize = true;
            this.fovText.BackColor = System.Drawing.Color.Transparent;
            this.fovText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovText.ForeColor = System.Drawing.Color.White;
            this.fovText.Location = new System.Drawing.Point(22, 267);
            this.fovText.Name = "fovText";
            this.fovText.Size = new System.Drawing.Size(40, 17);
            this.fovText.TabIndex = 9;
            this.fovText.Text = "FOV:";
            // 
            // fovValue
            // 
            this.fovValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovValue.Location = new System.Drawing.Point(143, 265);
            this.fovValue.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.fovValue.Name = "fovValue";
            this.fovValue.Size = new System.Drawing.Size(60, 23);
            this.fovValue.TabIndex = 8;
            this.fovValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fovValue.ValueChanged += new System.EventHandler(this.fovValue_ValueChanged);
            // 
            // smartaimToggle
            // 
            this.smartaimToggle.AutoSize = true;
            this.smartaimToggle.BackColor = System.Drawing.Color.Transparent;
            this.smartaimToggle.Checked = true;
            this.smartaimToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smartaimToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartaimToggle.ForeColor = System.Drawing.Color.White;
            this.smartaimToggle.Location = new System.Drawing.Point(3, 202);
            this.smartaimToggle.Name = "smartaimToggle";
            this.smartaimToggle.Size = new System.Drawing.Size(91, 21);
            this.smartaimToggle.TabIndex = 7;
            this.smartaimToggle.Text = "Smart Aim";
            this.smartaimToggle.UseVisualStyleBackColor = true;
            this.smartaimToggle.CheckedChanged += new System.EventHandler(this.smartaimToggle_CheckedChanged);
            // 
            // showfovToggle
            // 
            this.showfovToggle.AutoSize = true;
            this.showfovToggle.BackColor = System.Drawing.Color.Transparent;
            this.showfovToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showfovToggle.ForeColor = System.Drawing.Color.White;
            this.showfovToggle.Location = new System.Drawing.Point(143, 177);
            this.showfovToggle.Name = "showfovToggle";
            this.showfovToggle.Size = new System.Drawing.Size(93, 21);
            this.showfovToggle.TabIndex = 7;
            this.showfovToggle.Text = "Show FOV";
            this.showfovToggle.UseVisualStyleBackColor = false;
            this.showfovToggle.CheckedChanged += new System.EventHandler(this.showfovToggle_CheckedChanged);
            // 
            // aimbotToggle
            // 
            this.aimbotToggle.AutoSize = true;
            this.aimbotToggle.BackColor = System.Drawing.Color.Transparent;
            this.aimbotToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimbotToggle.ForeColor = System.Drawing.Color.White;
            this.aimbotToggle.Location = new System.Drawing.Point(3, 177);
            this.aimbotToggle.Name = "aimbotToggle";
            this.aimbotToggle.Size = new System.Drawing.Size(118, 21);
            this.aimbotToggle.TabIndex = 7;
            this.aimbotToggle.Text = "Aimbot Toggle";
            this.aimbotToggle.UseVisualStyleBackColor = false;
            this.aimbotToggle.CheckedChanged += new System.EventHandler(this.aimbotToggle_CheckedChanged);
            // 
            // aimbotTitle
            // 
            this.aimbotTitle.BackColor = System.Drawing.Color.DimGray;
            this.aimbotTitle.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimbotTitle.ForeColor = System.Drawing.Color.White;
            this.aimbotTitle.Location = new System.Drawing.Point(-1, 151);
            this.aimbotTitle.Name = "aimbotTitle";
            this.aimbotTitle.Size = new System.Drawing.Size(270, 22);
            this.aimbotTitle.TabIndex = 6;
            this.aimbotTitle.Text = "Aimbot Settings";
            // 
            // othersTitle
            // 
            this.othersTitle.BackColor = System.Drawing.Color.DimGray;
            this.othersTitle.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersTitle.ForeColor = System.Drawing.Color.White;
            this.othersTitle.Location = new System.Drawing.Point(-1, 333);
            this.othersTitle.Name = "othersTitle";
            this.othersTitle.Size = new System.Drawing.Size(270, 22);
            this.othersTitle.TabIndex = 5;
            this.othersTitle.Text = "Other Settings";
            // 
            // lootCheckbox
            // 
            this.lootCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lootCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lootCheckbox.CheckOnClick = true;
            this.lootCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootCheckbox.ForeColor = System.Drawing.Color.White;
            this.lootCheckbox.FormattingEnabled = true;
            this.lootCheckbox.Items.AddRange(new object[] {
            "Loot ESP",
            "Loot Distance"});
            this.lootCheckbox.Location = new System.Drawing.Point(141, 112);
            this.lootCheckbox.Name = "lootCheckbox";
            this.lootCheckbox.Size = new System.Drawing.Size(128, 36);
            this.lootCheckbox.TabIndex = 4;
            this.lootCheckbox.SelectedIndexChanged += new System.EventHandler(this.lootCheckbox_SelectedIndexChanged);
            // 
            // espTitle
            // 
            this.espTitle.BackColor = System.Drawing.Color.DimGray;
            this.espTitle.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espTitle.ForeColor = System.Drawing.Color.White;
            this.espTitle.Location = new System.Drawing.Point(0, 3);
            this.espTitle.Name = "espTitle";
            this.espTitle.Size = new System.Drawing.Size(270, 22);
            this.espTitle.TabIndex = 3;
            this.espTitle.Text = "ESP Settings";
            // 
            // vehicleCheckbox
            // 
            this.vehicleCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vehicleCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicleCheckbox.CheckOnClick = true;
            this.vehicleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCheckbox.ForeColor = System.Drawing.Color.White;
            this.vehicleCheckbox.FormattingEnabled = true;
            this.vehicleCheckbox.Items.AddRange(new object[] {
            "Vehicle ESP",
            "Vehicle Distance"});
            this.vehicleCheckbox.Location = new System.Drawing.Point(141, 28);
            this.vehicleCheckbox.Name = "vehicleCheckbox";
            this.vehicleCheckbox.Size = new System.Drawing.Size(128, 36);
            this.vehicleCheckbox.TabIndex = 2;
            this.vehicleCheckbox.SelectedIndexChanged += new System.EventHandler(this.vehicleCheckbox_SelectedIndexChanged);
            // 
            // itemCheckbox
            // 
            this.itemCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemCheckbox.CheckOnClick = true;
            this.itemCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCheckbox.ForeColor = System.Drawing.Color.White;
            this.itemCheckbox.FormattingEnabled = true;
            this.itemCheckbox.Items.AddRange(new object[] {
            "Item ESP",
            "Item Distance"});
            this.itemCheckbox.Location = new System.Drawing.Point(141, 70);
            this.itemCheckbox.Name = "itemCheckbox";
            this.itemCheckbox.Size = new System.Drawing.Size(113, 36);
            this.itemCheckbox.TabIndex = 1;
            this.itemCheckbox.SelectedIndexChanged += new System.EventHandler(this.itemCheckbox_SelectedIndexChanged);
            // 
            // playerCheckbox
            // 
            this.playerCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerCheckbox.CheckOnClick = true;
            this.playerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCheckbox.ForeColor = System.Drawing.Color.White;
            this.playerCheckbox.FormattingEnabled = true;
            this.playerCheckbox.Items.AddRange(new object[] {
            "Player Name",
            "Player HP",
            "Player Distance",
            "Player Box",
            "Player Lines"});
            this.playerCheckbox.Location = new System.Drawing.Point(2, 28);
            this.playerCheckbox.Name = "playerCheckbox";
            this.playerCheckbox.Size = new System.Drawing.Size(128, 90);
            this.playerCheckbox.TabIndex = 0;
            this.playerCheckbox.SelectedIndexChanged += new System.EventHandler(this.playerCheckbox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(49, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 31);
            this.title.TabIndex = 1;
            this.title.Text = "RoS ReHack";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Maroon;
            this.splitContainer1.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.title);
            this.splitContainer1.Panel1MinSize = 31;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.noGrassToggle);
            this.splitContainer1.Panel2.Controls.Add(this.scopeList);
            this.splitContainer1.Panel2.Controls.Add(this.EspToggle);
            this.splitContainer1.Panel2.Controls.Add(this.heightText);
            this.splitContainer1.Panel2.Controls.Add(this.heightValue);
            this.splitContainer1.Panel2.Controls.Add(this.nocoilToggle);
            this.splitContainer1.Panel2.Controls.Add(this.debugToggle);
            this.splitContainer1.Panel2.Controls.Add(this.magnetoToggle);
            this.splitContainer1.Panel2.Controls.Add(this.assassinToggle);
            this.splitContainer1.Panel2.Controls.Add(this.charmsToggle);
            this.splitContainer1.Panel2.Controls.Add(this.rangeText);
            this.splitContainer1.Panel2.Controls.Add(this.rangeValue);
            this.splitContainer1.Panel2.Controls.Add(this.fovText);
            this.splitContainer1.Panel2.Controls.Add(this.fovValue);
            this.splitContainer1.Panel2.Controls.Add(this.smartaimToggle);
            this.splitContainer1.Panel2.Controls.Add(this.showfovToggle);
            this.splitContainer1.Panel2.Controls.Add(this.aimbotToggle);
            this.splitContainer1.Panel2.Controls.Add(this.aimbotTitle);
            this.splitContainer1.Panel2.Controls.Add(this.othersTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lootCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.espTitle);
            this.splitContainer1.Panel2.Controls.Add(this.vehicleCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.itemCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.playerCheckbox);
            this.splitContainer1.Size = new System.Drawing.Size(270, 530);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // scopeList
            // 
            this.scopeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scopeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scopeList.Items.AddRange(new object[] {
            "No scope",
            "Scope x2",
            "Scope x4",
            "Scope x8"});
            this.scopeList.Location = new System.Drawing.Point(143, 199);
            this.scopeList.Name = "scopeList";
            this.scopeList.Size = new System.Drawing.Size(121, 24);
            this.scopeList.TabIndex = 16;
            this.scopeList.SelectedIndexChanged += new System.EventHandler(this.scopeList_SelectedIndexChanged);
            // 
            // EspToggle
            // 
            this.EspToggle.AutoSize = true;
            this.EspToggle.BackColor = System.Drawing.Color.DimGray;
            this.EspToggle.Checked = true;
            this.EspToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EspToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspToggle.Location = new System.Drawing.Point(143, 3);
            this.EspToggle.Name = "EspToggle";
            this.EspToggle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EspToggle.Size = new System.Drawing.Size(118, 21);
            this.EspToggle.TabIndex = 15;
            this.EspToggle.Text = "Master Toggle";
            this.EspToggle.UseVisualStyleBackColor = false;
            this.EspToggle.CheckedChanged += new System.EventHandler(this.EspToggle_CheckedChanged);
            // 
            // debugToggle
            // 
            this.debugToggle.AutoSize = true;
            this.debugToggle.BackColor = System.Drawing.Color.Transparent;
            this.debugToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugToggle.ForeColor = System.Drawing.Color.White;
            this.debugToggle.Location = new System.Drawing.Point(4, 466);
            this.debugToggle.Name = "debugToggle";
            this.debugToggle.Size = new System.Drawing.Size(69, 21);
            this.debugToggle.TabIndex = 12;
            this.debugToggle.Text = "Debug";
            this.debugToggle.UseVisualStyleBackColor = false;
            this.debugToggle.CheckedChanged += new System.EventHandler(this.debugToggle_CheckedChanged);
            // 
            // magnetoToggle
            // 
            this.magnetoToggle.AutoSize = true;
            this.magnetoToggle.BackColor = System.Drawing.Color.Transparent;
            this.magnetoToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magnetoToggle.ForeColor = System.Drawing.Color.White;
            this.magnetoToggle.Location = new System.Drawing.Point(4, 385);
            this.magnetoToggle.Name = "magnetoToggle";
            this.magnetoToggle.Size = new System.Drawing.Size(126, 21);
            this.magnetoToggle.TabIndex = 12;
            this.magnetoToggle.Text = "Project: Mageto";
            this.magnetoToggle.UseVisualStyleBackColor = false;
            this.magnetoToggle.CheckedChanged += new System.EventHandler(this.magnetoToggle_CheckedChanged);
            // 
            // assassinToggle
            // 
            this.assassinToggle.AutoSize = true;
            this.assassinToggle.BackColor = System.Drawing.Color.Transparent;
            this.assassinToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assassinToggle.ForeColor = System.Drawing.Color.White;
            this.assassinToggle.Location = new System.Drawing.Point(141, 358);
            this.assassinToggle.Name = "assassinToggle";
            this.assassinToggle.Size = new System.Drawing.Size(103, 21);
            this.assassinToggle.TabIndex = 12;
            this.assassinToggle.Text = "Assassinate";
            this.assassinToggle.UseVisualStyleBackColor = false;
            this.assassinToggle.CheckedChanged += new System.EventHandler(this.assassinToggle_CheckedChanged);
            // 
            // Loop
            // 
            this.Loop.Enabled = true;
            // 
            // noGrassToggle
            // 
            this.noGrassToggle.AutoSize = true;
            this.noGrassToggle.BackColor = System.Drawing.Color.Transparent;
            this.noGrassToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noGrassToggle.ForeColor = System.Drawing.Color.White;
            this.noGrassToggle.Location = new System.Drawing.Point(4, 412);
            this.noGrassToggle.Name = "noGrassToggle";
            this.noGrassToggle.Size = new System.Drawing.Size(87, 21);
            this.noGrassToggle.TabIndex = 17;
            this.noGrassToggle.Text = "No Grass";
            this.noGrassToggle.UseVisualStyleBackColor = false;
            this.noGrassToggle.CheckedChanged += new System.EventHandler(this.noGrassToggle_CheckedChanged);
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(275, 530);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(13, 255);
            this.Name = "Menu";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.Color.Aqua;
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovValue)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.Label heightText;
        public System.Windows.Forms.NumericUpDown heightValue;
        public System.Windows.Forms.CheckBox nocoilToggle;
        public System.Windows.Forms.CheckBox charmsToggle;
        public System.Windows.Forms.Label rangeText;
        public System.Windows.Forms.NumericUpDown rangeValue;
        public System.Windows.Forms.Label fovText;
        public System.Windows.Forms.NumericUpDown fovValue;
        public System.Windows.Forms.CheckBox smartaimToggle;
        public System.Windows.Forms.CheckBox showfovToggle;
        public System.Windows.Forms.CheckBox aimbotToggle;
        public System.Windows.Forms.Label aimbotTitle;
        public System.Windows.Forms.Label othersTitle;
        public System.Windows.Forms.CheckedListBox lootCheckbox;
        public System.Windows.Forms.Label espTitle;
        public System.Windows.Forms.CheckedListBox vehicleCheckbox;
        public System.Windows.Forms.CheckedListBox itemCheckbox;
        public System.Windows.Forms.CheckedListBox playerCheckbox;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Timer Loop;
        public System.Windows.Forms.CheckBox assassinToggle;
        public System.Windows.Forms.CheckBox magnetoToggle;
        public System.Windows.Forms.CheckBox debugToggle;
        public System.Windows.Forms.ComboBox scopeList;
        public System.Windows.Forms.CheckBox EspToggle;
        public System.Windows.Forms.CheckBox noGrassToggle;
    }
}