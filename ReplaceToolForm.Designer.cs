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
            this.btn_SelectSourceFile = new System.Windows.Forms.Button();
            this.btn_LoadVarListFile = new System.Windows.Forms.Button();
            this.lbl_SourceFile = new System.Windows.Forms.Label();
            this.lbl_LoadVarListFile = new System.Windows.Forms.Label();
            this.openFileDialog_TargetFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_CheckTarget = new System.Windows.Forms.Button();
            this.openFileDialog_VariablesList = new System.Windows.Forms.OpenFileDialog();
            this.lbl_TargetFile = new System.Windows.Forms.Label();
            this.btn_SelectTargetFile = new System.Windows.Forms.Button();
            this.lbl_VariablesList = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
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
            this.variablesListGridView.Location = new System.Drawing.Point(12, 182);
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
            this.btn_Replace.BackColor = System.Drawing.Color.DimGray;
            this.btn_Replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Replace.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Replace.Location = new System.Drawing.Point(682, 507);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(127, 30);
            this.btn_Replace.TabIndex = 1;
            this.btn_Replace.Text = "Replace Variables";
            this.btn_Replace.UseVisualStyleBackColor = false;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_SelectSourceFile
            // 
            this.btn_SelectSourceFile.BackColor = System.Drawing.Color.DimGray;
            this.btn_SelectSourceFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSourceFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectSourceFile.ForeColor = System.Drawing.Color.LawnGreen;
            this.btn_SelectSourceFile.Location = new System.Drawing.Point(13, 12);
            this.btn_SelectSourceFile.Name = "btn_SelectSourceFile";
            this.btn_SelectSourceFile.Size = new System.Drawing.Size(127, 30);
            this.btn_SelectSourceFile.TabIndex = 3;
            this.btn_SelectSourceFile.Text = "Select Source File";
            this.btn_SelectSourceFile.UseVisualStyleBackColor = false;
            this.btn_SelectSourceFile.Click += new System.EventHandler(this.btn_SelectSourceFile_Click);
            // 
            // btn_LoadVarListFile
            // 
            this.btn_LoadVarListFile.BackColor = System.Drawing.Color.DimGray;
            this.btn_LoadVarListFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadVarListFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadVarListFile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_LoadVarListFile.Location = new System.Drawing.Point(13, 88);
            this.btn_LoadVarListFile.Name = "btn_LoadVarListFile";
            this.btn_LoadVarListFile.Size = new System.Drawing.Size(127, 30);
            this.btn_LoadVarListFile.TabIndex = 4;
            this.btn_LoadVarListFile.Text = "Load Variables List";
            this.btn_LoadVarListFile.UseVisualStyleBackColor = false;
            this.btn_LoadVarListFile.Click += new System.EventHandler(this.btn_LoadVarListFile_Click);
            // 
            // lbl_SourceFile
            // 
            this.lbl_SourceFile.BackColor = System.Drawing.Color.DimGray;
            this.lbl_SourceFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SourceFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_SourceFile.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_SourceFile.Location = new System.Drawing.Point(146, 13);
            this.lbl_SourceFile.Name = "lbl_SourceFile";
            this.lbl_SourceFile.Size = new System.Drawing.Size(664, 27);
            this.lbl_SourceFile.TabIndex = 5;
            this.lbl_SourceFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LoadVarListFile
            // 
            this.lbl_LoadVarListFile.BackColor = System.Drawing.Color.DimGray;
            this.lbl_LoadVarListFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoadVarListFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_LoadVarListFile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_LoadVarListFile.Location = new System.Drawing.Point(146, 89);
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
            this.btn_CheckTarget.BackColor = System.Drawing.Color.DimGray;
            this.btn_CheckTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckTarget.Enabled = false;
            this.btn_CheckTarget.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckTarget.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_CheckTarget.Location = new System.Drawing.Point(12, 507);
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
            // lbl_TargetFile
            // 
            this.lbl_TargetFile.BackColor = System.Drawing.Color.DimGray;
            this.lbl_TargetFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TargetFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TargetFile.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_TargetFile.Location = new System.Drawing.Point(146, 51);
            this.lbl_TargetFile.Name = "lbl_TargetFile";
            this.lbl_TargetFile.Size = new System.Drawing.Size(664, 27);
            this.lbl_TargetFile.TabIndex = 9;
            this.lbl_TargetFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SelectTargetFile
            // 
            this.btn_SelectTargetFile.BackColor = System.Drawing.Color.DimGray;
            this.btn_SelectTargetFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectTargetFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectTargetFile.ForeColor = System.Drawing.Color.DeepPink;
            this.btn_SelectTargetFile.Location = new System.Drawing.Point(13, 50);
            this.btn_SelectTargetFile.Name = "btn_SelectTargetFile";
            this.btn_SelectTargetFile.Size = new System.Drawing.Size(127, 30);
            this.btn_SelectTargetFile.TabIndex = 8;
            this.btn_SelectTargetFile.Text = "Load Target File";
            this.btn_SelectTargetFile.UseVisualStyleBackColor = false;
            this.btn_SelectTargetFile.Click += new System.EventHandler(this.btn_SelectTargetFile_Click);
            // 
            // lbl_VariablesList
            // 
            this.lbl_VariablesList.BackColor = System.Drawing.Color.DimGray;
            this.lbl_VariablesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_VariablesList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_VariablesList.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_VariablesList.Location = new System.Drawing.Point(12, 155);
            this.lbl_VariablesList.Name = "lbl_VariablesList";
            this.lbl_VariablesList.Size = new System.Drawing.Size(797, 27);
            this.lbl_VariablesList.TabIndex = 10;
            this.lbl_VariablesList.Text = "Variable Replace List";
            this.lbl_VariablesList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Version
            // 
            this.lbl_Version.BackColor = System.Drawing.Color.DimGray;
            this.lbl_Version.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Version.ForeColor = System.Drawing.Color.White;
            this.lbl_Version.Location = new System.Drawing.Point(12, 546);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(798, 27);
            this.lbl_Version.TabIndex = 11;
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReplaceToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(824, 578);
            this.Controls.Add(this.variablesListGridView);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_VariablesList);
            this.Controls.Add(this.lbl_TargetFile);
            this.Controls.Add(this.btn_SelectTargetFile);
            this.Controls.Add(this.btn_CheckTarget);
            this.Controls.Add(this.lbl_LoadVarListFile);
            this.Controls.Add(this.lbl_SourceFile);
            this.Controls.Add(this.btn_LoadVarListFile);
            this.Controls.Add(this.btn_SelectSourceFile);
            this.Controls.Add(this.btn_Replace);
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

        public System.Windows.Forms.Label lbl_TargetFile;
        public System.Windows.Forms.Button btn_SelectTargetFile;
        public System.Windows.Forms.Label lbl_VariablesList;
        public System.Windows.Forms.DataGridView variablesListGridView;
        public System.Windows.Forms.Button btn_Replace;
        public System.Windows.Forms.Button btn_SelectSourceFile;
        public System.Windows.Forms.Button btn_LoadVarListFile;
        public System.Windows.Forms.Label lbl_SourceFile;
        public System.Windows.Forms.Label lbl_LoadVarListFile;
        public System.Windows.Forms.OpenFileDialog openFileDialog_TargetFile;
        public System.Windows.Forms.Button btn_CheckTarget;
        public System.Windows.Forms.DataGridViewCheckBoxColumn col_Enabled;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_VarName;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_VarValue;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_Occurrences;
        public System.Windows.Forms.OpenFileDialog openFileDialog_VariablesList;
        public System.Windows.Forms.Label lbl_Version;
    }
}

