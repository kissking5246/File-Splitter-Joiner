namespace FileSplitter_Joiner
{
    partial class FormMain
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
            this.groupBox_FileSplit = new System.Windows.Forms.GroupBox();
            this.brnScanFolder = new System.Windows.Forms.Button();
            this.tbScanFolder = new System.Windows.Forms.TextBox();
            this.radioScanFolder = new System.Windows.Forms.RadioButton();
            this.radioSplitFile = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button_FolderBrowse = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_FileBrowse = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_stepSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SplitSize = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ByteSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Split = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_Split = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_SplitNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitWorker = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ScanFolderWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDeleteFile = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.checkboxDeletefileJoin = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_Join = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScanFolderJoin = new System.Windows.Forms.Button();
            this.tbScanFolderJoin = new System.Windows.Forms.TextBox();
            this.radioScanFolderJoin = new System.Windows.Forms.RadioButton();
            this.radioSplitFileJoin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutputJoin = new System.Windows.Forms.Button();
            this.tbOutputJoin = new System.Windows.Forms.TextBox();
            this.btnBrowseFileJoin = new System.Windows.Forms.Button();
            this.tbJoinFile = new System.Windows.Forms.TextBox();
            this.scanFolderJoinworker = new System.ComponentModel.BackgroundWorker();
            this.joinWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_FileSplit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SplitSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_FileSplit
            // 
            this.groupBox_FileSplit.Controls.Add(this.brnScanFolder);
            this.groupBox_FileSplit.Controls.Add(this.tbScanFolder);
            this.groupBox_FileSplit.Controls.Add(this.radioScanFolder);
            this.groupBox_FileSplit.Controls.Add(this.radioSplitFile);
            this.groupBox_FileSplit.Controls.Add(this.label2);
            this.groupBox_FileSplit.Controls.Add(this.button_FolderBrowse);
            this.groupBox_FileSplit.Controls.Add(this.textBox_Path);
            this.groupBox_FileSplit.Controls.Add(this.button_FileBrowse);
            this.groupBox_FileSplit.Controls.Add(this.textBox_File);
            this.groupBox_FileSplit.Location = new System.Drawing.Point(14, 13);
            this.groupBox_FileSplit.Name = "groupBox_FileSplit";
            this.groupBox_FileSplit.Size = new System.Drawing.Size(465, 204);
            this.groupBox_FileSplit.TabIndex = 1;
            this.groupBox_FileSplit.TabStop = false;
            this.groupBox_FileSplit.Text = "Select file/folder/output";
            // 
            // brnScanFolder
            // 
            this.brnScanFolder.Location = new System.Drawing.Point(364, 44);
            this.brnScanFolder.Name = "brnScanFolder";
            this.brnScanFolder.Size = new System.Drawing.Size(93, 27);
            this.brnScanFolder.TabIndex = 9;
            this.brnScanFolder.Text = "Browse folder";
            this.brnScanFolder.UseVisualStyleBackColor = true;
            this.brnScanFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbScanFolder
            // 
            this.tbScanFolder.Location = new System.Drawing.Point(12, 46);
            this.tbScanFolder.Name = "tbScanFolder";
            this.tbScanFolder.Size = new System.Drawing.Size(345, 23);
            this.tbScanFolder.TabIndex = 8;
            this.tbScanFolder.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // radioScanFolder
            // 
            this.radioScanFolder.AutoSize = true;
            this.radioScanFolder.Checked = true;
            this.radioScanFolder.Location = new System.Drawing.Point(12, 21);
            this.radioScanFolder.Name = "radioScanFolder";
            this.radioScanFolder.Size = new System.Drawing.Size(146, 19);
            this.radioScanFolder.TabIndex = 7;
            this.radioScanFolder.TabStop = true;
            this.radioScanFolder.Text = "Scan folder for big files";
            this.radioScanFolder.UseVisualStyleBackColor = true;
            this.radioScanFolder.CheckedChanged += new System.EventHandler(this.radioScanFolder_CheckedChanged);
            // 
            // radioSplitFile
            // 
            this.radioSplitFile.AutoSize = true;
            this.radioSplitFile.Location = new System.Drawing.Point(12, 76);
            this.radioSplitFile.Name = "radioSplitFile";
            this.radioSplitFile.Size = new System.Drawing.Size(96, 19);
            this.radioSplitFile.TabIndex = 6;
            this.radioSplitFile.Text = "Split a big file";
            this.radioSplitFile.UseVisualStyleBackColor = true;
            this.radioSplitFile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Path";
            // 
            // button_FolderBrowse
            // 
            this.button_FolderBrowse.Location = new System.Drawing.Point(365, 154);
            this.button_FolderBrowse.Name = "button_FolderBrowse";
            this.button_FolderBrowse.Size = new System.Drawing.Size(93, 27);
            this.button_FolderBrowse.TabIndex = 3;
            this.button_FolderBrowse.Text = "Browse dir";
            this.button_FolderBrowse.UseVisualStyleBackColor = true;
            this.button_FolderBrowse.Click += new System.EventHandler(this.button_FolderBrowse_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(13, 157);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(345, 23);
            this.textBox_Path.TabIndex = 2;
            this.textBox_Path.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // button_FileBrowse
            // 
            this.button_FileBrowse.Enabled = false;
            this.button_FileBrowse.Location = new System.Drawing.Point(364, 100);
            this.button_FileBrowse.Name = "button_FileBrowse";
            this.button_FileBrowse.Size = new System.Drawing.Size(94, 27);
            this.button_FileBrowse.TabIndex = 1;
            this.button_FileBrowse.Text = "Browse file";
            this.button_FileBrowse.UseVisualStyleBackColor = true;
            this.button_FileBrowse.Click += new System.EventHandler(this.button_FileBrowse_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Enabled = false;
            this.textBox_File.Location = new System.Drawing.Point(12, 103);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(345, 23);
            this.textBox_File.TabIndex = 0;
            this.textBox_File.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown_stepSize);
            this.groupBox2.Controls.Add(this.numericUpDown_SplitSize);
            this.groupBox2.Controls.Add(this.comboBox_ByteSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Memory Step Size (MB)";
            // 
            // numericUpDown_stepSize
            // 
            this.numericUpDown_stepSize.Location = new System.Drawing.Point(23, 88);
            this.numericUpDown_stepSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_stepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stepSize.Name = "numericUpDown_stepSize";
            this.numericUpDown_stepSize.ReadOnly = true;
            this.numericUpDown_stepSize.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown_stepSize.TabIndex = 4;
            this.numericUpDown_stepSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown_SplitSize
            // 
            this.numericUpDown_SplitSize.Location = new System.Drawing.Point(23, 38);
            this.numericUpDown_SplitSize.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.Name = "numericUpDown_SplitSize";
            this.numericUpDown_SplitSize.ReadOnly = true;
            this.numericUpDown_SplitSize.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown_SplitSize.TabIndex = 3;
            this.numericUpDown_SplitSize.Value = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.ValueChanged += new System.EventHandler(this.userInputChanged);
            // 
            // comboBox_ByteSize
            // 
            this.comboBox_ByteSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ByteSize.FormattingEnabled = true;
            this.comboBox_ByteSize.Items.AddRange(new object[] {
            "B",
            "kB",
            "MB"});
            this.comboBox_ByteSize.Location = new System.Drawing.Point(111, 38);
            this.comboBox_ByteSize.Name = "comboBox_ByteSize";
            this.comboBox_ByteSize.Size = new System.Drawing.Size(47, 23);
            this.comboBox_ByteSize.TabIndex = 2;
            this.comboBox_ByteSize.SelectedIndexChanged += new System.EventHandler(this.userInputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Split File Size";
            // 
            // button_Split
            // 
            this.button_Split.Enabled = false;
            this.button_Split.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Split.Location = new System.Drawing.Point(199, 223);
            this.button_Split.Name = "button_Split";
            this.button_Split.Size = new System.Drawing.Size(281, 98);
            this.button_Split.TabIndex = 4;
            this.button_Split.Text = "Split!";
            this.button_Split.UseVisualStyleBackColor = true;
            this.button_Split.Click += new System.EventHandler(this.button_Split_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel,
            this.toolStripStatusLabel_SplitNum,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar_Split,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(16, 19);
            this.toolStripLabel.Text = "...";
            // 
            // toolStripProgressBar_Split
            // 
            this.toolStripProgressBar_Split.Name = "toolStripProgressBar_Split";
            this.toolStripProgressBar_Split.Size = new System.Drawing.Size(117, 18);
            this.toolStripProgressBar_Split.Visible = false;
            // 
            // toolStripStatusLabel_SplitNum
            // 
            this.toolStripStatusLabel_SplitNum.Name = "toolStripStatusLabel_SplitNum";
            this.toolStripStatusLabel_SplitNum.Size = new System.Drawing.Size(62, 19);
            this.toolStripStatusLabel_SplitNum.Text = "0 split files";
            this.toolStripStatusLabel_SplitNum.Visible = false;
            // 
            // splitWorker
            // 
            this.splitWorker.WorkerReportsProgress = true;
            this.splitWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.splitWorker_DoWork);
            this.splitWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.splitWorker_ProgressChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(486, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 304);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ScanFolderWorker
            // 
            this.ScanFolderWorker.WorkerReportsProgress = true;
            this.ScanFolderWorker.WorkerSupportsCancellation = true;
            this.ScanFolderWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ScanFolderWorker_DoWork);
            this.ScanFolderWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ScanFolderWorker_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 388);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBoxDeleteFile);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.groupBox_FileSplit);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button_Split);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Scan result :";
            // 
            // checkBoxDeleteFile
            // 
            this.checkBoxDeleteFile.AutoSize = true;
            this.checkBoxDeleteFile.Location = new System.Drawing.Point(199, 327);
            this.checkBoxDeleteFile.Name = "checkBoxDeleteFile";
            this.checkBoxDeleteFile.Size = new System.Drawing.Size(173, 19);
            this.checkBoxDeleteFile.TabIndex = 7;
            this.checkBoxDeleteFile.Text = "Delete original file after split";
            this.checkBoxDeleteFile.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkboxDeletefileJoin);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.button_Join);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Join";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scan result :";
            // 
            // checkboxDeletefileJoin
            // 
            this.checkboxDeletefileJoin.AutoSize = true;
            this.checkboxDeletefileJoin.Location = new System.Drawing.Point(199, 327);
            this.checkboxDeletefileJoin.Name = "checkboxDeletefileJoin";
            this.checkboxDeletefileJoin.Size = new System.Drawing.Size(173, 19);
            this.checkboxDeletefileJoin.TabIndex = 12;
            this.checkboxDeletefileJoin.Text = "Delete original file after split";
            this.checkboxDeletefileJoin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(14, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 123);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memory Step Size (MB)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 59);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button_Join
            // 
            this.button_Join.Enabled = false;
            this.button_Join.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Join.Location = new System.Drawing.Point(199, 223);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(281, 98);
            this.button_Join.TabIndex = 10;
            this.button_Join.Text = "Join!";
            this.button_Join.UseVisualStyleBackColor = true;
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(486, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(465, 304);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScanFolderJoin);
            this.groupBox1.Controls.Add(this.tbScanFolderJoin);
            this.groupBox1.Controls.Add(this.radioScanFolderJoin);
            this.groupBox1.Controls.Add(this.radioSplitFileJoin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOutputJoin);
            this.groupBox1.Controls.Add(this.tbOutputJoin);
            this.groupBox1.Controls.Add(this.btnBrowseFileJoin);
            this.groupBox1.Controls.Add(this.tbJoinFile);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select file/folder/output";
            // 
            // btnScanFolderJoin
            // 
            this.btnScanFolderJoin.Location = new System.Drawing.Point(364, 44);
            this.btnScanFolderJoin.Name = "btnScanFolderJoin";
            this.btnScanFolderJoin.Size = new System.Drawing.Size(93, 27);
            this.btnScanFolderJoin.TabIndex = 9;
            this.btnScanFolderJoin.Text = "Browse folder";
            this.btnScanFolderJoin.UseVisualStyleBackColor = true;
            this.btnScanFolderJoin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbScanFolderJoin
            // 
            this.tbScanFolderJoin.Location = new System.Drawing.Point(12, 46);
            this.tbScanFolderJoin.Name = "tbScanFolderJoin";
            this.tbScanFolderJoin.Size = new System.Drawing.Size(345, 23);
            this.tbScanFolderJoin.TabIndex = 8;
            this.tbScanFolderJoin.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // radioScanFolderJoin
            // 
            this.radioScanFolderJoin.AutoSize = true;
            this.radioScanFolderJoin.Checked = true;
            this.radioScanFolderJoin.Location = new System.Drawing.Point(12, 21);
            this.radioScanFolderJoin.Name = "radioScanFolderJoin";
            this.radioScanFolderJoin.Size = new System.Drawing.Size(168, 19);
            this.radioScanFolderJoin.TabIndex = 7;
            this.radioScanFolderJoin.TabStop = true;
            this.radioScanFolderJoin.Text = "Scan folder for splitted files";
            this.radioScanFolderJoin.UseVisualStyleBackColor = true;
            this.radioScanFolderJoin.CheckedChanged += new System.EventHandler(this.radioScanFolderJoin_CheckedChanged);
            // 
            // radioSplitFileJoin
            // 
            this.radioSplitFileJoin.AutoSize = true;
            this.radioSplitFileJoin.Location = new System.Drawing.Point(12, 76);
            this.radioSplitFileJoin.Name = "radioSplitFileJoin";
            this.radioSplitFileJoin.Size = new System.Drawing.Size(116, 19);
            this.radioSplitFileJoin.TabIndex = 6;
            this.radioSplitFileJoin.Text = "Join a splitted file";
            this.radioSplitFileJoin.UseVisualStyleBackColor = true;
            this.radioSplitFileJoin.CheckedChanged += new System.EventHandler(this.radioSplitFileJoin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Path";
            // 
            // btnOutputJoin
            // 
            this.btnOutputJoin.Location = new System.Drawing.Point(365, 154);
            this.btnOutputJoin.Name = "btnOutputJoin";
            this.btnOutputJoin.Size = new System.Drawing.Size(93, 27);
            this.btnOutputJoin.TabIndex = 3;
            this.btnOutputJoin.Text = "Browse dir";
            this.btnOutputJoin.UseVisualStyleBackColor = true;
            this.btnOutputJoin.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOutputJoin
            // 
            this.tbOutputJoin.Location = new System.Drawing.Point(13, 157);
            this.tbOutputJoin.Name = "tbOutputJoin";
            this.tbOutputJoin.Size = new System.Drawing.Size(345, 23);
            this.tbOutputJoin.TabIndex = 2;
            this.tbOutputJoin.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // btnBrowseFileJoin
            // 
            this.btnBrowseFileJoin.Enabled = false;
            this.btnBrowseFileJoin.Location = new System.Drawing.Point(364, 100);
            this.btnBrowseFileJoin.Name = "btnBrowseFileJoin";
            this.btnBrowseFileJoin.Size = new System.Drawing.Size(94, 27);
            this.btnBrowseFileJoin.TabIndex = 1;
            this.btnBrowseFileJoin.Text = "Browse file";
            this.btnBrowseFileJoin.UseVisualStyleBackColor = true;
            this.btnBrowseFileJoin.Click += new System.EventHandler(this.btnBrowseFileJoin_Click);
            // 
            // tbJoinFile
            // 
            this.tbJoinFile.Enabled = false;
            this.tbJoinFile.Location = new System.Drawing.Point(12, 103);
            this.tbJoinFile.Name = "tbJoinFile";
            this.tbJoinFile.Size = new System.Drawing.Size(345, 23);
            this.tbJoinFile.TabIndex = 0;
            this.tbJoinFile.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // scanFolderJoinworker
            // 
            this.scanFolderJoinworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanFolderJoinworker_DoWork);
            this.scanFolderJoinworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.scanFolderJoinworker_RunWorkerCompleted);
            // 
            // joinWorker
            // 
            this.joinWorker.WorkerReportsProgress = true;
            this.joinWorker.WorkerSupportsCancellation = true;
            this.joinWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.joinWorker_DoWork);
            this.joinWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.joinWorker_ProgressChanged);
            this.joinWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.joinWorker_RunWorkerCompleted);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(679, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(78, 19);
            this.toolStripStatusLabel2.Text = "By pearlxcore";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 327);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split & Join Big File >4GB ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_FileSplit.ResumeLayout(false);
            this.groupBox_FileSplit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SplitSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_FileSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_FolderBrowse;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_FileBrowse;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Split;
        private System.Windows.Forms.NumericUpDown numericUpDown_SplitSize;
        private System.Windows.Forms.ComboBox comboBox_ByteSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_stepSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Split;
        private System.ComponentModel.BackgroundWorker splitWorker;
        private System.Windows.Forms.RadioButton radioScanFolder;
        private System.Windows.Forms.RadioButton radioSplitFile;
        private System.Windows.Forms.Button brnScanFolder;
        private System.Windows.Forms.TextBox tbScanFolder;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker ScanFolderWorker;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SplitNum;
        private System.Windows.Forms.CheckBox checkBoxDeleteFile;
        private System.Windows.Forms.Button button_Join;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScanFolderJoin;
        private System.Windows.Forms.TextBox tbScanFolderJoin;
        private System.Windows.Forms.RadioButton radioScanFolderJoin;
        private System.Windows.Forms.RadioButton radioSplitFileJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutputJoin;
        private System.Windows.Forms.TextBox tbOutputJoin;
        private System.Windows.Forms.Button btnBrowseFileJoin;
        private System.Windows.Forms.TextBox tbJoinFile;
        private System.ComponentModel.BackgroundWorker scanFolderJoinworker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.ComponentModel.BackgroundWorker joinWorker;
        private System.Windows.Forms.CheckBox checkboxDeletefileJoin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}