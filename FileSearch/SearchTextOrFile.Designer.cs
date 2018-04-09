namespace FileSearch
{
    partial class SearchTextOrFile
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchIn = new System.Windows.Forms.TextBox();
            this.txtContainingText = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblSearchIn = new System.Windows.Forms.Label();
            this.lblContainingText = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblStatusResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSearchedResult = new System.Windows.Forms.Label();
            this.lblSearched = new System.Windows.Forms.Label();
            this.lblFoundResult = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchIn);
            this.splitContainer1.Panel1.Controls.Add(this.txtContainingText);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileName);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearchIn);
            this.splitContainer1.Panel1.Controls.Add(this.lblContainingText);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 728);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(706, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1074, 72);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 49);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1074, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 53);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchIn
            // 
            this.txtSearchIn.Location = new System.Drawing.Point(123, 72);
            this.txtSearchIn.Name = "txtSearchIn";
            this.txtSearchIn.Size = new System.Drawing.Size(558, 20);
            this.txtSearchIn.TabIndex = 5;
            // 
            // txtContainingText
            // 
            this.txtContainingText.Location = new System.Drawing.Point(123, 42);
            this.txtContainingText.Name = "txtContainingText";
            this.txtContainingText.Size = new System.Drawing.Size(558, 20);
            this.txtContainingText.TabIndex = 4;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(123, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(558, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // lblSearchIn
            // 
            this.lblSearchIn.AutoSize = true;
            this.lblSearchIn.Location = new System.Drawing.Point(16, 72);
            this.lblSearchIn.Name = "lblSearchIn";
            this.lblSearchIn.Size = new System.Drawing.Size(55, 13);
            this.lblSearchIn.TabIndex = 2;
            this.lblSearchIn.Text = "Search in:";
            // 
            // lblContainingText
            // 
            this.lblContainingText.AutoSize = true;
            this.lblContainingText.Location = new System.Drawing.Point(16, 42);
            this.lblContainingText.Name = "lblContainingText";
            this.lblContainingText.Size = new System.Drawing.Size(84, 13);
            this.lblContainingText.TabIndex = 1;
            this.lblContainingText.Text = "Containing Text:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 13);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel1.Controls.Add(this.dgvResults);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel2.Controls.Add(this.lblStatusResult);
            this.splitContainer2.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer2.Panel2.Controls.Add(this.lblSearchedResult);
            this.splitContainer2.Panel2.Controls.Add(this.lblSearched);
            this.splitContainer2.Panel2.Controls.Add(this.lblFoundResult);
            this.splitContainer2.Panel2.Controls.Add(this.lblFound);
            this.splitContainer2.Panel2.Controls.Add(this.lblSummary);
            this.splitContainer2.Size = new System.Drawing.Size(1181, 582);
            this.splitContainer2.SplitterDistance = 745;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(743, 580);
            this.dgvResults.TabIndex = 0;
            // 
            // lblStatusResult
            // 
            this.lblStatusResult.AutoSize = true;
            this.lblStatusResult.Location = new System.Drawing.Point(149, 118);
            this.lblStatusResult.Name = "lblStatusResult";
            this.lblStatusResult.Size = new System.Drawing.Size(80, 13);
            this.lblStatusResult.TabIndex = 6;
            this.lblStatusResult.Text = "Not Started Yet";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblSearchedResult
            // 
            this.lblSearchedResult.AutoSize = true;
            this.lblSearchedResult.Location = new System.Drawing.Point(146, 89);
            this.lblSearchedResult.Name = "lblSearchedResult";
            this.lblSearchedResult.Size = new System.Drawing.Size(13, 13);
            this.lblSearchedResult.TabIndex = 4;
            this.lblSearchedResult.Text = "0";
            // 
            // lblSearched
            // 
            this.lblSearched.AutoSize = true;
            this.lblSearched.Location = new System.Drawing.Point(26, 89);
            this.lblSearched.Name = "lblSearched";
            this.lblSearched.Size = new System.Drawing.Size(56, 13);
            this.lblSearched.TabIndex = 3;
            this.lblSearched.Text = "Searched:";
            // 
            // lblFoundResult
            // 
            this.lblFoundResult.AutoSize = true;
            this.lblFoundResult.Location = new System.Drawing.Point(146, 60);
            this.lblFoundResult.Name = "lblFoundResult";
            this.lblFoundResult.Size = new System.Drawing.Size(13, 13);
            this.lblFoundResult.TabIndex = 2;
            this.lblFoundResult.Text = "0";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(26, 60);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(40, 13);
            this.lblFound.TabIndex = 1;
            this.lblFound.Text = "Found:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(182, 15);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(74, 17);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Summary";
            // 
            // SearchTextOrFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 728);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchTextOrFile";
            this.Text = "SearchTextOrFile";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchIn;
        private System.Windows.Forms.TextBox txtContainingText;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblSearchIn;
        private System.Windows.Forms.Label lblContainingText;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblSearchedResult;
        private System.Windows.Forms.Label lblSearched;
        private System.Windows.Forms.Label lblFoundResult;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusResult;
    }
}

