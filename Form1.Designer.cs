
namespace Lazy_Eye_Saver
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
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTimeUnit = new System.Windows.Forms.ComboBox();
            this.nudSmoothDuration = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbZone4 = new System.Windows.Forms.CheckBox();
            this.nudAutoBrightness4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTo4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFrom4 = new System.Windows.Forms.DateTimePicker();
            this.cbZone3 = new System.Windows.Forms.CheckBox();
            this.nudAutoBrightness3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTo3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFrom3 = new System.Windows.Forms.DateTimePicker();
            this.cbZone2 = new System.Windows.Forms.CheckBox();
            this.nudAutoBrightness2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFrom2 = new System.Windows.Forms.DateTimePicker();
            this.cbZone1 = new System.Windows.Forms.CheckBox();
            this.nudAutoBrightness1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
            this.cbAutoBrightnessControl = new System.Windows.Forms.CheckBox();
            this.tmrCheckAutomation = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmoothDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(299, 25);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Update";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBrightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBrightness);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Brightness Update";
            // 
            // nudBrightness
            // 
            this.nudBrightness.Location = new System.Drawing.Point(248, 30);
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(45, 25);
            this.nudBrightness.TabIndex = 4;
            this.nudBrightness.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBrightness.ValueChanged += new System.EventHandler(this.nudBrightness_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brightness Level:";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(109, 24);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(133, 45);
            this.tbBrightness.SmallChange = 10;
            this.tbBrightness.TabIndex = 2;
            this.tbBrightness.Value = 100;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTimeUnit);
            this.groupBox2.Controls.Add(this.nudSmoothDuration);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbZone4);
            this.groupBox2.Controls.Add(this.nudAutoBrightness4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpTo4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpFrom4);
            this.groupBox2.Controls.Add(this.cbZone3);
            this.groupBox2.Controls.Add(this.nudAutoBrightness3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpTo3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpFrom3);
            this.groupBox2.Controls.Add(this.cbZone2);
            this.groupBox2.Controls.Add(this.nudAutoBrightness2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpTo2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpFrom2);
            this.groupBox2.Controls.Add(this.cbZone1);
            this.groupBox2.Controls.Add(this.nudAutoBrightness1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpTo1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFrom1);
            this.groupBox2.Controls.Add(this.cbAutoBrightnessControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automated Brightness Control";
            // 
            // cbTimeUnit
            // 
            this.cbTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeUnit.FormattingEnabled = true;
            this.cbTimeUnit.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.cbTimeUnit.Location = new System.Drawing.Point(306, 155);
            this.cbTimeUnit.Name = "cbTimeUnit";
            this.cbTimeUnit.Size = new System.Drawing.Size(80, 25);
            this.cbTimeUnit.TabIndex = 29;
            // 
            // nudSmoothDuration
            // 
            this.nudSmoothDuration.Location = new System.Drawing.Point(242, 155);
            this.nudSmoothDuration.Name = "nudSmoothDuration";
            this.nudSmoothDuration.Size = new System.Drawing.Size(58, 25);
            this.nudSmoothDuration.TabIndex = 27;
            this.nudSmoothDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Smooth Brightness Transition duration:";
            // 
            // cbZone4
            // 
            this.cbZone4.AutoSize = true;
            this.cbZone4.Location = new System.Drawing.Point(6, 131);
            this.cbZone4.Name = "cbZone4";
            this.cbZone4.Size = new System.Drawing.Size(70, 21);
            this.cbZone4.TabIndex = 26;
            this.cbZone4.Text = "Zone 4:";
            this.cbZone4.UseVisualStyleBackColor = true;
            // 
            // nudAutoBrightness4
            // 
            this.nudAutoBrightness4.Location = new System.Drawing.Point(342, 129);
            this.nudAutoBrightness4.Name = "nudAutoBrightness4";
            this.nudAutoBrightness4.Size = new System.Drawing.Size(44, 25);
            this.nudAutoBrightness4.TabIndex = 22;
            this.nudAutoBrightness4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Set Brightness:";
            // 
            // dtpTo4
            // 
            this.dtpTo4.CustomFormat = "HH:mm";
            this.dtpTo4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo4.Location = new System.Drawing.Point(182, 129);
            this.dtpTo4.Name = "dtpTo4";
            this.dtpTo4.ShowUpDown = true;
            this.dtpTo4.Size = new System.Drawing.Size(60, 25);
            this.dtpTo4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "-->";
            // 
            // dtpFrom4
            // 
            this.dtpFrom4.CustomFormat = "HH:mm";
            this.dtpFrom4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom4.Location = new System.Drawing.Point(87, 129);
            this.dtpFrom4.Name = "dtpFrom4";
            this.dtpFrom4.ShowUpDown = true;
            this.dtpFrom4.Size = new System.Drawing.Size(60, 25);
            this.dtpFrom4.TabIndex = 21;
            // 
            // cbZone3
            // 
            this.cbZone3.AutoSize = true;
            this.cbZone3.Location = new System.Drawing.Point(6, 104);
            this.cbZone3.Name = "cbZone3";
            this.cbZone3.Size = new System.Drawing.Size(70, 21);
            this.cbZone3.TabIndex = 20;
            this.cbZone3.Text = "Zone 3:";
            this.cbZone3.UseVisualStyleBackColor = true;
            // 
            // nudAutoBrightness3
            // 
            this.nudAutoBrightness3.Location = new System.Drawing.Point(342, 102);
            this.nudAutoBrightness3.Name = "nudAutoBrightness3";
            this.nudAutoBrightness3.Size = new System.Drawing.Size(44, 25);
            this.nudAutoBrightness3.TabIndex = 16;
            this.nudAutoBrightness3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Set Brightness:";
            // 
            // dtpTo3
            // 
            this.dtpTo3.CustomFormat = "HH:mm";
            this.dtpTo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo3.Location = new System.Drawing.Point(182, 102);
            this.dtpTo3.Name = "dtpTo3";
            this.dtpTo3.ShowUpDown = true;
            this.dtpTo3.Size = new System.Drawing.Size(60, 25);
            this.dtpTo3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "-->";
            // 
            // dtpFrom3
            // 
            this.dtpFrom3.CustomFormat = "HH:mm";
            this.dtpFrom3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom3.Location = new System.Drawing.Point(87, 102);
            this.dtpFrom3.Name = "dtpFrom3";
            this.dtpFrom3.ShowUpDown = true;
            this.dtpFrom3.Size = new System.Drawing.Size(60, 25);
            this.dtpFrom3.TabIndex = 15;
            // 
            // cbZone2
            // 
            this.cbZone2.AutoSize = true;
            this.cbZone2.Location = new System.Drawing.Point(6, 77);
            this.cbZone2.Name = "cbZone2";
            this.cbZone2.Size = new System.Drawing.Size(70, 21);
            this.cbZone2.TabIndex = 14;
            this.cbZone2.Text = "Zone 2:";
            this.cbZone2.UseVisualStyleBackColor = true;
            // 
            // nudAutoBrightness2
            // 
            this.nudAutoBrightness2.Location = new System.Drawing.Point(342, 75);
            this.nudAutoBrightness2.Name = "nudAutoBrightness2";
            this.nudAutoBrightness2.Size = new System.Drawing.Size(44, 25);
            this.nudAutoBrightness2.TabIndex = 10;
            this.nudAutoBrightness2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Set Brightness:";
            // 
            // dtpTo2
            // 
            this.dtpTo2.CustomFormat = "HH:mm";
            this.dtpTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo2.Location = new System.Drawing.Point(182, 75);
            this.dtpTo2.Name = "dtpTo2";
            this.dtpTo2.ShowUpDown = true;
            this.dtpTo2.Size = new System.Drawing.Size(60, 25);
            this.dtpTo2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "-->";
            // 
            // dtpFrom2
            // 
            this.dtpFrom2.CustomFormat = "HH:mm";
            this.dtpFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom2.Location = new System.Drawing.Point(87, 75);
            this.dtpFrom2.Name = "dtpFrom2";
            this.dtpFrom2.ShowUpDown = true;
            this.dtpFrom2.Size = new System.Drawing.Size(60, 25);
            this.dtpFrom2.TabIndex = 9;
            // 
            // cbZone1
            // 
            this.cbZone1.AutoSize = true;
            this.cbZone1.Location = new System.Drawing.Point(6, 50);
            this.cbZone1.Name = "cbZone1";
            this.cbZone1.Size = new System.Drawing.Size(70, 21);
            this.cbZone1.TabIndex = 8;
            this.cbZone1.Text = "Zone 1:";
            this.cbZone1.UseVisualStyleBackColor = true;
            // 
            // nudAutoBrightness1
            // 
            this.nudAutoBrightness1.Location = new System.Drawing.Point(342, 48);
            this.nudAutoBrightness1.Name = "nudAutoBrightness1";
            this.nudAutoBrightness1.Size = new System.Drawing.Size(44, 25);
            this.nudAutoBrightness1.TabIndex = 5;
            this.nudAutoBrightness1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Set Brightness:";
            // 
            // dtpTo1
            // 
            this.dtpTo1.CustomFormat = "HH:mm";
            this.dtpTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo1.Location = new System.Drawing.Point(182, 48);
            this.dtpTo1.Name = "dtpTo1";
            this.dtpTo1.ShowUpDown = true;
            this.dtpTo1.Size = new System.Drawing.Size(60, 25);
            this.dtpTo1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "-->";
            // 
            // dtpFrom1
            // 
            this.dtpFrom1.CustomFormat = "HH:mm";
            this.dtpFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom1.Location = new System.Drawing.Point(87, 48);
            this.dtpFrom1.Name = "dtpFrom1";
            this.dtpFrom1.ShowUpDown = true;
            this.dtpFrom1.Size = new System.Drawing.Size(60, 25);
            this.dtpFrom1.TabIndex = 1;
            // 
            // cbAutoBrightnessControl
            // 
            this.cbAutoBrightnessControl.AutoSize = true;
            this.cbAutoBrightnessControl.Location = new System.Drawing.Point(6, 24);
            this.cbAutoBrightnessControl.Name = "cbAutoBrightnessControl";
            this.cbAutoBrightnessControl.Size = new System.Drawing.Size(165, 21);
            this.cbAutoBrightnessControl.TabIndex = 0;
            this.cbAutoBrightnessControl.Text = "Auto Brightness Control";
            this.cbAutoBrightnessControl.UseVisualStyleBackColor = true;
            this.cbAutoBrightnessControl.CheckedChanged += new System.EventHandler(this.cbAutoBrightnessControl_CheckedChanged);
            // 
            // tmrCheckAutomation
            // 
            this.tmrCheckAutomation.Enabled = true;
            this.tmrCheckAutomation.Interval = 60000;
            this.tmrCheckAutomation.Tick += new System.EventHandler(this.tmrCheckAutomation_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 17);
            this.lblStatus.Text = "Status: Done";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel3.Text = "By: Khalil Hamdi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(420, 298);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "The Lazy Eye Saver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmoothDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoBrightness1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCheckAutomation;
        private System.Windows.Forms.CheckBox cbAutoBrightnessControl;
        private System.Windows.Forms.DateTimePicker dtpFrom1;
        private System.Windows.Forms.DateTimePicker dtpTo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAutoBrightness1;
        private System.Windows.Forms.CheckBox cbZone1;
        private System.Windows.Forms.CheckBox cbZone4;
        private System.Windows.Forms.NumericUpDown nudAutoBrightness4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTo4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFrom4;
        private System.Windows.Forms.CheckBox cbZone3;
        private System.Windows.Forms.NumericUpDown nudAutoBrightness3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFrom3;
        private System.Windows.Forms.CheckBox cbZone2;
        private System.Windows.Forms.NumericUpDown nudAutoBrightness2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFrom2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSmoothDuration;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ComboBox cbTimeUnit;
    }
}

