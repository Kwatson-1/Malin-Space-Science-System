namespace Satellite_Data_Processing_Project
{
    partial class ApplicationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMu = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnSensorA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSensorB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInsertionSortA = new System.Windows.Forms.Button();
            this.textBoxTimeInsertionA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSelectionSortA = new System.Windows.Forms.Button();
            this.textBoxTimeSelectionA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRecursiveSearchA = new System.Windows.Forms.Button();
            this.textBoxTimeRecursiveA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIterativeSearchA = new System.Windows.Forms.Button();
            this.textBoxTimeIterativeA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchTargetA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.buttonInsertionSortB = new System.Windows.Forms.Button();
            this.textBoxTimeInsertionB = new System.Windows.Forms.TextBox();
            this.textBoxSearchTargetB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSelectionSortB = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTimeSelectionB = new System.Windows.Forms.TextBox();
            this.textBoxTimeIterativeB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonIterativeSearchB = new System.Windows.Forms.Button();
            this.buttonRecursiveSearchB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTimeRecursiveB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mu";
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.Location = new System.Drawing.Point(269, 33);
            this.numericUpDownSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSigma.TabIndex = 2;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMu
            // 
            this.numericUpDownMu.Location = new System.Drawing.Point(358, 33);
            this.numericUpDownMu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownMu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownMu.Name = "numericUpDownMu";
            this.numericUpDownMu.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownMu.TabIndex = 3;
            this.numericUpDownMu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSensorA,
            this.columnSensorB});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(269, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 384);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnSensorA
            // 
            this.columnSensorA.Text = "SensorA";
            this.columnSensorA.Width = 83;
            // 
            // columnSensorB
            // 
            this.columnSensorB.Text = "SensorB";
            this.columnSensorB.Width = 82;
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.Location = new System.Drawing.Point(15, 62);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxA.Size = new System.Drawing.Size(120, 407);
            this.listBoxA.TabIndex = 5;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(269, 59);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(169, 23);
            this.buttonLoadData.TabIndex = 7;
            this.buttonLoadData.Text = "Load Sensor Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInsertionSortA);
            this.groupBox1.Controls.Add(this.textBoxTimeInsertionA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonSelectionSortA);
            this.groupBox1.Controls.Add(this.textBoxTimeSelectionA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonRecursiveSearchA);
            this.groupBox1.Controls.Add(this.textBoxTimeRecursiveA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonIterativeSearchA);
            this.groupBox1.Controls.Add(this.textBoxTimeIterativeA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSearchTargetA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 439);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor A";
            // 
            // buttonInsertionSortA
            // 
            this.buttonInsertionSortA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertionSortA.Location = new System.Drawing.Point(126, 362);
            this.buttonInsertionSortA.Name = "buttonInsertionSortA";
            this.buttonInsertionSortA.Size = new System.Drawing.Size(118, 23);
            this.buttonInsertionSortA.TabIndex = 13;
            this.buttonInsertionSortA.Text = "Sort";
            this.buttonInsertionSortA.UseVisualStyleBackColor = true;
            this.buttonInsertionSortA.Click += new System.EventHandler(this.buttonInsertionSortA_Click);
            // 
            // textBoxTimeInsertionA
            // 
            this.textBoxTimeInsertionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeInsertionA.Location = new System.Drawing.Point(126, 389);
            this.textBoxTimeInsertionA.Name = "textBoxTimeInsertionA";
            this.textBoxTimeInsertionA.ReadOnly = true;
            this.textBoxTimeInsertionA.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeInsertionA.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Insertion Sort";
            // 
            // buttonSelectionSortA
            // 
            this.buttonSelectionSortA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionSortA.Location = new System.Drawing.Point(126, 272);
            this.buttonSelectionSortA.Name = "buttonSelectionSortA";
            this.buttonSelectionSortA.Size = new System.Drawing.Size(118, 23);
            this.buttonSelectionSortA.TabIndex = 10;
            this.buttonSelectionSortA.Text = "Sort";
            this.buttonSelectionSortA.UseVisualStyleBackColor = true;
            this.buttonSelectionSortA.Click += new System.EventHandler(this.ButtonSelectionSortA_Click);
            // 
            // textBoxTimeSelectionA
            // 
            this.textBoxTimeSelectionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeSelectionA.Location = new System.Drawing.Point(126, 299);
            this.textBoxTimeSelectionA.Name = "textBoxTimeSelectionA";
            this.textBoxTimeSelectionA.ReadOnly = true;
            this.textBoxTimeSelectionA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTimeSelectionA.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeSelectionA.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Selection Sort";
            // 
            // buttonRecursiveSearchA
            // 
            this.buttonRecursiveSearchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecursiveSearchA.Location = new System.Drawing.Point(127, 182);
            this.buttonRecursiveSearchA.Name = "buttonRecursiveSearchA";
            this.buttonRecursiveSearchA.Size = new System.Drawing.Size(118, 23);
            this.buttonRecursiveSearchA.TabIndex = 7;
            this.buttonRecursiveSearchA.Text = "Search";
            this.buttonRecursiveSearchA.UseVisualStyleBackColor = true;
            // 
            // textBoxTimeRecursiveA
            // 
            this.textBoxTimeRecursiveA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeRecursiveA.Location = new System.Drawing.Point(127, 209);
            this.textBoxTimeRecursiveA.Name = "textBoxTimeRecursiveA";
            this.textBoxTimeRecursiveA.ReadOnly = true;
            this.textBoxTimeRecursiveA.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeRecursiveA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recursive Binary Search";
            // 
            // buttonIterativeSearchA
            // 
            this.buttonIterativeSearchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIterativeSearchA.Location = new System.Drawing.Point(127, 92);
            this.buttonIterativeSearchA.Name = "buttonIterativeSearchA";
            this.buttonIterativeSearchA.Size = new System.Drawing.Size(118, 23);
            this.buttonIterativeSearchA.TabIndex = 4;
            this.buttonIterativeSearchA.Text = "Search";
            this.buttonIterativeSearchA.UseVisualStyleBackColor = true;
            this.buttonIterativeSearchA.Click += new System.EventHandler(this.ButtonIterativeSearchA_Click);
            // 
            // textBoxTimeIterativeA
            // 
            this.textBoxTimeIterativeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeIterativeA.Location = new System.Drawing.Point(127, 119);
            this.textBoxTimeIterativeA.Name = "textBoxTimeIterativeA";
            this.textBoxTimeIterativeA.ReadOnly = true;
            this.textBoxTimeIterativeA.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeIterativeA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Iterative Binary Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search Target";
            // 
            // textBoxSearchTargetA
            // 
            this.textBoxSearchTargetA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearchTargetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTargetA.Location = new System.Drawing.Point(126, 43);
            this.textBoxSearchTargetA.Name = "textBoxSearchTargetA";
            this.textBoxSearchTargetA.Size = new System.Drawing.Size(119, 20);
            this.textBoxSearchTargetA.TabIndex = 0;
            this.textBoxSearchTargetA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchTargetA_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxB);
            this.groupBox2.Controls.Add(this.buttonInsertionSortB);
            this.groupBox2.Controls.Add(this.textBoxTimeInsertionB);
            this.groupBox2.Controls.Add(this.textBoxSearchTargetB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonSelectionSortB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxTimeSelectionB);
            this.groupBox2.Controls.Add(this.textBoxTimeIterativeB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonIterativeSearchB);
            this.groupBox2.Controls.Add(this.buttonRecursiveSearchB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxTimeRecursiveB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(251, 439);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor B";
            // 
            // listBoxB
            // 
            this.listBoxB.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.Location = new System.Drawing.Point(128, 27);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxB.Size = new System.Drawing.Size(120, 409);
            this.listBoxB.TabIndex = 14;
            // 
            // buttonInsertionSortB
            // 
            this.buttonInsertionSortB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertionSortB.Location = new System.Drawing.Point(6, 362);
            this.buttonInsertionSortB.Name = "buttonInsertionSortB";
            this.buttonInsertionSortB.Size = new System.Drawing.Size(118, 23);
            this.buttonInsertionSortB.TabIndex = 27;
            this.buttonInsertionSortB.Text = "Sort";
            this.buttonInsertionSortB.UseVisualStyleBackColor = true;
            this.buttonInsertionSortB.Click += new System.EventHandler(this.buttonInsertionSortB_Click);
            // 
            // textBoxTimeInsertionB
            // 
            this.textBoxTimeInsertionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeInsertionB.Location = new System.Drawing.Point(6, 389);
            this.textBoxTimeInsertionB.Name = "textBoxTimeInsertionB";
            this.textBoxTimeInsertionB.ReadOnly = true;
            this.textBoxTimeInsertionB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTimeInsertionB.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeInsertionB.TabIndex = 26;
            this.textBoxTimeInsertionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSearchTargetB
            // 
            this.textBoxSearchTargetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTargetB.Location = new System.Drawing.Point(6, 43);
            this.textBoxSearchTargetB.Name = "textBoxSearchTargetB";
            this.textBoxSearchTargetB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearchTargetB.Size = new System.Drawing.Size(119, 20);
            this.textBoxSearchTargetB.TabIndex = 14;
            this.textBoxSearchTargetB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSearchTargetB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchTargetB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 346);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Insertion Sort";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Search Target";
            // 
            // buttonSelectionSortB
            // 
            this.buttonSelectionSortB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionSortB.Location = new System.Drawing.Point(6, 272);
            this.buttonSelectionSortB.Name = "buttonSelectionSortB";
            this.buttonSelectionSortB.Size = new System.Drawing.Size(118, 23);
            this.buttonSelectionSortB.TabIndex = 24;
            this.buttonSelectionSortB.Text = "Sort";
            this.buttonSelectionSortB.UseVisualStyleBackColor = true;
            this.buttonSelectionSortB.Click += new System.EventHandler(this.buttonSelectionSortB_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Iterative Binary Search";
            // 
            // textBoxTimeSelectionB
            // 
            this.textBoxTimeSelectionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeSelectionB.Location = new System.Drawing.Point(7, 299);
            this.textBoxTimeSelectionB.Name = "textBoxTimeSelectionB";
            this.textBoxTimeSelectionB.ReadOnly = true;
            this.textBoxTimeSelectionB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTimeSelectionB.Size = new System.Drawing.Size(117, 20);
            this.textBoxTimeSelectionB.TabIndex = 23;
            this.textBoxTimeSelectionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTimeIterativeB
            // 
            this.textBoxTimeIterativeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeIterativeB.Location = new System.Drawing.Point(7, 119);
            this.textBoxTimeIterativeB.Name = "textBoxTimeIterativeB";
            this.textBoxTimeIterativeB.ReadOnly = true;
            this.textBoxTimeIterativeB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTimeIterativeB.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeIterativeB.TabIndex = 17;
            this.textBoxTimeIterativeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Selection Sort";
            // 
            // buttonIterativeSearchB
            // 
            this.buttonIterativeSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIterativeSearchB.Location = new System.Drawing.Point(7, 92);
            this.buttonIterativeSearchB.Name = "buttonIterativeSearchB";
            this.buttonIterativeSearchB.Size = new System.Drawing.Size(118, 23);
            this.buttonIterativeSearchB.TabIndex = 18;
            this.buttonIterativeSearchB.Text = "Search";
            this.buttonIterativeSearchB.UseVisualStyleBackColor = true;
            this.buttonIterativeSearchB.Click += new System.EventHandler(this.ButtonIterativeSearchB_Click);
            // 
            // buttonRecursiveSearchB
            // 
            this.buttonRecursiveSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecursiveSearchB.Location = new System.Drawing.Point(7, 182);
            this.buttonRecursiveSearchB.Name = "buttonRecursiveSearchB";
            this.buttonRecursiveSearchB.Size = new System.Drawing.Size(118, 23);
            this.buttonRecursiveSearchB.TabIndex = 21;
            this.buttonRecursiveSearchB.Text = "Search";
            this.buttonRecursiveSearchB.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Recursive Binary Search";
            // 
            // textBoxTimeRecursiveB
            // 
            this.textBoxTimeRecursiveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeRecursiveB.Location = new System.Drawing.Point(7, 209);
            this.textBoxTimeRecursiveB.Name = "textBoxTimeRecursiveB";
            this.textBoxTimeRecursiveB.ReadOnly = true;
            this.textBoxTimeRecursiveB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTimeRecursiveB.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeRecursiveB.TabIndex = 20;
            this.textBoxTimeRecursiveB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 484);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.listBoxA);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numericUpDownMu);
            this.Controls.Add(this.numericUpDownSigma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ApplicationForm";
            this.Text = "Data Processing Application";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.NumericUpDown numericUpDownMu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnSensorA;
        private System.Windows.Forms.ColumnHeader columnSensorB;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearchTargetA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInsertionSortA;
        private System.Windows.Forms.TextBox textBoxTimeInsertionA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSelectionSortA;
        private System.Windows.Forms.TextBox textBoxTimeSelectionA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRecursiveSearchA;
        private System.Windows.Forms.TextBox textBoxTimeRecursiveA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIterativeSearchA;
        private System.Windows.Forms.TextBox textBoxTimeIterativeA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.Button buttonInsertionSortB;
        private System.Windows.Forms.TextBox textBoxTimeInsertionB;
        private System.Windows.Forms.TextBox textBoxSearchTargetB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSelectionSortB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTimeSelectionB;
        private System.Windows.Forms.TextBox textBoxTimeIterativeB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonIterativeSearchB;
        private System.Windows.Forms.Button buttonRecursiveSearchB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTimeRecursiveB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

