﻿
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
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbAutoBrightnessControl = new System.Windows.Forms.CheckBox();
            this.tmrCheckAutomation = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbTimeUnit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker8);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker6);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.cbAutoBrightnessControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automated Brightness Control";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(242, 155);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(58, 25);
            this.numericUpDown5.TabIndex = 27;
            this.numericUpDown5.Value = new decimal(new int[] {
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 131);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 21);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "Zone 1:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(342, 129);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(44, 25);
            this.numericUpDown4.TabIndex = 22;
            this.numericUpDown4.Value = new decimal(new int[] {
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
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "HH:mm";
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(182, 129);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.ShowUpDown = true;
            this.dateTimePicker7.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker7.TabIndex = 24;
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
            // dateTimePicker8
            // 
            this.dateTimePicker8.CustomFormat = "HH:mm";
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(87, 129);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.ShowUpDown = true;
            this.dateTimePicker8.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker8.TabIndex = 21;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 104);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 21);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Zone 1:";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(342, 102);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 25);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
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
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH:mm";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(182, 102);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.ShowUpDown = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker5.TabIndex = 18;
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
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "HH:mm";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(87, 102);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.ShowUpDown = true;
            this.dateTimePicker6.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker6.TabIndex = 15;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 21);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Zone 1:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(342, 75);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 25);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(182, 75);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker3.TabIndex = 12;
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
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH:mm";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(87, 75);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Zone 1:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 25);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(182, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker2.TabIndex = 6;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(60, 25);
            this.dateTimePicker1.TabIndex = 1;
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
            // 
            // tmrCheckAutomation
            // 
            this.tmrCheckAutomation.Enabled = true;
            this.tmrCheckAutomation.Interval = 60000;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 17);
            this.toolStripStatusLabel1.Text = "Next Transition in ?? Minutes.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel3.Text = "By: Khalil Hamdi";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ComboBox cbTimeUnit;
    }
}

