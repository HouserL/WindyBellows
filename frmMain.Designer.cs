
namespace WindyBellows
{
    partial class frmMain
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
            this.btnCreateNPC = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlayerBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlayerView = new System.Windows.Forms.Button();
            this.btnTableEditor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMonster = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNPC
            // 
            this.btnCreateNPC.Location = new System.Drawing.Point(26, 31);
            this.btnCreateNPC.Name = "btnCreateNPC";
            this.btnCreateNPC.Size = new System.Drawing.Size(70, 59);
            this.btnCreateNPC.TabIndex = 0;
            this.btnCreateNPC.Text = "NPCs Creator";
            this.btnCreateNPC.UseVisualStyleBackColor = true;
            this.btnCreateNPC.Click += new System.EventHandler(this.btnCreateNPC_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePlayerBaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePlayerBaseToolStripMenuItem
            // 
            this.savePlayerBaseToolStripMenuItem.Name = "savePlayerBaseToolStripMenuItem";
            this.savePlayerBaseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.savePlayerBaseToolStripMenuItem.Text = "Save All Data";
            this.savePlayerBaseToolStripMenuItem.Click += new System.EventHandler(this.savePlayerBaseToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 132);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Conversion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayerView
            // 
            this.btnPlayerView.Location = new System.Drawing.Point(125, 31);
            this.btnPlayerView.Name = "btnPlayerView";
            this.btnPlayerView.Size = new System.Drawing.Size(70, 59);
            this.btnPlayerView.TabIndex = 3;
            this.btnPlayerView.Text = "Party Viewer";
            this.btnPlayerView.UseVisualStyleBackColor = true;
            this.btnPlayerView.Click += new System.EventHandler(this.btnPlayerView_Click);
            // 
            // btnTableEditor
            // 
            this.btnTableEditor.Location = new System.Drawing.Point(26, 111);
            this.btnTableEditor.Name = "btnTableEditor";
            this.btnTableEditor.Size = new System.Drawing.Size(70, 59);
            this.btnTableEditor.TabIndex = 4;
            this.btnTableEditor.Text = "Table Editor";
            this.btnTableEditor.UseVisualStyleBackColor = true;
            this.btnTableEditor.Click += new System.EventHandler(this.btnTableEditor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // btnMonster
            // 
            this.btnMonster.Location = new System.Drawing.Point(26, 189);
            this.btnMonster.Name = "btnMonster";
            this.btnMonster.Size = new System.Drawing.Size(75, 60);
            this.btnMonster.TabIndex = 8;
            this.btnMonster.Text = "Load Monster";
            this.btnMonster.UseVisualStyleBackColor = true;
            this.btnMonster.Click += new System.EventHandler(this.btnMonster_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 337);
            this.Controls.Add(this.btnMonster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTableEditor);
            this.Controls.Add(this.btnPlayerView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateNPC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Compendium";
            this.Load += new System.EventHandler(this.frmPlayerView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNPC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlayerBaseToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlayerView;
        private System.Windows.Forms.Button btnTableEditor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMonster;
    }
}

