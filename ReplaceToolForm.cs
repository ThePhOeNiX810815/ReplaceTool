using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReplaceTool
{
    public partial class ReplaceToolForm : Form
    {
        public static int maxFileSize = 5000000;
        public static string targetFileString = string.Empty;
        public static List<VariableReplaceItem> variablesReplaceList = new List<VariableReplaceItem>();

        public ReplaceToolForm()
        {
            InitializeComponent();

            lbl_Version.Text =
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductName +
                " - Version " +
                GetVersionString(Assembly.GetExecutingAssembly().GetName().Version, true, false) +
                " - " +
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalCopyright;
        }

        public void openFileDialog_TargetFile_FileOk(object sender, CancelEventArgs e)
        {
            // GET TARGET FILE INFO
            FileInfo targetFile = new FileInfo(openFileDialog_TargetFile.FileName);

            // CHECK FILE SIZE
            if (targetFile.Length <= maxFileSize)
            {
                // SET TARGET FILENAME AND PATH LABEL
                lbl_SourceFile.Text = targetFile.FullName;

                // CHECK VARIABLES
                btn_CheckTarget_Click(this, null);
            }
            else
            {
                MessageBox.Show(
                    "Target file is too big ->> " + targetFile.Length + " bytes" +
                    Environment.NewLine + Environment.NewLine +
                    "File could not be processed.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btn_SelectSourceFile_Click(object sender, EventArgs e)
        {
            openFileDialog_TargetFile.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog_TargetFile.ShowDialog();
        }

        public void btn_CheckTarget_Click(object sender, EventArgs e)
        {
            // CHECK TARGET FILE EXISTENCE
            if (File.Exists(lbl_SourceFile.Text))
            {
                btn_CheckTarget.Enabled = true;

                bool toBeUpdated = false;

                // READ TARGET FILE CONTENT TO WORKING VARIABLE
                targetFileString = File.ReadAllText(lbl_SourceFile.Text);

                // CLEAR WORKING LIST OF REPLACE VARIABLES
                variablesReplaceList.Clear();

                // ITERATE GRIDVIEW AND GET ITEMS
                foreach (DataGridViewRow variablesListGridItem in variablesListGridView.Rows)
                {
                    if (!string.IsNullOrEmpty(variablesListGridItem.Cells["col_VarName"].FormattedValue.ToString()) &&
                        !string.IsNullOrEmpty(variablesListGridItem.Cells["col_VarValue"].FormattedValue.ToString()))
                    {
                        string regExPattern = 
                            variablesListGridItem.
                                Cells["col_VarName"].
                                    FormattedValue.
                                        ToString().
                                            Replace("^", @"\^").
                                            Replace("$", @"\$").
                                            Replace(".", @"\.").
                                            Replace("|", @"\|").
                                            Replace("?", @"\?").
                                            Replace("*", @"\*").
                                            Replace("+", @"\+").
                                            Replace("(", @"\(").Replace(")", @"\)").
                                            Replace("[", @"\[").Replace("]", @"\]").
                                            Replace("{", @"\{").
                                            Replace("}", @"\}");

                        // GET VARIABLE REPLACE ITEM
                        VariableReplaceItem variablesReplaceItem = new VariableReplaceItem
                        { Enabled = (bool)variablesListGridItem.Cells["col_Enabled"].FormattedValue,
                          VarName = variablesListGridItem.Cells["col_VarName"].FormattedValue.ToString(),
                          VarValue = variablesListGridItem.Cells["col_VarValue"].FormattedValue.ToString(),
                          Occurrences = Regex.Matches(targetFileString, regExPattern).Count };

                        // ADD VARIABLE REPLACE ITEM TO WORKING LIST
                        variablesReplaceList.Add(variablesReplaceItem);

                        // ADD VARIABLE OCCURRENCES COUNT TO GRID
                        variablesListGridView.Rows[variablesListGridItem.Index].Cells["col_Occurrences"].Value = variablesReplaceItem.Occurrences;
                        variablesListGridView.Refresh();
                        
                        if (variablesReplaceItem.Enabled &&
                            variablesReplaceItem.Occurrences > 0)
                        {
                            toBeUpdated = true;
                        }
                    }
                }

                // ENABLE REPLACE BUTTON, IF AT LEAST ONE POSSIBLE ENABLED VARIABLE IS ON THE LIST
                btn_Replace.Enabled = toBeUpdated;
            }
            else
            {
                MessageBox.Show(
                    "Selected target file not found ->> " + lbl_SourceFile.Text +
                    Environment.NewLine + Environment.NewLine +
                    "You must browse existing file.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_SourceFile.Text = string.Empty;
                btn_CheckTarget.Enabled = false;
            }
        }

        public void variablesListGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // IF VARIABLE NAME OR VALUE IS CLEARED, CLEAR OCCURRENCES CELL VALUE
            if (e.RowIndex >= 0 &&
                (string.IsNullOrEmpty(variablesListGridView.Rows[e.RowIndex].Cells["col_VarName"].FormattedValue.ToString()) ||
                 string.IsNullOrEmpty(variablesListGridView.Rows[e.RowIndex].Cells["col_VarValue"].FormattedValue.ToString())))
            {
                variablesListGridView.Rows[e.RowIndex].Cells["col_Enabled"].Value = "0";
                variablesListGridView.Rows[e.RowIndex].Cells["col_Occurrences"].Value = string.Empty;
                variablesListGridView.Refresh();
            }
        }

        public void btn_Replace_Click(object sender, EventArgs e)
        {
            foreach (VariableReplaceItem replaceItem in variablesReplaceList)
            {
                if (replaceItem.Enabled)
                {
                    targetFileString = targetFileString.Replace(replaceItem.VarName, replaceItem.VarValue);
                }
            }

            File.WriteAllText(lbl_SourceFile.Text, targetFileString);

            MessageBox.Show(
                    "Updated file has been saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void openFileDialog_VariablesList_FileOk(object sender, CancelEventArgs e)
        {
            lbl_LoadVarListFile.Text = openFileDialog_VariablesList.FileName;

            variablesListGridView.Rows.Clear();

            List<string>variablesListFileLines = File.ReadLines(openFileDialog_VariablesList.FileName).ToList();

            foreach (var variablesListFileLine in variablesListFileLines)
            {
                string[] lineValues = variablesListFileLine.Split(';');

                if (lineValues.Length == 3 &&
                    !string.IsNullOrEmpty(lineValues[1]))
                {
                    DataGridViewRow newRow = (DataGridViewRow)variablesListGridView.Rows[0].Clone();

                    if (lineValues[0] == "1")
                    {
                        newRow.Cells[0].Value = "1";
                    }

                    newRow.Cells[1].Value = lineValues[1];
                    newRow.Cells[2].Value = lineValues[2];
                    newRow.Cells[3].Value = string.Empty;
                    variablesListGridView.Rows.Add(newRow);
                }
            }

            variablesListGridView.Update();

            btn_CheckTarget_Click(this, null);
        }

        public void btn_LoadVarListFile_Click(object sender, EventArgs e)
        {
            openFileDialog_VariablesList.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog_VariablesList.ShowDialog();
        }

        public void btn_SelectTargetFile_Click(object sender, EventArgs e)
        {

        }

        public static string GetVersionString(Version version, bool addBuildNumber, bool addRevisionNumber)
        {
            string versionString = version.Major.ToString() +
                                   "." +
                                   version.Minor.ToString();

            if (addBuildNumber)
            {
                versionString += "." + version.Build.ToString();

                if (addRevisionNumber)
                {
                    versionString += "." + version.Revision.ToString();
                }
            }

            return versionString;
        }
    }
    public class VariableReplaceItem
    {
        public bool Enabled { get; set; }
        public string VarName { get; set; }
        public string VarValue { get; set; }
        public int Occurrences { get; set; }
    }
}
