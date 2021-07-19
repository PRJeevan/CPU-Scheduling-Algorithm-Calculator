namespace CPU_Simulator {
    partial class ProgramForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cpuExecutionTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.throughputLabel = new System.Windows.Forms.Label();
            this.utilizationLabel = new System.Windows.Forms.Label();
            this.averageResponseTimeLabel = new System.Windows.Forms.Label();
            this.averageTurnaroundTimeLabel = new System.Windows.Forms.Label();
            this.averageWaitingTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileBrowser = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.cpuWorkflowBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.randomBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.psPreemtiveCheck = new System.Windows.Forms.CheckBox();
            this.sjfPreemtiveCheck = new System.Windows.Forms.CheckBox();
            this.timeQuantumBox = new System.Windows.Forms.NumericUpDown();
            this.sjfBtn = new System.Windows.Forms.RadioButton();
            this.psBtn = new System.Windows.Forms.RadioButton();
            this.rrBtn = new System.Windows.Forms.RadioButton();
            this.calcBtn = new System.Windows.Forms.Button();
            this.fcfsBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeQuantumBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "InputData";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.cpuExecutionTimeLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.throughputLabel);
            this.groupBox3.Controls.Add(this.utilizationLabel);
            this.groupBox3.Controls.Add(this.averageResponseTimeLabel);
            this.groupBox3.Controls.Add(this.averageTurnaroundTimeLabel);
            this.groupBox3.Controls.Add(this.averageWaitingTimeLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cpuExecutionTimeLabel
            // 
            resources.ApplyResources(this.cpuExecutionTimeLabel, "cpuExecutionTimeLabel");
            this.cpuExecutionTimeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.cpuExecutionTimeLabel.Name = "cpuExecutionTimeLabel";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // throughputLabel
            // 
            resources.ApplyResources(this.throughputLabel, "throughputLabel");
            this.throughputLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.throughputLabel.Name = "throughputLabel";
            // 
            // utilizationLabel
            // 
            resources.ApplyResources(this.utilizationLabel, "utilizationLabel");
            this.utilizationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.utilizationLabel.Name = "utilizationLabel";
            // 
            // averageResponseTimeLabel
            // 
            resources.ApplyResources(this.averageResponseTimeLabel, "averageResponseTimeLabel");
            this.averageResponseTimeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.averageResponseTimeLabel.Name = "averageResponseTimeLabel";
            // 
            // averageTurnaroundTimeLabel
            // 
            resources.ApplyResources(this.averageTurnaroundTimeLabel, "averageTurnaroundTimeLabel");
            this.averageTurnaroundTimeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.averageTurnaroundTimeLabel.Name = "averageTurnaroundTimeLabel";
            // 
            // averageWaitingTimeLabel
            // 
            resources.ApplyResources(this.averageWaitingTimeLabel, "averageWaitingTimeLabel");
            this.averageWaitingTimeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.averageWaitingTimeLabel.Name = "averageWaitingTimeLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fileBrowser
            // 
            this.fileBrowser.BackColor = System.Drawing.Color.White;
            this.fileBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.fileBrowser, "fileBrowser");
            this.fileBrowser.Name = "fileBrowser";
            this.toolTip2.SetToolTip(this.fileBrowser, resources.GetString("fileBrowser.ToolTip"));
            this.fileBrowser.UseVisualStyleBackColor = false;
            this.fileBrowser.Click += new System.EventHandler(this.FileBrowser_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox0
            // 
            this.groupBox0.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.groupBox0, "groupBox0");
            this.groupBox0.Controls.Add(this.cpuWorkflowBox);
            this.groupBox0.Controls.Add(this.label7);
            this.groupBox0.Controls.Add(this.dataGridView);
            this.groupBox0.Controls.Add(this.fileBrowser);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.TabStop = false;
            // 
            // cpuWorkflowBox
            // 
            this.cpuWorkflowBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpuWorkflowBox.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.cpuWorkflowBox, "cpuWorkflowBox");
            this.cpuWorkflowBox.Name = "cpuWorkflowBox";
            this.cpuWorkflowBox.ReadOnly = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Random Numbers Range";
            // 
            // randomBtn
            // 
            this.randomBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.randomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.randomBtn, "randomBtn");
            this.randomBtn.Name = "randomBtn";
            this.toolTip1.SetToolTip(this.randomBtn, resources.GetString("randomBtn.ToolTip"));
            this.randomBtn.UseVisualStyleBackColor = false;
            this.randomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 1000;
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.ForeColor = System.Drawing.Color.Ivory;
            this.toolTip2.InitialDelay = 1000;
            this.toolTip2.ReshowDelay = 200;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Data Input File Info";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Name = "label8";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Name = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Name = "label11";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Name = "label12";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // psPreemtiveCheck
            // 
            resources.ApplyResources(this.psPreemtiveCheck, "psPreemtiveCheck");
            this.psPreemtiveCheck.BackColor = System.Drawing.Color.White;
            this.psPreemtiveCheck.Name = "psPreemtiveCheck";
            this.psPreemtiveCheck.UseVisualStyleBackColor = false;
            this.psPreemtiveCheck.CheckedChanged += new System.EventHandler(this.psPreemtiveCheck_CheckedChanged);
            // 
            // sjfPreemtiveCheck
            // 
            resources.ApplyResources(this.sjfPreemtiveCheck, "sjfPreemtiveCheck");
            this.sjfPreemtiveCheck.BackColor = System.Drawing.Color.GhostWhite;
            this.sjfPreemtiveCheck.Name = "sjfPreemtiveCheck";
            this.sjfPreemtiveCheck.UseVisualStyleBackColor = false;
            this.sjfPreemtiveCheck.CheckedChanged += new System.EventHandler(this.sjfPreemtiveCheck_CheckedChanged);
            // 
            // timeQuantumBox
            // 
            resources.ApplyResources(this.timeQuantumBox, "timeQuantumBox");
            this.timeQuantumBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timeQuantumBox.Name = "timeQuantumBox";
            this.timeQuantumBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timeQuantumBox.ValueChanged += new System.EventHandler(this.timeQuantumBox_ValueChanged);
            // 
            // sjfBtn
            // 
            resources.ApplyResources(this.sjfBtn, "sjfBtn");
            this.sjfBtn.ForeColor = System.Drawing.Color.Black;
            this.sjfBtn.Name = "sjfBtn";
            this.sjfBtn.TabStop = true;
            this.sjfBtn.UseVisualStyleBackColor = false;
            this.sjfBtn.CheckedChanged += new System.EventHandler(this.SjfBtn_CheckedChanged);
            // 
            // psBtn
            // 
            resources.ApplyResources(this.psBtn, "psBtn");
            this.psBtn.ForeColor = System.Drawing.Color.Black;
            this.psBtn.Name = "psBtn";
            this.psBtn.TabStop = true;
            this.psBtn.UseVisualStyleBackColor = true;
            this.psBtn.CheckedChanged += new System.EventHandler(this.PsBtn_CheckedChanged);
            // 
            // rrBtn
            // 
            resources.ApplyResources(this.rrBtn, "rrBtn");
            this.rrBtn.ForeColor = System.Drawing.Color.Black;
            this.rrBtn.Name = "rrBtn";
            this.rrBtn.TabStop = true;
            this.rrBtn.UseVisualStyleBackColor = true;
            this.rrBtn.CheckedChanged += new System.EventHandler(this.RrBtn_CheckedChanged);
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.calcBtn, "calcBtn");
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // fcfsBtn
            // 
            resources.ApplyResources(this.fcfsBtn, "fcfsBtn");
            this.fcfsBtn.ForeColor = System.Drawing.Color.Black;
            this.fcfsBtn.Name = "fcfsBtn";
            this.fcfsBtn.TabStop = true;
            this.fcfsBtn.UseVisualStyleBackColor = true;
            this.fcfsBtn.CheckedChanged += new System.EventHandler(this.FcfsBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.randomBtn);
            this.groupBox2.Controls.Add(this.fcfsBtn);
            this.groupBox2.Controls.Add(this.calcBtn);
            this.groupBox2.Controls.Add(this.rrBtn);
            this.groupBox2.Controls.Add(this.psBtn);
            this.groupBox2.Controls.Add(this.sjfBtn);
            this.groupBox2.Controls.Add(this.timeQuantumBox);
            this.groupBox2.Controls.Add(this.sjfPreemtiveCheck);
            this.groupBox2.Controls.Add(this.psPreemtiveCheck);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // ProgramForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPU_Simulator.Properties.Resources.a13;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ProgramForm";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox0.ResumeLayout(false);
            this.groupBox0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeQuantumBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label throughputLabel;
        private System.Windows.Forms.Label utilizationLabel;
        private System.Windows.Forms.Label averageResponseTimeLabel;
        private System.Windows.Forms.Label averageTurnaroundTimeLabel;
        private System.Windows.Forms.Label averageWaitingTimeLabel;
        private System.Windows.Forms.Label cpuExecutionTimeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fileBrowser;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cpuWorkflowBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox psPreemtiveCheck;
        private System.Windows.Forms.CheckBox sjfPreemtiveCheck;
        private System.Windows.Forms.NumericUpDown timeQuantumBox;
        private System.Windows.Forms.RadioButton sjfBtn;
        private System.Windows.Forms.RadioButton psBtn;
        private System.Windows.Forms.RadioButton rrBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.RadioButton fcfsBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
    }
}

