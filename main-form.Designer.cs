namespace BELL_PRES
{
    partial class main_form
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.Manual = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.time_5 = new System.Windows.Forms.Button();
            this.twice = new System.Windows.Forms.Button();
            this.once = new System.Windows.Forms.Button();
            this.Automatic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.once_min_label = new System.Windows.Forms.Label();
            this.once_sec_label = new System.Windows.Forms.Label();
            this.once_lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.once_min_box = new System.Windows.Forms.ComboBox();
            this.twice_min_box = new System.Windows.Forms.ComboBox();
            this.min_box_5 = new System.Windows.Forms.ComboBox();
            this.once_sec_box = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lab_audio_5 = new System.Windows.Forms.Label();
            this.lab_audio_2 = new System.Windows.Forms.Label();
            this.lab_audio_1 = new System.Windows.Forms.Label();
            this.btn_set_audio_5 = new System.Windows.Forms.Button();
            this.btn_set_audio_2 = new System.Windows.Forms.Button();
            this.txt_audio_5 = new System.Windows.Forms.TextBox();
            this.txt_audio_2 = new System.Windows.Forms.TextBox();
            this.txt_audio_1 = new System.Windows.Forms.TextBox();
            this.btn_set_audio_1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.twice_sec_box = new System.Windows.Forms.ComboBox();
            this.sec_box_5 = new System.Windows.Forms.ComboBox();
            this.Tab.SuspendLayout();
            this.Manual.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Automatic.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Manual);
            this.Tab.Controls.Add(this.Automatic);
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(373, 472);
            this.Tab.TabIndex = 0;
            // 
            // Manual
            // 
            this.Manual.Controls.Add(this.tableLayoutPanel1);
            this.Manual.Location = new System.Drawing.Point(4, 22);
            this.Manual.Name = "Manual";
            this.Manual.Padding = new System.Windows.Forms.Padding(3);
            this.Manual.Size = new System.Drawing.Size(365, 446);
            this.Manual.TabIndex = 0;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.time_5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.twice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.once, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 434);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // time_5
            // 
            this.time_5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.time_5.Location = new System.Drawing.Point(3, 318);
            this.time_5.Name = "time_5";
            this.time_5.Size = new System.Drawing.Size(347, 104);
            this.time_5.TabIndex = 2;
            this.time_5.Text = "FIFTH";
            this.time_5.UseVisualStyleBackColor = true;
            this.time_5.Click += new System.EventHandler(this.time_5_Click);
            // 
            // twice
            // 
            this.twice.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.twice.Location = new System.Drawing.Point(3, 159);
            this.twice.Name = "twice";
            this.twice.Size = new System.Drawing.Size(347, 103);
            this.twice.TabIndex = 1;
            this.twice.Text = "TWICE";
            this.twice.UseVisualStyleBackColor = true;
            this.twice.Click += new System.EventHandler(this.twice_Click);
            // 
            // once
            // 
            this.once.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.once.Location = new System.Drawing.Point(3, 3);
            this.once.Name = "once";
            this.once.Size = new System.Drawing.Size(347, 113);
            this.once.TabIndex = 0;
            this.once.Text = "ONCE";
            this.once.UseVisualStyleBackColor = true;
            this.once.Click += new System.EventHandler(this.once_Click);
            // 
            // Automatic
            // 
            this.Automatic.Controls.Add(this.tableLayoutPanel2);
            this.Automatic.Location = new System.Drawing.Point(4, 22);
            this.Automatic.Name = "Automatic";
            this.Automatic.Padding = new System.Windows.Forms.Padding(3);
            this.Automatic.Size = new System.Drawing.Size(365, 446);
            this.Automatic.TabIndex = 1;
            this.Automatic.Text = "Automatic";
            this.Automatic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.59808F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.40191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Controls.Add(this.once_min_label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.once_sec_label, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.once_lab, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.start_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.stop_btn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.once_min_box, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.twice_min_box, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.min_box_5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.once_sec_box, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.twice_sec_box, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.sec_box_5, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.03614F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.96386F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(353, 434);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // once_min_label
            // 
            this.once_min_label.AutoSize = true;
            this.once_min_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.once_min_label.Location = new System.Drawing.Point(192, 51);
            this.once_min_label.Margin = new System.Windows.Forms.Padding(3);
            this.once_min_label.Name = "once_min_label";
            this.once_min_label.Size = new System.Drawing.Size(24, 16);
            this.once_min_label.TabIndex = 3;
            this.once_min_label.Text = "分";
            // 
            // once_sec_label
            // 
            this.once_sec_label.AutoSize = true;
            this.once_sec_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.once_sec_label.Location = new System.Drawing.Point(281, 51);
            this.once_sec_label.Margin = new System.Windows.Forms.Padding(3);
            this.once_sec_label.Name = "once_sec_label";
            this.once_sec_label.Size = new System.Drawing.Size(24, 16);
            this.once_sec_label.TabIndex = 4;
            this.once_sec_label.Text = "秒";
            // 
            // once_lab
            // 
            this.once_lab.AutoSize = true;
            this.once_lab.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.once_lab.Location = new System.Drawing.Point(3, 51);
            this.once_lab.Margin = new System.Windows.Forms.Padding(3);
            this.once_lab.Name = "once_lab";
            this.once_lab.Size = new System.Drawing.Size(116, 16);
            this.once_lab.TabIndex = 0;
            this.once_lab.Text = "Play 1 Bell Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Play 2 Bell Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(192, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(281, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Play 5 Bell Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(192, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(281, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "秒";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(3, 3);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(137, 42);
            this.start_btn.TabIndex = 15;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(3, 153);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(137, 41);
            this.stop_btn.TabIndex = 16;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            // 
            // once_min_box
            // 
            this.once_min_box.FormattingEnabled = true;
            this.once_min_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.once_min_box.Location = new System.Drawing.Point(146, 51);
            this.once_min_box.Name = "once_min_box";
            this.once_min_box.Size = new System.Drawing.Size(40, 20);
            this.once_min_box.TabIndex = 17;
            // 
            // twice_min_box
            // 
            this.twice_min_box.FormattingEnabled = true;
            this.twice_min_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.twice_min_box.Location = new System.Drawing.Point(146, 84);
            this.twice_min_box.Name = "twice_min_box";
            this.twice_min_box.Size = new System.Drawing.Size(40, 20);
            this.twice_min_box.TabIndex = 18;
            // 
            // min_box_5
            // 
            this.min_box_5.FormattingEnabled = true;
            this.min_box_5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.min_box_5.Location = new System.Drawing.Point(146, 118);
            this.min_box_5.Name = "min_box_5";
            this.min_box_5.Size = new System.Drawing.Size(40, 20);
            this.min_box_5.TabIndex = 19;
            // 
            // once_sec_box
            // 
            this.once_sec_box.FormattingEnabled = true;
            this.once_sec_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.once_sec_box.Location = new System.Drawing.Point(229, 51);
            this.once_sec_box.Name = "once_sec_box";
            this.once_sec_box.Size = new System.Drawing.Size(46, 20);
            this.once_sec_box.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lab_audio_5);
            this.tabPage1.Controls.Add(this.lab_audio_2);
            this.tabPage1.Controls.Add(this.lab_audio_1);
            this.tabPage1.Controls.Add(this.btn_set_audio_5);
            this.tabPage1.Controls.Add(this.btn_set_audio_2);
            this.tabPage1.Controls.Add(this.txt_audio_5);
            this.tabPage1.Controls.Add(this.txt_audio_2);
            this.tabPage1.Controls.Add(this.txt_audio_1);
            this.tabPage1.Controls.Add(this.btn_set_audio_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 446);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lab_audio_5
            // 
            this.lab_audio_5.AutoSize = true;
            this.lab_audio_5.Location = new System.Drawing.Point(20, 73);
            this.lab_audio_5.Name = "lab_audio_5";
            this.lab_audio_5.Size = new System.Drawing.Size(62, 12);
            this.lab_audio_5.TabIndex = 8;
            this.lab_audio_5.Text = "Audio Fifth";
            // 
            // lab_audio_2
            // 
            this.lab_audio_2.AutoSize = true;
            this.lab_audio_2.Location = new System.Drawing.Point(20, 47);
            this.lab_audio_2.Name = "lab_audio_2";
            this.lab_audio_2.Size = new System.Drawing.Size(68, 12);
            this.lab_audio_2.TabIndex = 7;
            this.lab_audio_2.Text = "Audio Twice";
            // 
            // lab_audio_1
            // 
            this.lab_audio_1.AutoSize = true;
            this.lab_audio_1.Location = new System.Drawing.Point(20, 21);
            this.lab_audio_1.Name = "lab_audio_1";
            this.lab_audio_1.Size = new System.Drawing.Size(64, 12);
            this.lab_audio_1.TabIndex = 6;
            this.lab_audio_1.Text = "Audio Once";
            // 
            // btn_set_audio_5
            // 
            this.btn_set_audio_5.Location = new System.Drawing.Point(274, 70);
            this.btn_set_audio_5.Name = "btn_set_audio_5";
            this.btn_set_audio_5.Size = new System.Drawing.Size(74, 19);
            this.btn_set_audio_5.TabIndex = 5;
            this.btn_set_audio_5.Text = "Set";
            this.btn_set_audio_5.UseVisualStyleBackColor = true;
            this.btn_set_audio_5.Click += new System.EventHandler(this.btn_set_audio_5_Click);
            // 
            // btn_set_audio_2
            // 
            this.btn_set_audio_2.Location = new System.Drawing.Point(274, 43);
            this.btn_set_audio_2.Name = "btn_set_audio_2";
            this.btn_set_audio_2.Size = new System.Drawing.Size(74, 19);
            this.btn_set_audio_2.TabIndex = 4;
            this.btn_set_audio_2.Text = "Set";
            this.btn_set_audio_2.UseVisualStyleBackColor = true;
            this.btn_set_audio_2.Click += new System.EventHandler(this.btn_set_audio_2_Click);
            // 
            // txt_audio_5
            // 
            this.txt_audio_5.Location = new System.Drawing.Point(94, 70);
            this.txt_audio_5.Name = "txt_audio_5";
            this.txt_audio_5.ReadOnly = true;
            this.txt_audio_5.Size = new System.Drawing.Size(174, 19);
            this.txt_audio_5.TabIndex = 3;
            // 
            // txt_audio_2
            // 
            this.txt_audio_2.Location = new System.Drawing.Point(94, 44);
            this.txt_audio_2.Name = "txt_audio_2";
            this.txt_audio_2.ReadOnly = true;
            this.txt_audio_2.Size = new System.Drawing.Size(174, 19);
            this.txt_audio_2.TabIndex = 2;
            // 
            // txt_audio_1
            // 
            this.txt_audio_1.Location = new System.Drawing.Point(94, 18);
            this.txt_audio_1.Name = "txt_audio_1";
            this.txt_audio_1.ReadOnly = true;
            this.txt_audio_1.Size = new System.Drawing.Size(174, 19);
            this.txt_audio_1.TabIndex = 1;
            // 
            // btn_set_audio_1
            // 
            this.btn_set_audio_1.Location = new System.Drawing.Point(274, 18);
            this.btn_set_audio_1.Name = "btn_set_audio_1";
            this.btn_set_audio_1.Size = new System.Drawing.Size(74, 19);
            this.btn_set_audio_1.TabIndex = 0;
            this.btn_set_audio_1.Text = "Set";
            this.btn_set_audio_1.UseVisualStyleBackColor = true;
            this.btn_set_audio_1.Click += new System.EventHandler(this.btn_set_audio_1_Click);
            // 
            // twice_sec_box
            // 
            this.twice_sec_box.FormattingEnabled = true;
            this.twice_sec_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.twice_sec_box.Location = new System.Drawing.Point(229, 84);
            this.twice_sec_box.Name = "twice_sec_box";
            this.twice_sec_box.Size = new System.Drawing.Size(46, 20);
            this.twice_sec_box.TabIndex = 21;
            // 
            // sec_box_5
            // 
            this.sec_box_5.FormattingEnabled = true;
            this.sec_box_5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.sec_box_5.Location = new System.Drawing.Point(229, 118);
            this.sec_box_5.Name = "sec_box_5";
            this.sec_box_5.Size = new System.Drawing.Size(46, 20);
            this.sec_box_5.TabIndex = 22;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 496);
            this.Controls.Add(this.Tab);
            this.Name = "main_form";
            this.Text = "BELL PRES";
            this.Tab.ResumeLayout(false);
            this.Manual.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Automatic.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Manual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button twice;
        private System.Windows.Forms.Button once;
        private System.Windows.Forms.TabPage Automatic;
        private System.Windows.Forms.Button time_5;
        private System.Windows.Forms.Label once_lab;
        private System.Windows.Forms.Label once_sec_label;
        private System.Windows.Forms.Label once_min_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_set_audio_5;
        private System.Windows.Forms.Button btn_set_audio_2;
        private System.Windows.Forms.TextBox txt_audio_5;
        private System.Windows.Forms.TextBox txt_audio_2;
        private System.Windows.Forms.TextBox txt_audio_1;
        private System.Windows.Forms.Button btn_set_audio_1;
        private System.Windows.Forms.Label lab_audio_5;
        private System.Windows.Forms.Label lab_audio_2;
        private System.Windows.Forms.Label lab_audio_1;
        private System.Windows.Forms.ComboBox once_min_box;
        private System.Windows.Forms.ComboBox twice_min_box;
        private System.Windows.Forms.ComboBox min_box_5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox once_sec_box;
        private System.Windows.Forms.ComboBox twice_sec_box;
        private System.Windows.Forms.ComboBox sec_box_5;
    }
}