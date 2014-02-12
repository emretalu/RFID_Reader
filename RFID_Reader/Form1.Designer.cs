namespace RFID_Reader
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
            this.textResponse = new System.Windows.Forms.TextBox();
            this.UL_readBlock = new System.Windows.Forms.ListBox();
            this.UL_writeBlock = new System.Windows.Forms.ListBox();
            this.btn_ControlLED = new System.Windows.Forms.Button();
            this.txt_LEDFREQ = new System.Windows.Forms.TextBox();
            this.txt_LEDDURATION = new System.Windows.Forms.TextBox();
            this.btn_ControlBuzzer = new System.Windows.Forms.Button();
            this.txt_BUZZERDURATION = new System.Windows.Forms.TextBox();
            this.txt_BUZZERFREQ = new System.Windows.Forms.TextBox();
            this.btn_MF_Read = new System.Windows.Forms.Button();
            this.readKeyB = new System.Windows.Forms.RadioButton();
            this.readAll = new System.Windows.Forms.RadioButton();
            this.readNum = new System.Windows.Forms.ComboBox();
            this.readStart = new System.Windows.Forms.ComboBox();
            this.readKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.btn_MF_Write = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.writeKey = new System.Windows.Forms.ComboBox();
            this.writeStart = new System.Windows.Forms.ComboBox();
            this.writeNum = new System.Windows.Forms.ComboBox();
            this.writeAll = new System.Windows.Forms.RadioButton();
            this.writeKeyB = new System.Windows.Forms.RadioButton();
            this.writeData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_GetVersionNum = new System.Windows.Forms.Button();
            this.btn_GetSerNum = new System.Windows.Forms.Button();
            this.btn_SetSerNum = new System.Windows.Forms.Button();
            this.txt_SetSerNum = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(13, 13);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResponse.Size = new System.Drawing.Size(259, 239);
            this.textResponse.TabIndex = 0;
            // 
            // UL_readBlock
            // 
            this.UL_readBlock.FormattingEnabled = true;
            this.UL_readBlock.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.UL_readBlock.Location = new System.Drawing.Point(13, 258);
            this.UL_readBlock.Name = "UL_readBlock";
            this.UL_readBlock.Size = new System.Drawing.Size(120, 134);
            this.UL_readBlock.TabIndex = 1;
            // 
            // UL_writeBlock
            // 
            this.UL_writeBlock.FormattingEnabled = true;
            this.UL_writeBlock.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.UL_writeBlock.Location = new System.Drawing.Point(152, 258);
            this.UL_writeBlock.Name = "UL_writeBlock";
            this.UL_writeBlock.Size = new System.Drawing.Size(120, 134);
            this.UL_writeBlock.TabIndex = 2;
            // 
            // btn_ControlLED
            // 
            this.btn_ControlLED.Location = new System.Drawing.Point(152, 398);
            this.btn_ControlLED.Name = "btn_ControlLED";
            this.btn_ControlLED.Size = new System.Drawing.Size(120, 23);
            this.btn_ControlLED.TabIndex = 3;
            this.btn_ControlLED.Text = "Control LED";
            this.btn_ControlLED.UseVisualStyleBackColor = true;
            this.btn_ControlLED.Click += new System.EventHandler(this.btn_ControlLED_Click);
            // 
            // txt_LEDFREQ
            // 
            this.txt_LEDFREQ.Location = new System.Drawing.Point(13, 398);
            this.txt_LEDFREQ.Name = "txt_LEDFREQ";
            this.txt_LEDFREQ.Size = new System.Drawing.Size(65, 20);
            this.txt_LEDFREQ.TabIndex = 4;
            this.txt_LEDFREQ.Text = "Frequency";
            // 
            // txt_LEDDURATION
            // 
            this.txt_LEDDURATION.Location = new System.Drawing.Point(87, 398);
            this.txt_LEDDURATION.Name = "txt_LEDDURATION";
            this.txt_LEDDURATION.Size = new System.Drawing.Size(59, 20);
            this.txt_LEDDURATION.TabIndex = 5;
            this.txt_LEDDURATION.Text = "Duration";
            // 
            // btn_ControlBuzzer
            // 
            this.btn_ControlBuzzer.Location = new System.Drawing.Point(152, 427);
            this.btn_ControlBuzzer.Name = "btn_ControlBuzzer";
            this.btn_ControlBuzzer.Size = new System.Drawing.Size(120, 23);
            this.btn_ControlBuzzer.TabIndex = 6;
            this.btn_ControlBuzzer.Text = "Control Buzzer";
            this.btn_ControlBuzzer.UseVisualStyleBackColor = true;
            this.btn_ControlBuzzer.Click += new System.EventHandler(this.btn_ControlBuzzer_Click);
            // 
            // txt_BUZZERDURATION
            // 
            this.txt_BUZZERDURATION.Location = new System.Drawing.Point(87, 429);
            this.txt_BUZZERDURATION.Name = "txt_BUZZERDURATION";
            this.txt_BUZZERDURATION.Size = new System.Drawing.Size(59, 20);
            this.txt_BUZZERDURATION.TabIndex = 8;
            this.txt_BUZZERDURATION.Text = "Duration";
            // 
            // txt_BUZZERFREQ
            // 
            this.txt_BUZZERFREQ.Location = new System.Drawing.Point(13, 429);
            this.txt_BUZZERFREQ.Name = "txt_BUZZERFREQ";
            this.txt_BUZZERFREQ.Size = new System.Drawing.Size(65, 20);
            this.txt_BUZZERFREQ.TabIndex = 7;
            this.txt_BUZZERFREQ.Text = "Frequency";
            // 
            // btn_MF_Read
            // 
            this.btn_MF_Read.Location = new System.Drawing.Point(9, 69);
            this.btn_MF_Read.Name = "btn_MF_Read";
            this.btn_MF_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_MF_Read.TabIndex = 9;
            this.btn_MF_Read.Text = "MF Read";
            this.btn_MF_Read.UseVisualStyleBackColor = true;
            this.btn_MF_Read.Click += new System.EventHandler(this.btn_MF_Read_Click);
            // 
            // readKeyB
            // 
            this.readKeyB.AutoSize = true;
            this.readKeyB.Location = new System.Drawing.Point(90, 72);
            this.readKeyB.Name = "readKeyB";
            this.readKeyB.Size = new System.Drawing.Size(82, 17);
            this.readKeyB.TabIndex = 10;
            this.readKeyB.TabStop = true;
            this.readKeyB.Text = "Read Key B";
            this.readKeyB.UseVisualStyleBackColor = true;
            // 
            // readAll
            // 
            this.readAll.AutoSize = true;
            this.readAll.Location = new System.Drawing.Point(180, 72);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(36, 17);
            this.readAll.TabIndex = 11;
            this.readAll.TabStop = true;
            this.readAll.Text = "All";
            this.readAll.UseVisualStyleBackColor = true;
            // 
            // readNum
            // 
            this.readNum.FormattingEnabled = true;
            this.readNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.readNum.Location = new System.Drawing.Point(123, 43);
            this.readNum.Name = "readNum";
            this.readNum.Size = new System.Drawing.Size(93, 21);
            this.readNum.TabIndex = 12;
            // 
            // readStart
            // 
            this.readStart.FormattingEnabled = true;
            this.readStart.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "1F",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "2F",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "3F"});
            this.readStart.Location = new System.Drawing.Point(9, 43);
            this.readStart.Name = "readStart";
            this.readStart.Size = new System.Drawing.Size(93, 21);
            this.readStart.TabIndex = 13;
            // 
            // readKey
            // 
            this.readKey.FormattingEnabled = true;
            this.readKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.readKey.Location = new System.Drawing.Point(235, 43);
            this.readKey.Name = "readKey";
            this.readKey.Size = new System.Drawing.Size(121, 21);
            this.readKey.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Read Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Read Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Read Key";
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ClearLog.Location = new System.Drawing.Point(521, 448);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(121, 51);
            this.btn_ClearLog.TabIndex = 18;
            this.btn_ClearLog.Text = "Clear Logs";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // btn_MF_Write
            // 
            this.btn_MF_Write.Location = new System.Drawing.Point(9, 96);
            this.btn_MF_Write.Name = "btn_MF_Write";
            this.btn_MF_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_MF_Write.TabIndex = 19;
            this.btn_MF_Write.Text = "MF Write";
            this.btn_MF_Write.UseVisualStyleBackColor = true;
            this.btn_MF_Write.Click += new System.EventHandler(this.btn_MF_Write_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Write Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Write Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Write Start";
            // 
            // writeKey
            // 
            this.writeKey.FormattingEnabled = true;
            this.writeKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.writeKey.Location = new System.Drawing.Point(235, 43);
            this.writeKey.Name = "writeKey";
            this.writeKey.Size = new System.Drawing.Size(121, 21);
            this.writeKey.TabIndex = 22;
            // 
            // writeStart
            // 
            this.writeStart.FormattingEnabled = true;
            this.writeStart.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "1F",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "2F",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "3F"});
            this.writeStart.Location = new System.Drawing.Point(9, 43);
            this.writeStart.Name = "writeStart";
            this.writeStart.Size = new System.Drawing.Size(93, 21);
            this.writeStart.TabIndex = 21;
            // 
            // writeNum
            // 
            this.writeNum.FormattingEnabled = true;
            this.writeNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.writeNum.Location = new System.Drawing.Point(123, 43);
            this.writeNum.Name = "writeNum";
            this.writeNum.Size = new System.Drawing.Size(93, 21);
            this.writeNum.TabIndex = 20;
            // 
            // writeAll
            // 
            this.writeAll.AutoSize = true;
            this.writeAll.Location = new System.Drawing.Point(180, 99);
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(36, 17);
            this.writeAll.TabIndex = 27;
            this.writeAll.TabStop = true;
            this.writeAll.Text = "All";
            this.writeAll.UseVisualStyleBackColor = true;
            // 
            // writeKeyB
            // 
            this.writeKeyB.AutoSize = true;
            this.writeKeyB.Location = new System.Drawing.Point(90, 99);
            this.writeKeyB.Name = "writeKeyB";
            this.writeKeyB.Size = new System.Drawing.Size(81, 17);
            this.writeKeyB.TabIndex = 26;
            this.writeKeyB.TabStop = true;
            this.writeKeyB.Text = "Write Key B";
            this.writeKeyB.UseVisualStyleBackColor = true;
            // 
            // writeData
            // 
            this.writeData.Location = new System.Drawing.Point(9, 70);
            this.writeData.Name = "writeData";
            this.writeData.Size = new System.Drawing.Size(347, 20);
            this.writeData.TabIndex = 28;
            this.writeData.Text = "FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_MF_Read);
            this.groupBox1.Controls.Add(this.readKeyB);
            this.groupBox1.Controls.Add(this.readAll);
            this.groupBox1.Controls.Add(this.readNum);
            this.groupBox1.Controls.Add(this.readStart);
            this.groupBox1.Controls.Add(this.readKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(279, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 109);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reading";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_MF_Write);
            this.groupBox2.Controls.Add(this.writeData);
            this.groupBox2.Controls.Add(this.writeNum);
            this.groupBox2.Controls.Add(this.writeAll);
            this.groupBox2.Controls.Add(this.writeStart);
            this.groupBox2.Controls.Add(this.writeKeyB);
            this.groupBox2.Controls.Add(this.writeKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(279, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 135);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Writing";
            // 
            // btn_GetVersionNum
            // 
            this.btn_GetVersionNum.Location = new System.Drawing.Point(45, 455);
            this.btn_GetVersionNum.Name = "btn_GetVersionNum";
            this.btn_GetVersionNum.Size = new System.Drawing.Size(88, 23);
            this.btn_GetVersionNum.TabIndex = 31;
            this.btn_GetVersionNum.Text = "Get Version";
            this.btn_GetVersionNum.UseVisualStyleBackColor = true;
            this.btn_GetVersionNum.Click += new System.EventHandler(this.btn_GetVersionNum_Click);
            // 
            // btn_GetSerNum
            // 
            this.btn_GetSerNum.Location = new System.Drawing.Point(152, 455);
            this.btn_GetSerNum.Name = "btn_GetSerNum";
            this.btn_GetSerNum.Size = new System.Drawing.Size(93, 23);
            this.btn_GetSerNum.TabIndex = 32;
            this.btn_GetSerNum.Text = "Get Serial";
            this.btn_GetSerNum.UseVisualStyleBackColor = true;
            this.btn_GetSerNum.Click += new System.EventHandler(this.btn_GetSerNum_Click);
            // 
            // btn_SetSerNum
            // 
            this.btn_SetSerNum.Location = new System.Drawing.Point(191, 482);
            this.btn_SetSerNum.Name = "btn_SetSerNum";
            this.btn_SetSerNum.Size = new System.Drawing.Size(81, 23);
            this.btn_SetSerNum.TabIndex = 33;
            this.btn_SetSerNum.Text = "Set Serial";
            this.btn_SetSerNum.UseVisualStyleBackColor = true;
            this.btn_SetSerNum.Click += new System.EventHandler(this.btn_SetSerNum_Click);
            // 
            // txt_SetSerNum
            // 
            this.txt_SetSerNum.Location = new System.Drawing.Point(13, 484);
            this.txt_SetSerNum.Name = "txt_SetSerNum";
            this.txt_SetSerNum.Size = new System.Drawing.Size(172, 20);
            this.txt_SetSerNum.TabIndex = 34;
            this.txt_SetSerNum.Text = "FF FF FF FF FF FF FF FF";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 511);
            this.Controls.Add(this.txt_SetSerNum);
            this.Controls.Add(this.btn_SetSerNum);
            this.Controls.Add(this.btn_GetSerNum);
            this.Controls.Add(this.btn_GetVersionNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.txt_BUZZERDURATION);
            this.Controls.Add(this.txt_BUZZERFREQ);
            this.Controls.Add(this.btn_ControlBuzzer);
            this.Controls.Add(this.txt_LEDDURATION);
            this.Controls.Add(this.txt_LEDFREQ);
            this.Controls.Add(this.btn_ControlLED);
            this.Controls.Add(this.UL_writeBlock);
            this.Controls.Add(this.UL_readBlock);
            this.Controls.Add(this.textResponse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.ListBox UL_readBlock;
        private System.Windows.Forms.ListBox UL_writeBlock;
        private System.Windows.Forms.Button btn_ControlLED;
        private System.Windows.Forms.TextBox txt_LEDFREQ;
        private System.Windows.Forms.TextBox txt_LEDDURATION;
        private System.Windows.Forms.Button btn_ControlBuzzer;
        private System.Windows.Forms.TextBox txt_BUZZERDURATION;
        private System.Windows.Forms.TextBox txt_BUZZERFREQ;
        private System.Windows.Forms.Button btn_MF_Read;
        private System.Windows.Forms.RadioButton readKeyB;
        private System.Windows.Forms.RadioButton readAll;
        private System.Windows.Forms.ComboBox readNum;
        private System.Windows.Forms.ComboBox readStart;
        private System.Windows.Forms.ComboBox readKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.Button btn_MF_Write;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox writeKey;
        private System.Windows.Forms.ComboBox writeStart;
        private System.Windows.Forms.ComboBox writeNum;
        private System.Windows.Forms.RadioButton writeAll;
        private System.Windows.Forms.RadioButton writeKeyB;
        private System.Windows.Forms.TextBox writeData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_GetVersionNum;
        private System.Windows.Forms.Button btn_GetSerNum;
        private System.Windows.Forms.Button btn_SetSerNum;
        private System.Windows.Forms.TextBox txt_SetSerNum;
        private System.Windows.Forms.Timer timer1;
    }
}

