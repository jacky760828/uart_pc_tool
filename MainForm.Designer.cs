namespace Usart1
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.bpsSelect = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowControlSelect = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chickBitSelect = new System.Windows.Forms.ComboBox();
            this.stopBitSelect = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataBitSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usartButton = new System.Windows.Forms.Button();
            this.comSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.onoff = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.lamp = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.P = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkShowReTime = new System.Windows.Forms.CheckBox();
            this.checkHexShow = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackColor = System.Drawing.SystemColors.Window;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendButton.Location = new System.Drawing.Point(888, 24);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(65, 46);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "發送數據";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bpsSelect
            // 
            this.bpsSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.bpsSelect.DropDownWidth = 120;
            this.bpsSelect.FormattingEnabled = true;
            this.bpsSelect.ItemHeight = 12;
            this.bpsSelect.Items.AddRange(new object[] {
            "Custom",
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000",
            "921600"});
            this.bpsSelect.Location = new System.Drawing.Point(69, 58);
            this.bpsSelect.Name = "bpsSelect";
            this.bpsSelect.Size = new System.Drawing.Size(88, 20);
            this.bpsSelect.TabIndex = 1;
            this.bpsSelect.SelectedIndexChanged += new System.EventHandler(this.bpsSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "版本信息：V0.2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "port：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "波特率：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowControlSelect);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chickBitSelect);
            this.groupBox1.Controls.Add(this.stopBitSelect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataBitSelect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.usartButton);
            this.groupBox1.Controls.Add(this.comSelect);
            this.groupBox1.Controls.Add(this.bpsSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 261);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設置區";
            // 
            // flowControlSelect
            // 
            this.flowControlSelect.FormattingEnabled = true;
            this.flowControlSelect.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "None",
            "Custom"});
            this.flowControlSelect.Location = new System.Drawing.Point(69, 166);
            this.flowControlSelect.Name = "flowControlSelect";
            this.flowControlSelect.Size = new System.Drawing.Size(88, 20);
            this.flowControlSelect.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "流控：";
            // 
            // chickBitSelect
            // 
            this.chickBitSelect.FormattingEnabled = true;
            this.chickBitSelect.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.chickBitSelect.Location = new System.Drawing.Point(69, 139);
            this.chickBitSelect.Name = "chickBitSelect";
            this.chickBitSelect.Size = new System.Drawing.Size(88, 20);
            this.chickBitSelect.TabIndex = 22;
            // 
            // stopBitSelect
            // 
            this.stopBitSelect.FormattingEnabled = true;
            this.stopBitSelect.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitSelect.Location = new System.Drawing.Point(69, 112);
            this.stopBitSelect.Name = "stopBitSelect";
            this.stopBitSelect.Size = new System.Drawing.Size(88, 20);
            this.stopBitSelect.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "校验位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "停止位：";
            // 
            // dataBitSelect
            // 
            this.dataBitSelect.FormattingEnabled = true;
            this.dataBitSelect.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitSelect.Location = new System.Drawing.Point(69, 85);
            this.dataBitSelect.Name = "dataBitSelect";
            this.dataBitSelect.Size = new System.Drawing.Size(88, 20);
            this.dataBitSelect.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "数据位：";
            // 
            // usartButton
            // 
            this.usartButton.BackColor = System.Drawing.SystemColors.Window;
            this.usartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usartButton.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.usartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.usartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.usartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usartButton.Location = new System.Drawing.Point(11, 206);
            this.usartButton.Name = "usartButton";
            this.usartButton.Size = new System.Drawing.Size(145, 40);
            this.usartButton.TabIndex = 16;
            this.usartButton.Text = "打開通訊口";
            this.usartButton.UseVisualStyleBackColor = false;
            this.usartButton.Click += new System.EventHandler(this.usartButton_Click);
            // 
            // comSelect
            // 
            this.comSelect.FormattingEnabled = true;
            this.comSelect.Location = new System.Drawing.Point(69, 31);
            this.comSelect.MaxDropDownItems = 30;
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(88, 20);
            this.comSelect.TabIndex = 15;
            this.comSelect.SelectedIndexChanged += new System.EventHandler(this.comSelect_SelectedIndexChanged);
            this.comSelect.Click += new System.EventHandler(this.comSelect_Click);
            this.comSelect.MouseLeave += new System.EventHandler(this.comSelect_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.button24);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.P);
            this.groupBox2.Controls.Add(this.power);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Location = new System.Drawing.Point(188, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 489);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "發送區";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(495, 14);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 38;
            this.button25.Text = "警示關";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(398, 14);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 37;
            this.button24.Text = "警示開";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.onoff);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Location = new System.Drawing.Point(6, 294);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(398, 118);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(213, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 58);
            this.button7.TabIndex = 24;
            this.button7.Text = "雷達";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 59);
            this.button6.TabIndex = 23;
            this.button6.Text = "語音";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // onoff
            // 
            this.onoff.FormattingEnabled = true;
            this.onoff.Items.AddRange(new object[] {
            "開",
            "關"});
            this.onoff.Location = new System.Drawing.Point(1, 59);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(88, 20);
            this.onoff.TabIndex = 39;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(302, 39);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 63);
            this.button9.TabIndex = 26;
            this.button9.Text = "指紋解鎖";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(195, 14);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 35;
            this.button22.Text = "藍芽開";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(298, 14);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 36;
            this.button23.Text = "藍芽關";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBar2);
            this.groupBox6.Location = new System.Drawing.Point(492, 278);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 143);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "電池";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(19, 29);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(367, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.lamp);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(6, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 110);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "燈";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(213, 69);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "閃爍";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // lamp
            // 
            this.lamp.FormattingEnabled = true;
            this.lamp.Items.AddRange(new object[] {
            "大燈",
            "左燈",
            "右燈"});
            this.lamp.Location = new System.Drawing.Point(6, 21);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(121, 20);
            this.lamp.TabIndex = 2;
            this.lamp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(14, 69);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 1;
            this.button13.Text = "開";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(112, 69);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "關";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(100, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 55);
            this.button8.TabIndex = 33;
            this.button8.Text = "停止加速";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Location = new System.Drawing.Point(495, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 152);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "時速測試";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(57, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(221, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 32);
            this.label13.TabIndex = 34;
            this.label13.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(157, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(257, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = " km/hr";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(22, 46);
            this.trackBar1.Maximum = 999;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(377, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(195, 52);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(75, 23);
            this.P.TabIndex = 30;
            this.P.Text = "擋位";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.Power_Click);
            // 
            // power
            // 
            this.power.FormattingEnabled = true;
            this.power.Items.AddRange(new object[] {
            "1擋",
            "2擋",
            "3擋",
            "4擋",
            "5擋"});
            this.power.Location = new System.Drawing.Point(283, 54);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(121, 20);
            this.power.TabIndex = 29;
            this.power.SelectedIndexChanged += new System.EventHandler(this.power_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 21;
            this.button4.Text = "加速";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 62);
            this.button3.TabIndex = 20;
            this.button3.Text = "上鎖";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 64);
            this.button2.TabIndex = 18;
            this.button2.Text = "解鎖";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // receiveBox
            // 
            this.receiveBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveBox.Location = new System.Drawing.Point(6, 20);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveBox.Size = new System.Drawing.Size(927, 43);
            this.receiveBox.TabIndex = 1;
            this.receiveBox.TextChanged += new System.EventHandler(this.receiveBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.checkShowReTime);
            this.groupBox3.Controls.Add(this.checkHexShow);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Controls.Add(this.receiveBox);
            this.groupBox3.Location = new System.Drawing.Point(208, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(939, 150);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "V(觸控滑條測試)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkShowReTime
            // 
            this.checkShowReTime.AutoSize = true;
            this.checkShowReTime.Location = new System.Drawing.Point(154, 123);
            this.checkShowReTime.Name = "checkShowReTime";
            this.checkShowReTime.Size = new System.Drawing.Size(96, 16);
            this.checkShowReTime.TabIndex = 5;
            this.checkShowReTime.Text = "显示接收时间";
            this.checkShowReTime.UseVisualStyleBackColor = true;
            this.checkShowReTime.CheckedChanged += new System.EventHandler(this.checkShowReTime_CheckedChanged);
            // 
            // checkHexShow
            // 
            this.checkHexShow.AutoSize = true;
            this.checkHexShow.Location = new System.Drawing.Point(98, 123);
            this.checkHexShow.Name = "checkHexShow";
            this.checkHexShow.Size = new System.Drawing.Size(67, 16);
            this.checkHexShow.TabIndex = 3;
            this.checkHexShow.Text = "Hex显示";
            this.checkHexShow.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearButton.Location = new System.Drawing.Point(0, 115);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除窗口";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.sendButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1158, 759);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "usart";
            this.MaximumSizeChanged += new System.EventHandler(this.MainForm_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox bpsSelect;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comSelect;
        private System.Windows.Forms.Button usartButton;
        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox chickBitSelect;
        private System.Windows.Forms.ComboBox stopBitSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dataBitSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox flowControlSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkHexShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkShowReTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.ComboBox power;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ComboBox lamp;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox onoff;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label6;
    }
}

