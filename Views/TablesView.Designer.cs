namespace WindyBellows.Views
{
    partial class TablesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListBoxTables = new System.Windows.Forms.ListBox();
            this.AddNewTable = new System.Windows.Forms.Button();
            this.SaveTable = new System.Windows.Forms.Button();
            this.RemoveTable = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.RemoveRow = new System.Windows.Forms.Button();
            this.TestTable = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.EditName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RichTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.TextBoxTestNumber = new System.Windows.Forms.TextBox();
            this.TextBoxTableName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(14, 69);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 29;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.Size = new System.Drawing.Size(422, 589);
            this.DataGridView1.TabIndex = 0;
            // 
            // ListBoxTables
            // 
            this.ListBoxTables.FormattingEnabled = true;
            this.ListBoxTables.ItemHeight = 20;
            this.ListBoxTables.Location = new System.Drawing.Point(454, 69);
            this.ListBoxTables.Name = "ListBoxTables";
            this.ListBoxTables.Size = new System.Drawing.Size(324, 104);
            this.ListBoxTables.TabIndex = 1;
            this.ListBoxTables.SelectedIndexChanged += new System.EventHandler(this.ListBoxTables_SelectedIndexChanged);
            // 
            // AddNewTable
            // 
            this.AddNewTable.Location = new System.Drawing.Point(454, 194);
            this.AddNewTable.Name = "AddNewTable";
            this.AddNewTable.Size = new System.Drawing.Size(94, 73);
            this.AddNewTable.TabIndex = 2;
            this.AddNewTable.Text = "Add New Table";
            this.AddNewTable.UseVisualStyleBackColor = true;
            this.AddNewTable.Click += new System.EventHandler(this.AddNewTable_Click);
            // 
            // SaveTable
            // 
            this.SaveTable.Location = new System.Drawing.Point(562, 194);
            this.SaveTable.Name = "SaveTable";
            this.SaveTable.Size = new System.Drawing.Size(94, 73);
            this.SaveTable.TabIndex = 3;
            this.SaveTable.Text = "Save Table";
            this.SaveTable.UseVisualStyleBackColor = true;
            this.SaveTable.Click += new System.EventHandler(this.SaveTable_Click);
            // 
            // RemoveTable
            // 
            this.RemoveTable.Location = new System.Drawing.Point(684, 194);
            this.RemoveTable.Name = "RemoveTable";
            this.RemoveTable.Size = new System.Drawing.Size(94, 73);
            this.RemoveTable.TabIndex = 4;
            this.RemoveTable.Text = "Remove Selected Table";
            this.RemoveTable.UseVisualStyleBackColor = true;
            this.RemoveTable.Click += new System.EventHandler(this.RemoveTable_Click);
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(454, 273);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(94, 73);
            this.AddRow.TabIndex = 5;
            this.AddRow.Text = "Add Row";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // RemoveRow
            // 
            this.RemoveRow.Location = new System.Drawing.Point(562, 273);
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.Size = new System.Drawing.Size(94, 73);
            this.RemoveRow.TabIndex = 6;
            this.RemoveRow.Text = "Remove Selected Row";
            this.RemoveRow.UseVisualStyleBackColor = true;
            this.RemoveRow.Click += new System.EventHandler(this.RemoveRow_Click);
            // 
            // TestTable
            // 
            this.TestTable.Location = new System.Drawing.Point(684, 273);
            this.TestTable.Name = "TestTable";
            this.TestTable.Size = new System.Drawing.Size(94, 73);
            this.TestTable.TabIndex = 7;
            this.TestTable.Text = "Test Table";
            this.TestTable.UseVisualStyleBackColor = true;
            this.TestTable.Click += new System.EventHandler(this.TestTable_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(562, 34);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(105, 29);
            this.MoveUp.TabIndex = 8;
            this.MoveUp.Text = "Move UP";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(674, 34);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(105, 29);
            this.MoveDown.TabIndex = 9;
            this.MoveDown.Text = "Move Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // EditName
            // 
            this.EditName.AutoSize = true;
            this.EditName.Location = new System.Drawing.Point(442, 11);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(140, 24);
            this.EditName.TabIndex = 10;
            this.EditName.Text = "Edit Table Name";
            this.EditName.UseVisualStyleBackColor = true;
            this.EditName.CheckedChanged += new System.EventHandler(this.EditName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Tests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // RichTextBoxResults
            // 
            this.RichTextBoxResults.Location = new System.Drawing.Point(454, 468);
            this.RichTextBoxResults.Name = "RichTextBoxResults";
            this.RichTextBoxResults.Size = new System.Drawing.Size(324, 190);
            this.RichTextBoxResults.TabIndex = 13;
            this.RichTextBoxResults.Text = "";
            this.RichTextBoxResults.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RichTextBoxResults_ContentsResized);
            // 
            // TextBoxTestNumber
            // 
            this.TextBoxTestNumber.Location = new System.Drawing.Point(653, 412);
            this.TextBoxTestNumber.Name = "TextBoxTestNumber";
            this.TextBoxTestNumber.Size = new System.Drawing.Size(117, 27);
            this.TextBoxTestNumber.TabIndex = 14;
            this.TextBoxTestNumber.Leave += new System.EventHandler(this.TextBoxTestNumber_Leave);
            // 
            // TextBoxTableName
            // 
            this.TextBoxTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTableName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxTableName.Location = new System.Drawing.Point(14, 18);
            this.TextBoxTableName.Name = "TextBoxTableName";
            this.TextBoxTableName.ReadOnly = true;
            this.TextBoxTableName.Size = new System.Drawing.Size(422, 45);
            this.TextBoxTableName.TabIndex = 15;
            this.TextBoxTableName.Text = "Table Name";
            this.TextBoxTableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TablesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxTableName);
            this.Controls.Add(this.TextBoxTestNumber);
            this.Controls.Add(this.RichTextBoxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.TestTable);
            this.Controls.Add(this.RemoveRow);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.RemoveTable);
            this.Controls.Add(this.SaveTable);
            this.Controls.Add(this.AddNewTable);
            this.Controls.Add(this.ListBoxTables);
            this.Controls.Add(this.DataGridView1);
            this.Name = "TablesView";
            this.Size = new System.Drawing.Size(796, 673);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ListBox ListBoxTables;
        private System.Windows.Forms.Button AddNewTable;
        private System.Windows.Forms.Button SaveTable;
        private System.Windows.Forms.Button RemoveTable;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button RemoveRow;
        private System.Windows.Forms.Button TestTable;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.CheckBox EditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RichTextBoxResults;
        private System.Windows.Forms.TextBox TextBoxTestNumber;
        private System.Windows.Forms.TextBox TextBoxTableName;
    }
}
