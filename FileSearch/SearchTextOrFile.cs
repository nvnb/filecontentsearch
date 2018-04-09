using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class SearchTextOrFile : Form
    {
        private const string ValidateContainingText = "Please enter Containing Text";
        private const string ValidateSearchIn = "Please enter the directory or folder to search";
        private const string Processing = "Processing...";
        private const string Completed = "Completed!";
        public SearchTextOrFile()
        {
            InitializeComponent();
        }

        public int TotalCount { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchIn.Text))
            {
                MessageBox.Show(ValidateSearchIn);
                return;
            }

            lblStatusResult.Text = Processing;

            // Example list.
            List<string[]> results = new List<string[]>();

            List<string> allFiles = new List<string>();
            AddFileNamesToList(txtSearchIn.Text, allFiles);
            foreach (string filePath in allFiles)
            {
                var contents = File.ReadLines(filePath);
                foreach (var content in contents)
                {
                    if (!string.IsNullOrEmpty(txtContainingText.Text))
                    {
                        if (content.ToLower().Contains(txtContainingText.Text.ToLower()))
                        {
                            results.Add(new[] { content, filePath });
                        }
                    }
                    else
                    {
                        results.Add(new[] { txtFileName.Text, filePath });
                        break;
                    }
                }
            }

            DataTable table = ConvertListToDataTable(results);

            dgvResults.Dock = DockStyle.Fill;
            dgvResults.DataSource = table;
            dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            lblFoundResult.Text = table.Rows.Count.ToString();
            lblSearchedResult.Text = TotalCount.ToString();//allFiles.Count + @" files";
            lblStatusResult.Text = Completed;
        }

        private void AddFileNamesToList(string sourceDir, List<string> allFiles)
        {
            string[] fileEntries;
            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                fileEntries = Directory.GetFiles(sourceDir, txtFileName.Text, SearchOption.AllDirectories);
            }
            else
            {
                fileEntries = Directory.GetFiles(sourceDir);
            }

            TotalCount += fileEntries.Length;

            foreach (string fileName in fileEntries)
            {
                allFiles.Add(fileName);
            }

            //Recursion    
            string[] subdirectoryEntries = Directory.GetDirectories(sourceDir);
            foreach (string item in subdirectoryEntries)
            {
                // Avoid "reparse points"
                if ((File.GetAttributes(item) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                {
                    AddFileNamesToList(item, allFiles);
                }
            }

        }

        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            //Add Cloumns
            table.Columns.Add("Summary");
            table.Columns.Add("Location");

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSearchIn.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
