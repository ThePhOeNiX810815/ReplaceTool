namespace ReplaceTool
{
    partial class ReplaceToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceToolForm));
            this.variablesListGridView = new System.Windows.Forms.DataGridView();
            this.col_Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_VarValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Occurrences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_LoadTargetFile = new System.Windows.Forms.Button();
            this.btn_LoadVarListFile = new System.Windows.Forms.Button();
            this.lbl_LoadTargetFile = new System.Windows.Forms.Label();
            this.lbl_LoadVarListFile = new System.Windows.Forms.Label();
            this.openFileDialog_TargetFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_CheckTarget = new System.Windows.Forms.Button();
            this.openFileDialog_VariablesList = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.variablesListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // variablesListGridView
            // 
            this.variablesListGridView.AllowUserToOrderColumns = true;
            this.variablesListGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.variablesListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variablesListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Enabled,
            this.col_VarName,
            this.col_VarValue,
            this.col_Occurrences});
            this.variablesListGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variablesListGridView.Location = new System.Drawing.Point(12, 93);
            this.variablesListGridView.Name = "variablesListGridView";
            this.variablesListGridView.Size = new System.Drawing.Size(797, 319);
            this.variablesListGridView.TabIndex = 0;
            this.variablesListGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.variablesListGridView_CellValueChanged);
            // 
            // col_Enabled
            // 
            this.col_Enabled.FalseValue = "0";
            this.col_Enabled.HeaderText = "Enabled";
            this.col_Enabled.MinimumWidth = 50;
            this.col_Enabled.Name = "col_Enabled";
            this.col_Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Enabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Enabled.TrueValue = "1";
            this.col_Enabled.Width = 50;
            // 
            // col_VarName
            // 
            this.col_VarName.HeaderText = "Variable Name";
            this.col_VarName.MinimumWidth = 300;
            this.col_VarName.Name = "col_VarName";
            this.col_VarName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_VarName.Width = 300;
            // 
            // col_VarValue
            // 
            this.col_VarValue.HeaderText = "Variable Value";
            this.col_VarValue.MinimumWidth = 300;
            this.col_VarValue.Name = "col_VarValue";
            this.col_VarValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_VarValue.Width = 300;
            // 
            // col_Occurrences
            // 
            this.col_Occurrences.HeaderText = "Occurrences";
            this.col_Occurrences.MinimumWidth = 75;
            this.col_Occurrences.Name = "col_Occurrences";
            this.col_Occurrences.ReadOnly = true;
            this.col_Occurrences.Width = 75;
            // 
            // btn_Replace
            // 
            this.btn_Replace.BackColor = System.Drawing.Color.Gray;
            this.btn_Replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Replace.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Replace.Location = new System.Drawing.Point(347, 421);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(127, 30);
            this.btn_Replace.TabIndex = 1;
            this.btn_Replace.Text = "Replace Variables";
            this.btn_Replace.UseVisualStyleBackColor = false;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gray;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Close.Location = new System.Drawing.Point(682, 421);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(127, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_LoadTargetFile
            // 
            this.btn_LoadTargetFile.BackColor = System.Drawing.Color.Gray;
            this.btn_LoadTargetFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadTargetFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTargetFile.ForeColor = System.Drawing.Color.Yellow;
            this.btn_LoadTargetFile.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadTargetFile.Name = "btn_LoadTargetFile";
            this.btn_LoadTargetFile.Size = new System.Drawing.Size(127, 30);
            this.btn_LoadTargetFile.TabIndex = 3;
            this.btn_LoadTargetFile.Text = "Load Target File";
            this.btn_LoadTargetFile.UseVisualStyleBackColor = false;
            this.btn_LoadTargetFile.Click += new System.EventHandler(this.btn_LoadTargetFile_Click);
            // 
            // btn_LoadVarListFile
            // 
            this.btn_LoadVarListFile.BackColor = System.Drawing.Color.Gray;
            this.btn_LoadVarListFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadVarListFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadVarListFile.ForeColor = System.Drawing.Color.Yellow;
            this.btn_LoadVarListFile.Location = new System.Drawing.Point(12, 48);
            this.btn_LoadVarListFile.Name = "btn_LoadVarListFile";
            this.btn_LoadVarListFile.Size = new System.Drawing.Size(127, 30);
            this.btn_LoadVarListFile.TabIndex = 4;
            this.btn_LoadVarListFile.Text = "Load Variables List";
            this.btn_LoadVarListFile.UseVisualStyleBackColor = false;
            this.btn_LoadVarListFile.Click += new System.EventHandler(this.btn_LoadVarListFile_Click);
            // 
            // lbl_LoadTargetFile
            // 
            this.lbl_LoadTargetFile.BackColor = System.Drawing.Color.Gray;
            this.lbl_LoadTargetFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoadTargetFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_LoadTargetFile.ForeColor = System.Drawing.Color.Lime;
            this.lbl_LoadTargetFile.Location = new System.Drawing.Point(145, 13);
            this.lbl_LoadTargetFile.Name = "lbl_LoadTargetFile";
            this.lbl_LoadTargetFile.Size = new System.Drawing.Size(664, 27);
            this.lbl_LoadTargetFile.TabIndex = 5;
            this.lbl_LoadTargetFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LoadVarListFile
            // 
            this.lbl_LoadVarListFile.BackColor = System.Drawing.Color.Gray;
            this.lbl_LoadVarListFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoadVarListFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_LoadVarListFile.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_LoadVarListFile.Location = new System.Drawing.Point(145, 49);
            this.lbl_LoadVarListFile.Name = "lbl_LoadVarListFile";
            this.lbl_LoadVarListFile.Size = new System.Drawing.Size(664, 27);
            this.lbl_LoadVarListFile.TabIndex = 6;
            this.lbl_LoadVarListFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_TargetFile
            // 
            this.openFileDialog_TargetFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_TargetFile_FileOk);
            // 
            // btn_CheckTarget
            // 
            this.btn_CheckTarget.BackColor = System.Drawing.Color.Gray;
            this.btn_CheckTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckTarget.Enabled = false;
            this.btn_CheckTarget.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckTarget.ForeColor = System.Drawing.Color.Yellow;
            this.btn_CheckTarget.Location = new System.Drawing.Point(12, 421);
            this.btn_CheckTarget.Name = "btn_CheckTarget";
            this.btn_CheckTarget.Size = new System.Drawing.Size(127, 30);
            this.btn_CheckTarget.TabIndex = 7;
            this.btn_CheckTarget.Text = "Check Target";
            this.btn_CheckTarget.UseVisualStyleBackColor = false;
            this.btn_CheckTarget.Click += new System.EventHandler(this.btn_CheckTarget_Click);
            // 
            // openFileDialog_VariablesList
            // 
            this.openFileDialog_VariablesList.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_VariablesList_FileOk);
            // 
            // ReplaceToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(824, 456);
            this.Controls.Add(this.btn_CheckTarget);
            this.Controls.Add(this.lbl_LoadVarListFile);
            this.Controls.Add(this.lbl_LoadTargetFile);
            this.Controls.Add(this.btn_LoadVarListFile);
            this.Controls.Add(this.btn_LoadTargetFile);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.variablesListGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReplaceToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace Tool";
            ((System.ComponentModel.ISupportInitialize)(this.variablesListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView variablesListGridView;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_LoadTargetFile;
        private System.Windows.Forms.Button btn_LoadVarListFile;
        private System.Windows.Forms.Label lbl_LoadTargetFile;
        private System.Windows.Forms.Label lbl_LoadVarListFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_TargetFile;
        private System.Windows.Forms.Button btn_CheckTarget;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_VarValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Occurrences;
        private System.Windows.Forms.OpenFileDialog openFileDialog_VariablesList;
    }
}

