namespace WinDIRs
{
    partial class DIRReader
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbShowLines = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRowCounts = new System.Windows.Forms.Label();
            this.grpWriteOption = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbLatest500 = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.lblRowCountValue = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.grpWriteOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(486, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbShowLines
            // 
            this.rtbShowLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShowLines.Location = new System.Drawing.Point(0, 124);
            this.rtbShowLines.Name = "rtbShowLines";
            this.rtbShowLines.Size = new System.Drawing.Size(612, 326);
            this.rtbShowLines.TabIndex = 1;
            this.rtbShowLines.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.lblRowCounts);
            this.panel1.Controls.Add(this.grpWriteOption);
            this.panel1.Controls.Add(this.lblRowCountValue);
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.txtStop);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.lblStop);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 124);
            this.panel1.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.Location = new System.Drawing.Point(486, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRowCounts
            // 
            this.lblRowCounts.AutoSize = true;
            this.lblRowCounts.Location = new System.Drawing.Point(61, 103);
            this.lblRowCounts.Name = "lblRowCounts";
            this.lblRowCounts.Size = new System.Drawing.Size(66, 13);
            this.lblRowCounts.TabIndex = 12;
            this.lblRowCounts.Text = "Row Count :";
            // 
            // grpWriteOption
            // 
            this.grpWriteOption.Controls.Add(this.rbAll);
            this.grpWriteOption.Controls.Add(this.rbLatest500);
            this.grpWriteOption.Controls.Add(this.rbNone);
            this.grpWriteOption.Location = new System.Drawing.Point(64, 64);
            this.grpWriteOption.Name = "grpWriteOption";
            this.grpWriteOption.Size = new System.Drawing.Size(407, 36);
            this.grpWriteOption.TabIndex = 11;
            this.grpWriteOption.TabStop = false;
            this.grpWriteOption.Text = "Write Line Options";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(298, 13);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 11;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbLatest500
            // 
            this.rbLatest500.AutoSize = true;
            this.rbLatest500.Location = new System.Drawing.Point(179, 13);
            this.rbLatest500.Name = "rbLatest500";
            this.rbLatest500.Size = new System.Drawing.Size(75, 17);
            this.rbLatest500.TabIndex = 10;
            this.rbLatest500.Text = "Latest 500";
            this.rbLatest500.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(96, 13);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 9;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // lblRowCountValue
            // 
            this.lblRowCountValue.AutoSize = true;
            this.lblRowCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCountValue.ForeColor = System.Drawing.Color.Blue;
            this.lblRowCountValue.Location = new System.Drawing.Point(128, 102);
            this.lblRowCountValue.Name = "lblRowCountValue";
            this.lblRowCountValue.Size = new System.Drawing.Size(13, 16);
            this.lblRowCountValue.TabIndex = 8;
            this.lblRowCountValue.Text = "*";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(486, 9);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(64, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(407, 20);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "C:\\Users";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(29, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Path:";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(291, 39);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(180, 20);
            this.txtStop.TabIndex = 4;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(64, 38);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(180, 20);
            this.txtStart.TabIndex = 3;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(256, 42);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(35, 13);
            this.lblStop.TabIndex = 2;
            this.lblStop.Text = "Stop :";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(26, 42);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start :";
            // 
            // DIRReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.rtbShowLines);
            this.Controls.Add(this.panel1);
            this.Name = "DIRReader";
            this.Text = "DIR Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpWriteOption.ResumeLayout(false);
            this.grpWriteOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbShowLines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblRowCountValue;
        private System.Windows.Forms.GroupBox grpWriteOption;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbLatest500;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lblRowCounts;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
    }
}

