namespace DLCN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listcom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtTruyen = new System.Windows.Forms.TextBox();
            this.grpTinhNang = new System.Windows.Forms.GroupBox();
            this.rad1p = new System.Windows.Forms.RadioButton();
            this.rad30s = new System.Windows.Forms.RadioButton();
            this.rad10s = new System.Windows.Forms.RadioButton();
            this.rad5s = new System.Windows.Forms.RadioButton();
            this.lblNhan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblNhan2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updown4 = new System.Windows.Forms.NumericUpDown();
            this.updown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updown2 = new System.Windows.Forms.NumericUpDown();
            this.updown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.lblIT = new System.Windows.Forms.Label();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.grpTinhNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listcom
            // 
            this.listcom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcom.FormattingEnabled = true;
            this.listcom.Location = new System.Drawing.Point(143, 23);
            this.listcom.Name = "listcom";
            this.listcom.Size = new System.Drawing.Size(121, 30);
            this.listcom.TabIndex = 0;
            this.listcom.SelectedIndexChanged += new System.EventHandler(this.listCom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cổng COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listbaud
            // 
            this.listbaud.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbaud.FormattingEnabled = true;
            this.listbaud.Location = new System.Drawing.Point(143, 81);
            this.listbaud.Name = "listbaud";
            this.listbaud.Size = new System.Drawing.Size(121, 30);
            this.listbaud.TabIndex = 0;
            this.listbaud.SelectedIndexChanged += new System.EventHandler(this.listCom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUDRATE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtTruyen
            // 
            this.txtTruyen.Location = new System.Drawing.Point(16, 146);
            this.txtTruyen.Name = "txtTruyen";
            this.txtTruyen.Size = new System.Drawing.Size(446, 22);
            this.txtTruyen.TabIndex = 3;
            this.txtTruyen.TextChanged += new System.EventHandler(this.txtTruyen_TextChanged);
            // 
            // grpTinhNang
            // 
            this.grpTinhNang.BackColor = System.Drawing.Color.Silver;
            this.grpTinhNang.Controls.Add(this.rad1p);
            this.grpTinhNang.Controls.Add(this.rad30s);
            this.grpTinhNang.Controls.Add(this.rad10s);
            this.grpTinhNang.Controls.Add(this.rad5s);
            this.grpTinhNang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTinhNang.ForeColor = System.Drawing.Color.Red;
            this.grpTinhNang.Location = new System.Drawing.Point(483, 23);
            this.grpTinhNang.Name = "grpTinhNang";
            this.grpTinhNang.Size = new System.Drawing.Size(415, 145);
            this.grpTinhNang.TabIndex = 7;
            this.grpTinhNang.TabStop = false;
            this.grpTinhNang.Text = "SAMPLE TIME";
            this.grpTinhNang.Enter += new System.EventHandler(this.grpTinhNang_Enter);
            // 
            // rad1p
            // 
            this.rad1p.AutoSize = true;
            this.rad1p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1p.ForeColor = System.Drawing.Color.Blue;
            this.rad1p.Location = new System.Drawing.Point(9, 107);
            this.rad1p.Name = "rad1p";
            this.rad1p.Size = new System.Drawing.Size(56, 27);
            this.rad1p.TabIndex = 3;
            this.rad1p.TabStop = true;
            this.rad1p.Text = "1m";
            this.rad1p.UseVisualStyleBackColor = true;
            this.rad1p.CheckedChanged += new System.EventHandler(this.rad1p_CheckedChanged);
            // 
            // rad30s
            // 
            this.rad30s.AutoSize = true;
            this.rad30s.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad30s.ForeColor = System.Drawing.Color.Blue;
            this.rad30s.Location = new System.Drawing.Point(9, 82);
            this.rad30s.Name = "rad30s";
            this.rad30s.Size = new System.Drawing.Size(59, 27);
            this.rad30s.TabIndex = 2;
            this.rad30s.TabStop = true;
            this.rad30s.Text = "30s";
            this.rad30s.UseVisualStyleBackColor = true;
            this.rad30s.CheckedChanged += new System.EventHandler(this.rad30s_CheckedChanged);
            // 
            // rad10s
            // 
            this.rad10s.AutoSize = true;
            this.rad10s.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad10s.ForeColor = System.Drawing.Color.Blue;
            this.rad10s.Location = new System.Drawing.Point(9, 58);
            this.rad10s.Name = "rad10s";
            this.rad10s.Size = new System.Drawing.Size(59, 27);
            this.rad10s.TabIndex = 1;
            this.rad10s.TabStop = true;
            this.rad10s.Text = "10s";
            this.rad10s.UseVisualStyleBackColor = true;
            this.rad10s.CheckedChanged += new System.EventHandler(this.radNhietdo_CheckedChanged);
            // 
            // rad5s
            // 
            this.rad5s.AutoSize = true;
            this.rad5s.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad5s.ForeColor = System.Drawing.Color.Blue;
            this.rad5s.Location = new System.Drawing.Point(9, 32);
            this.rad5s.Name = "rad5s";
            this.rad5s.Size = new System.Drawing.Size(49, 27);
            this.rad5s.TabIndex = 0;
            this.rad5s.TabStop = true;
            this.rad5s.Text = "5s";
            this.rad5s.UseVisualStyleBackColor = true;
            this.rad5s.CheckedChanged += new System.EventHandler(this.radTruyenNhan_CheckedChanged);
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNhan.ForeColor = System.Drawing.Color.Red;
            this.lblNhan.Location = new System.Drawing.Point(117, 18);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(278, 28);
            this.lblNhan.TabIndex = 8;
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhan.Click += new System.EventHandler(this.lblNhan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 30000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 60000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblNhan2
            // 
            this.lblNhan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNhan2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblNhan2.ForeColor = System.Drawing.Color.Red;
            this.lblNhan2.Location = new System.Drawing.Point(116, 18);
            this.lblNhan2.Name = "lblNhan2";
            this.lblNhan2.Size = new System.Drawing.Size(279, 28);
            this.lblNhan2.TabIndex = 9;
            this.lblNhan2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "SENSOR2";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "SENSOR1";
            // 
            // updown4
            // 
            this.updown4.Location = new System.Drawing.Point(6, 124);
            this.updown4.Name = "updown4";
            this.updown4.Size = new System.Drawing.Size(101, 22);
            this.updown4.TabIndex = 12;
            this.updown4.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // updown3
            // 
            this.updown3.Location = new System.Drawing.Point(6, 81);
            this.updown3.Name = "updown3";
            this.updown3.Size = new System.Drawing.Size(101, 22);
            this.updown3.TabIndex = 13;
            this.updown3.ValueChanged += new System.EventHandler(this.updown3_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updown2);
            this.groupBox1.Controls.Add(this.updown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 229);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(215, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "ALARM LOW";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "ALARM HIGHT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(126, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(126, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // updown2
            // 
            this.updown2.Location = new System.Drawing.Point(7, 124);
            this.updown2.Name = "updown2";
            this.updown2.Size = new System.Drawing.Size(101, 22);
            this.updown2.TabIndex = 13;
            this.updown2.ValueChanged += new System.EventHandler(this.updown2_ValueChanged_1);
            // 
            // updown1
            // 
            this.updown1.Location = new System.Drawing.Point(7, 84);
            this.updown1.Name = "updown1";
            this.updown1.Size = new System.Drawing.Size(101, 22);
            this.updown1.TabIndex = 12;
            this.updown1.ValueChanged += new System.EventHandler(this.updown1_ValueChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.updown4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.updown3);
            this.groupBox2.Controls.Add(this.lblNhan2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 229);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khu vưc 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(215, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "ALARM LOW";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "ALARM HIGHT";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(127, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(127, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 14;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(34, 444);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(428, 53);
            this.lblTime.TabIndex = 16;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(733, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 41);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 3000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // lblIT
            // 
            this.lblIT.BackColor = System.Drawing.Color.Lime;
            this.lblIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIT.Location = new System.Drawing.Point(483, 450);
            this.lblIT.Name = "lblIT";
            this.lblIT.Size = new System.Drawing.Size(226, 41);
            this.lblIT.TabIndex = 18;
            this.lblIT.Text = "warning.txt";
            this.lblIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIT.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 1000;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(917, 510);
            this.Controls.Add(this.lblIT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTinhNang);
            this.Controls.Add(this.txtTruyen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbaud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listcom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTinhNang.ResumeLayout(false);
            this.grpTinhNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listbaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtTruyen;
        private System.Windows.Forms.GroupBox grpTinhNang;
        private System.Windows.Forms.RadioButton rad10s;
        private System.Windows.Forms.RadioButton rad5s;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.RadioButton rad1p;
        private System.Windows.Forms.RadioButton rad30s;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lblNhan2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updown4;
        private System.Windows.Forms.NumericUpDown updown3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updown2;
        private System.Windows.Forms.NumericUpDown updown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Label lblIT;
        private System.Windows.Forms.Timer timer7;
    }
}

