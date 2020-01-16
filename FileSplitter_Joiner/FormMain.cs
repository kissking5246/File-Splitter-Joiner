

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ByteSizeLib;

namespace FileSplitter_Joiner
{
    public partial class FormMain : Form
    {
        string[] root;
        List<string> allFiles = new List<string>();
        //List<string> foundfile = new List<string>();
        private const string SPLIT_ENDING = ".66600";
        public long sizeInBytes;
        private string itemName = "";
        private int countBigFile = 0;
        private int totalSplittedFile = 0;
        private string itemNameJoin = "";
        private string JoinFile = "";

        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBox_ByteSize.SelectedIndex = 2;
        }

        private long getMaxByteSize()
        {
            if (comboBox_ByteSize.SelectedIndex == 0) 
                return (long)numericUpDown_SplitSize.Value;
            else if (comboBox_ByteSize.SelectedIndex == 1) 
                return (long)numericUpDown_SplitSize.Value * 1024;
            else if (comboBox_ByteSize.SelectedIndex == 2) 
                return (long)numericUpDown_SplitSize.Value * 1024 * 1024;
            else return 0;
        }

        private static string openFile(string filter, string directory)
        {
            // open a file dialog asking for an input
            using (var openfile = new OpenFileDialog()
            { Title = "Select File To Split"})
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    return openfile.FileName;
                }

            
            return "";
        }

        private static string openFolder()
        {
            // open a folder browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = FileSplitter_Joiner.Properties.Settings.Default.OutputFolder;

            // get the path to store the output file
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileSplitter_Joiner.Properties.Settings.Default.OutputFolder = fbd.SelectedPath;
                FileSplitter_Joiner.Properties.Settings.Default.Save();
                return fbd.SelectedPath;
            }
            return "";
        }

        private static string openFolderJoin()
        {
            // open a folder browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = FileSplitter_Joiner.Properties.Settings.Default.OutputFolderJoin;

            // get the path to store the output file
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileSplitter_Joiner.Properties.Settings.Default.OutputFolderJoin = fbd.SelectedPath;
                FileSplitter_Joiner.Properties.Settings.Default.Save();
                return fbd.SelectedPath;
            }
            return "";
        }



        private void button_FileBrowse_Click(object sender, EventArgs e)
        {
           

            textBox_File.Text = openFile("All Files (*.*)|*.*", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            var fi = new FileInfo(textBox_File.Text);
            long size = fi.Length;
            var bytesize = ByteSizeLib.ByteSize.FromBytes(size);
            if (size < 4294967295U)
            {
                MessageBox.Show("Selected file is less than 4GB."); textBox_File.Text = ""; return;
            }

        }

        private void button_FolderBrowse_Click(object sender, EventArgs e)
        {
            textBox_Path.Text = openFolder();
        }

        private void userInputChanged(object sender, EventArgs e)
        {
            if (textBox_File.TextLength > 0 && File.Exists(textBox_File.Text))
            {
                // update the status label
                FileInfo fi = new FileInfo(textBox_File.Text);
                toolStripStatusLabel_SplitNum.Text = string.Format("{0} split files", Math.Ceiling(fi.Length / (double)getMaxByteSize()));
            }
            else 
                toolStripStatusLabel_SplitNum.Text = "0 split files";

            // check if the split can be enabled
            if (radioSplitFile.Checked == true)
            {
                if (Directory.Exists(textBox_Path.Text) && File.Exists(textBox_File.Text)) 
                    button_Split.Enabled = true;
                else 
                    button_Split.Enabled = false;
            }
            else
            {
                if (Directory.Exists(textBox_Path.Text) && Directory.Exists(tbScanFolder.Text)) 
                    button_Split.Enabled = true;
                else 
                    button_Split.Enabled = false;
            }

        }


        private void userInputChangedJoin(object sender, EventArgs e)
        {


            // check if the split can be enabled
            if (radioSplitFileJoin.Checked == true)
            {
                if (Directory.Exists(tbOutputJoin.Text) && File.Exists(tbJoinFile.Text)) 
                    button_Join.Enabled = true;
                else 
                    button_Join.Enabled = false;
            }
            else
            {
                if (Directory.Exists(tbOutputJoin.Text) && Directory.Exists(tbScanFolderJoin.Text)) 
                    button_Join.Enabled = true;
                else 
                    button_Join.Enabled = false;
            }

        }

        private void button_Split_Click(object sender, EventArgs e)
        {
            

            

            if (radioSplitFile.Checked == true)
            {
                button_Split.Enabled = false;
                toolStripProgressBar_Split.Visible = true;

                List<object> list = new List<object>();
                list.Add((long)numericUpDown_stepSize.Value * 1024 * 1024);
                list.Add(getMaxByteSize());
                list.Add(textBox_File.Text);
                list.Add(textBox_Path.Text);
                splitWorker.RunWorkerAsync(list);
                textBox_File.Text = "";
            }
            else
            {
                if (itemName == "")
                {
                    MessageBox.Show("Select an item to split.");
                    return;
                }

                var filename = Path.GetFileName(itemName);
                var myFile = new FileInfo(itemName);
                long size = myFile.Length;
                var bytesize = ByteSizeLib.ByteSize.FromBytes(size);

                toolStripLabel.Text = "Splitting " + filename + " (" + bytesize + ")";

                button_Split.Enabled = false;
                toolStripProgressBar_Split.Visible = true;

                List<object> list = new List<object>();
                list.Add((long)numericUpDown_stepSize.Value * 1024 * 1024);
                list.Add(getMaxByteSize());
                list.Add(itemName);
                list.Add(textBox_Path.Text);
                splitWorker.RunWorkerAsync(list);
                textBox_File.Text = "";
            }

        }

        private void splitWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var parameters = (List<object>)e.Argument;
                if (parameters == null) 
                    throw new ArgumentNullException("Pass 4 arguments to the splitWorker [long, long, string, string]");
                if (parameters.Count != 4) 
                    throw new ArgumentException("Pass 4 arguments to the splitWorker [long, long, string, string]");
                this.Enabled = false;

                SplitFilesAsync((BackgroundWorker)sender, (long)parameters.ElementAt(0), (long)parameters.ElementAt(1), (string)parameters.ElementAt(2), (string)parameters.ElementAt(3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripProgressBar_Split.Value = 0;
                toolStripLabel.Text = "...";
                itemName = "";
                this.Enabled = true;
            }

        }

        private void splitWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar_Split.Value = e.ProgressPercentage;
        }

        private void SplitFiles(long stepSize, long maxFileSize, string filename, string storagePath)
        {
            // check arguments
            if (filename == null) 
                throw new ArgumentNullException("The file name was not assigned a value");
            if (storagePath == null) 
                throw new ArgumentNullException("The storage path was not assigned a value");
            if (!File.Exists(filename)) 
                throw new ArgumentException(string.Format("The provided file <{0}> does not exist", filename));
            if (!Directory.Exists(storagePath)) 
                throw new ArgumentException(string.Format("The provided directory <{0}> does not exist", storagePath)); 
            if (stepSize < 1) 
                throw new ArgumentException(string.Format("The provided step size <{0}> must be larger than zero", stepSize));
            if (maxFileSize < 1) 
                throw new ArgumentException(string.Format("The provided maximum file size <{0}> must be larger than zero", maxFileSize)); 

            // create storage directory [Split_Files_%filename%_%date%_v%number%]
            int dirNum = 0;
            while (Directory.Exists(storagePath + @"\Split_Files_" + DateTime.Now.ToString("_yyyy-MM-dd") + string.Format("_v{0}", dirNum))) 
                dirNum++;
            storagePath += @"\Split_Files_" + DateTime.Now.ToString("_yyyy-MM-dd") + string.Format("_v{0}", dirNum);
            Directory.CreateDirectory(storagePath);
            if (!Directory.Exists(storagePath)) 
                throw new ArgumentException(string.Format("The created directory <{0}> does not exist", storagePath));

            // copy exe joiner to folder
            File.Copy("_FileJoiner.exe", storagePath + @"\_FileJoiner.exe");

            // open the file to be split
            using (FileStream source = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                long numBytesToRead = source.Length; // bytes in source that haven't been read
                long numBytesRead = 0; // bytes read in source
                byte[] bytes; // buffer to hold read data
                int fileNum = 0; // output filenumber
                bool reset = false; // flag 

                while (numBytesToRead > 0)
                {
                    int n = 0;
                    // read the source file
                    if (stepSize < maxFileSize - numBytesRead)
                    {
                        // read stepSize number of bytes
                        bytes = new byte[stepSize];
                        n = source.Read(bytes, 0, (int)stepSize);
                    }
                    else
                    {
                        // read the amount of bytes to reach the max file size
                        bytes = new byte[maxFileSize - numBytesRead];
                        n = source.Read(bytes, 0, (int)(maxFileSize - numBytesRead));
                        reset = true;
                    }

                    // break when the end of the file is reached. 
                    if (n == 0) break;

                    // adjust the byte size to the bytes read
                    if (n < bytes.Length)
                    {
                        byte[] temp = new byte[n];
                        Array.Copy(bytes, temp, n);
                        bytes = new byte[n];
                        bytes = temp;
                    }

                    // outfile name
                    string split_filename = storagePath + @"\" + Path.GetFileNameWithoutExtension(filename) + Path.GetExtension(filename) + "." + string.Format("{0:66600}", fileNum);

                    // create new file
                    if (!File.Exists(split_filename))
                    {
                        using (FileStream fsNew = new FileStream(split_filename, FileMode.Create, FileAccess.Write)) fsNew.Write(bytes, 0, bytes.Length);
                    }

                    // append bytes to existing file
                    else
                    {
                        using (FileStream fsApp = new FileStream(split_filename, FileMode.Append)) fsApp.Write(bytes, 0, bytes.Length);
                    }

                    // update the variables so a new file will be created
                    if (reset)
                    {
                        numBytesRead = 0;
                        fileNum++;
                        reset = false;
                    }
                    else numBytesRead += n;

                    // update the bytes remaining
                    numBytesToRead -= n;
                }

            }
        }

        private void SplitFilesAsync(BackgroundWorker worker, long stepSize, long maxFileSize, string filename, string storagePath)
        {
            // check arguments
            if (filename == null) 
                throw new ArgumentNullException("The file name was not assigned a value");
            if (storagePath == null) 
                throw new ArgumentNullException("The storage path was not assigned a value");
            if (!File.Exists(filename)) 
                throw new ArgumentException(string.Format("The provided file <{0}> does not exist", filename));
            if (!Directory.Exists(storagePath)) 
                throw new ArgumentException(string.Format("The provided directory <{0}> does not exist", storagePath));
            if (stepSize < 1) 
                throw new ArgumentException(string.Format("The provided step size <{0}> must be larger than zero", stepSize));
            if (maxFileSize < 1) 
                throw new ArgumentException(string.Format("The provided maximum file size <{0}> must be larger than zero", maxFileSize));

            var folderName = Path.GetFileName(filename);

            // create storage directory [Split_Files_%filename%_%date%_v%number%]
            //if (!Directory.Exists(storagePath + @"\" + folderName + "_splitted"))
            //    Directory.CreateDirectory(storagePath + @"\" + folderName + "_splitted");




            worker.ReportProgress(0);

            // copy exe joiner to folder
            //File.Copy("_FileJoiner.exe", storagePath + @"\_FileJoiner.exe");

            // open the file to be split
            using (FileStream source = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                long numBytesToRead = source.Length; // bytes in source that haven't been read
                long numBytesRead = 0; // bytes read in source
                byte[] bytes; // buffer to hold read data
                int fileNum = 0; // output filenumber
                bool reset = false; // flag 

                while (numBytesToRead > 0)
                {
                    int n = 0;
                    // read the source file
                    if (stepSize < maxFileSize - numBytesRead)
                    {
                        // read stepSize number of bytes
                        bytes = new byte[stepSize];
                        n = source.Read(bytes, 0, (int)stepSize);
                    }
                    else
                    {
                        // read the amount of bytes to reach the max file size
                        bytes = new byte[maxFileSize - numBytesRead];
                        n = source.Read(bytes, 0, (int)(maxFileSize - numBytesRead));
                        reset = true;
                    }

                    // break when the end of the file is reached. 
                    if (n == 0) break;

                    // adjust the byte size to the bytes read
                    if (n < bytes.Length)
                    {
                        byte[] temp = new byte[n];
                        Array.Copy(bytes, temp, n);
                        bytes = new byte[n];
                        bytes = temp;
                    }

                    // outfile name
                    string split_filename = storagePath + @"\" + Path.GetFileNameWithoutExtension(filename) + Path.GetExtension(filename) + "." + string.Format("{0:66600}", fileNum);
                    var filnameonly = Path.GetFileName(split_filename);
                    toolStripLabel.Text = "Processing " + filnameonly;



                    // create new file
                    if (!File.Exists(split_filename))
                    {
                        using (FileStream fsNew = new FileStream(split_filename, FileMode.Create, FileAccess.Write)) fsNew.Write(bytes, 0, bytes.Length);
                    }

                    // append bytes to existing file
                    else
                    {
                        using (FileStream fsApp = new FileStream(split_filename, FileMode.Append)) fsApp.Write(bytes, 0, bytes.Length);
                    }

                    // update the variables so a new file will be created
                    if (reset)
                    {
                        numBytesRead = 0;
                        fileNum++;
                        reset = false;
                    }
                    else numBytesRead += n;

                    // update the bytes remaining
                    numBytesToRead -= n;
                    worker.ReportProgress((int)((1 - (double)numBytesToRead / source.Length) * 100));
                }




                toolStripLabel.Text = "Splitting done.";
                MessageBox.Show("Splitting done.");
                toolStripProgressBar_Split.Value = 0;
            }

            if (checkBoxDeleteFile.Checked == true)
            {
                itemName = ""; File.Delete(filename);

            }

            this.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = FileSplitter_Joiner.Properties.Settings.Default.ScanFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileSplitter_Joiner.Properties.Settings.Default.ScanFolder = fbd.SelectedPath;
                FileSplitter_Joiner.Properties.Settings.Default.Save();

                tbScanFolder.Text = fbd.SelectedPath;

                listBox1.Items.Clear();

                if (ScanFolderWorker.IsBusy != true)
                    ScanFolderWorker.RunWorkerAsync();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSplitFile.Checked == true)
            {
                listBox1.Enabled = false;
                tbScanFolder.Enabled = false;
                brnScanFolder.Enabled = false;
                textBox_File.Enabled = true;
                button_FileBrowse.Enabled = true;
            }
            else
            {
                listBox1.Enabled = true;
                tbScanFolder.Enabled = true;
                brnScanFolder.Enabled = true;
                textBox_File.Enabled = false;
                button_FileBrowse.Enabled = false;
            }
        }

        private void radioScanFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioScanFolder.Checked == true)
            {
                listBox1.Enabled = true;
                tbScanFolder.Enabled = true;
                brnScanFolder.Enabled = true;
                textBox_File.Enabled = false;
                button_FileBrowse.Enabled = false;
            }
            else
            {
                listBox1.Enabled = false;
                tbScanFolder.Enabled = false;
                brnScanFolder.Enabled = false;
                textBox_File.Enabled = true;
                button_FileBrowse.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                listBox1.ClearSelected();
                return;
            }
            else
            {

                itemName = listBox1.GetItemText(listBox1.SelectedItem);

                toolStripLabel.Text = "Selected " + Path.GetFileName(itemName);

            }
        }

        private void ScanFolderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Enabled = false;
                toolStripLabel.Text = "Scanning files..";
            });

            var foundFile = Directory.EnumerateFiles(tbScanFolder.Text, "*.*", SearchOption.AllDirectories);




            foundFile.ToArray();

            countBigFile = 0;

            foreach (var file in foundFile)
            {

                long length = new System.IO.FileInfo(file).Length;

                if (length > 4294967295)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Add(file);
                    });

                    countBigFile++;




                }
            }



        }

        private void ScanFolderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                toolStripLabel.Text = "Scanning files done.";
                if (countBigFile == null)
                {
                    MessageBox.Show("No big files found.");
                }
                else
                {
                    MessageBox.Show("Found " + countBigFile + " big files.");
                }
                this.Enabled = true;
            });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = FileSplitter_Joiner.Properties.Settings.Default.ScanFolder_join;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileSplitter_Joiner.Properties.Settings.Default.ScanFolder_join = fbd.SelectedPath;
                FileSplitter_Joiner.Properties.Settings.Default.Save();

                tbScanFolderJoin.Text = fbd.SelectedPath;

                listBox2.Items.Clear();

                if (scanFolderJoinworker.IsBusy != true)
                    scanFolderJoinworker.RunWorkerAsync();

            }
        }

        private void scanFolderJoinworker_DoWork(object sender, DoWorkEventArgs e)
        {
            root = null;
            allFiles.Clear();
            totalSplittedFile = 0;

            this.Invoke((MethodInvoker)delegate
            {
                this.Enabled = false;
                toolStripLabel.Text = "Scanning files..";
            });

            root = Directory.GetFiles(tbScanFolderJoin.Text, "*.66600*", SearchOption.AllDirectories);


            foreach (var file in root)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    listBox2.Items.Add(file);

                });

                totalSplittedFile++;

            }



        }

        private void scanFolderJoinworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                toolStripLabel.Text = "Scanning files done.";
                if (totalSplittedFile == null)
                {
                    MessageBox.Show("No splitted files found.");
                }
                else
                {

                    MessageBox.Show("Found " + totalSplittedFile + " splitted files.");
                }
                this.Enabled = true;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbOutputJoin.Text = openFolderJoin();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                listBox2.ClearSelected();
                return;
            }
            else
            {

                itemNameJoin = listBox1.GetItemText(listBox2.SelectedItem);

                toolStripLabel.Text = "Selected " + Path.GetFileName(itemNameJoin);

            }
        }

        private void radioScanFolderJoin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioScanFolderJoin.Checked == true)
            {
                listBox2.Enabled = true;
                tbScanFolderJoin.Enabled = true;
                btnScanFolderJoin.Enabled = true;
                tbJoinFile.Enabled = false;
                btnBrowseFileJoin.Enabled = false;
            }
            else
            {
                listBox2.Enabled = false;
                tbScanFolderJoin.Enabled = false;
                btnScanFolderJoin.Enabled = false;
                tbJoinFile.Enabled = true;
                btnBrowseFileJoin.Enabled = true;
            }
        }

        private void radioSplitFileJoin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSplitFileJoin.Checked == true)
            {
                listBox2.Enabled = false;
                tbScanFolderJoin.Enabled = false;
                btnScanFolderJoin.Enabled = false;
                tbJoinFile.Enabled = true;
                btnBrowseFileJoin.Enabled = true;
            }
            else
            {
                listBox2.Enabled = true;
                tbScanFolderJoin.Enabled = true;
                btnScanFolderJoin.Enabled = true;
                tbJoinFile.Enabled = false;
                btnBrowseFileJoin.Enabled = false;
            }
        }

        private void btnBrowseFileJoin_Click(object sender, EventArgs e)
        {
            using (var openfile = new OpenFileDialog()
            { Title = "Select Splitted File", Filter = "Splitted Files (*.66600)|*.66600|All files (*.*)|*.*" })
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    tbJoinFile.Text = openfile.FileName;

                    var ext = Path.GetExtension(tbJoinFile.Text);
                    if (ext != ".66600")
                    {
                        MessageBox.Show("Selected file is not valid.");
                        tbJoinFile.Text = "";
                        return;
                    }
                }

            


            
        }

        private void button_Join_Click(object sender, EventArgs e)
        {

            if (joinWorker.IsBusy != true)
                joinWorker.RunWorkerAsync();

        }



        private void JoinFileProcess()
        {
            // get all files in the current directory
            List<string> AllFiles = new List<string>(Directory.GetFiles(JoinFile, "*", SearchOption.TopDirectoryOnly));
        }

        private void joinWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.Enabled = false;

                this.Invoke((MethodInvoker)delegate
                {
                    toolStripProgressBar_Split.Visible = true;

                });

                int countFile = 0;

                string file = tbJoinFile.Text;
                string FileName = Path.GetFileName(file); // [example.txt.0000000] -> [example.txt] -> [example][_fs0][.txt]
                string FileNameWithoutSplit = Path.GetFileNameWithoutExtension(file);//[example.txt]
                string directoryName = Path.GetDirectoryName(file) + @"\";
                string filenameOnly = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file);
                var extPath = FileNameWithoutSplit.Substring(FileNameWithoutSplit.LastIndexOf('.') + 1);
                var searchOption = "" + FileNameWithoutSplit.GetUntilOrEmpty() + "." + extPath + ".*";
                var foundFile = Directory.EnumerateFiles(directoryName, searchOption);

                // get files that are splits
                string validpattern = @"^.*\.\d{" + (SPLIT_ENDING.Length - 1).ToString() + "}$";
                Regex regex = new Regex(validpattern);
                List<string> validSplits = foundFile.Where(str => regex.IsMatch(str)).ToList();

                foreach (var item in validSplits)
                {
                    countFile++;
                }

                toolStripProgressBar_Split.Maximum = countFile;


                // get the first split files in each
                var patternfirst_split = @"^.*\" + ".66600" + "$";
                var regexfirst_split = new Regex(patternfirst_split);
                List<string> baseSplits = validSplits.Where(str => regexfirst_split.IsMatch(str)).ToList();

                string finalFileName = "";

                foreach (var item in baseSplits)
                {
                    validSplits.Remove(item);


                    // [example.txt.0000000] -> [example.txt] -> [example][_fs0][.txt]
                    string fullFileName = Path.GetFileNameWithoutExtension(item);
                    string fileName = Path.GetFileNameWithoutExtension(fullFileName);
                    string fileExt = Path.GetExtension(fullFileName);
                    int versionNum = 0;

                    // search for a unique file name, and copy the first part
                    string file_format = @"\{0}{1}{2}";
                    while (File.Exists(file + string.Format(file_format, fileName, versionNum, fileExt))) versionNum++;

                    this.Invoke((MethodInvoker)delegate
                    {
                        toolStripLabel.Text = "Processing " + FileName;

                    });

                    File.Copy(item, directoryName + string.Format(file_format, fileName, versionNum, fileExt));
                    finalFileName = string.Format(file_format, fileName, versionNum, fileExt);
                    File.Delete(item);
                    toolStripProgressBar_Split.Increment(1);


                    // get all part files associated with full file
                    patternfirst_split = fullFileName;
                    regex = new Regex(patternfirst_split);
                    List<string> fileParts = validSplits.Where(str => regex.IsMatch(str)).ToList();
                    fileParts.Sort();

                    // append each file to the base split
                    foreach (string filePart in fileParts)
                    {
                        var _filename = Path.GetFileName(filePart);

                        this.Invoke((MethodInvoker)delegate
                        {
                            toolStripLabel.Text = "Processing " + _filename;

                        });

                        // open each file and append
                        using (FileStream source = new FileStream(filePart, FileMode.Open, FileAccess.Read))
                        {
                            long numBytesToRead = source.Length; // bytes in source that haven't been read
                            long numBytesRead = 0; // bytes read in source
                            long stepSize = (long)numericUpDown1.Value * 1024 * 1024; // 8 MB buffer
                            byte[] bytes; // buffer to hold read data
                            int n;
                            while (numBytesToRead > 0)
                            {
                                // read the step size amount of bytes
                                bytes = new byte[stepSize];
                                n = source.Read(bytes, 0, (int)stepSize);

                                // break when the end of the file is reached. 
                                if (n == 0) break;

                                // adjust the byte size to the actual bytes read
                                if (n < bytes.Length)
                                {
                                    byte[] temp = new byte[n];
                                    Array.Copy(bytes, temp, n);
                                    bytes = new byte[n];
                                    bytes = temp;
                                }

                                // append the read bytes to the output file
                                using (FileStream fsApp = new FileStream(directoryName + string.Format(file_format, fileName, versionNum, fileExt), FileMode.Append)) fsApp.Write(bytes, 0, bytes.Length);

                                // update the bytes remaining
                                numBytesRead += n;
                                numBytesToRead -= n;

                            }
                        }

                       
                        // delete the partFile
                        if(checkboxDeletefileJoin.Checked == true)
                            File.Delete(filePart);

                        toolStripProgressBar_Split.Increment(1);
                    }


                }

                File.Move(directoryName + finalFileName, tbOutputJoin.Text + @"\" + FileNameWithoutSplit);


                MessageBox.Show("Done.");

                toolStripProgressBar_Split.Value = countFile;
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripProgressBar_Split.Visible = false;
                    toolStripLabel.Text = "Splitting done.";
                });
                toolStripProgressBar_Split.Value = 0;
                this.Enabled = true;

            }
            catch (Exception ex)
            {
                this.Enabled = true;
                toolStripProgressBar_Split.Value = 0;
                toolStripProgressBar_Split.Visible = false;
                MessageBox.Show(ex.Message);
                toolStripLabel.Text = "...";
            }
        }

        private void joinWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void joinWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar_Split.Value = e.ProgressPercentage;

        }
    }
}