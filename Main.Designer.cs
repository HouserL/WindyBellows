
namespace WindyBellows
{
    partial class Main
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
            this.btnPartyView = new System.Windows.Forms.Button();
            this.btnTableEditor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMonster = new System.Windows.Forms.Button();
            this.BtnPlayerView = new System.Windows.Forms.Button();
            this.btnSpellView = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNPC
            // 
            this.btnCreateNPC.Location = new System.Drawing.Point(26, 39);
            this.btnCreateNPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateNPC.Name = "btnCreateNPC";
            this.btnCreateNPC.Size = new System.Drawing.Size(83, 52);
            this.btnCreateNPC.TabIndex = 0;
            this.btnCreateNPC.Text = "NPCs Creator";
            this.btnCreateNPC.UseVisualStyleBackColor = true;
            this.btnCreateNPC.Click += new System.EventHandler(this.BtnCreateNPC_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 28);
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
            this.savePlayerBaseToolStripMenuItem.Click += new System.EventHandler(this.SavePlayerBaseToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Conversion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPartyView
            // 
            this.btnPartyView.Location = new System.Drawing.Point(26, 211);
            this.btnPartyView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartyView.Name = "btnPartyView";
            this.btnPartyView.Size = new System.Drawing.Size(83, 48);
            this.btnPartyView.TabIndex = 3;
            this.btnPartyView.Text = "Party Viewer";
            this.btnPartyView.UseVisualStyleBackColor = true;
            this.btnPartyView.Click += new System.EventHandler(this.BtnPartyView_Click);
            // 
            // btnTableEditor
            // 
            this.btnTableEditor.Location = new System.Drawing.Point(26, 99);
            this.btnTableEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTableEditor.Name = "btnTableEditor";
            this.btnTableEditor.Size = new System.Drawing.Size(83, 48);
            this.btnTableEditor.TabIndex = 4;
            this.btnTableEditor.Text = "Table Editor";
            this.btnTableEditor.UseVisualStyleBackColor = true;
            this.btnTableEditor.Click += new System.EventHandler(this.BtnTableEditor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 535);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save Current Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 570);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // btnMonster
            // 
            this.btnMonster.Location = new System.Drawing.Point(26, 155);
            this.btnMonster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMonster.Name = "btnMonster";
            this.btnMonster.Size = new System.Drawing.Size(83, 48);
            this.btnMonster.TabIndex = 8;
            this.btnMonster.Text = "Load Monster";
            this.btnMonster.UseVisualStyleBackColor = true;
            this.btnMonster.Click += new System.EventHandler(this.BtnMonster_Click);
            // 
            // BtnPlayerView
            // 
            this.BtnPlayerView.Location = new System.Drawing.Point(26, 370);
            this.BtnPlayerView.Name = "BtnPlayerView";
            this.BtnPlayerView.Size = new System.Drawing.Size(88, 29);
            this.BtnPlayerView.TabIndex = 9;
            this.BtnPlayerView.Text = "PlayerView";
            this.BtnPlayerView.UseVisualStyleBackColor = true;
            this.BtnPlayerView.Click += new System.EventHandler(this.BtnPlayerView_Click);
            // 
            // btnSpellView
            // 
            this.btnSpellView.Location = new System.Drawing.Point(26, 326);
            this.btnSpellView.Name = "btnSpellView";
            this.btnSpellView.Size = new System.Drawing.Size(88, 29);
            this.btnSpellView.TabIndex = 10;
            this.btnSpellView.Text = "SpellView";
            this.btnSpellView.UseVisualStyleBackColor = true;
            this.btnSpellView.Click += new System.EventHandler(this.btnSpellView_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 639);
            this.Controls.Add(this.btnSpellView);
            this.Controls.Add(this.BtnPlayerView);
            this.Controls.Add(this.btnMonster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTableEditor);
            this.Controls.Add(this.btnPartyView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateNPC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Compendium";
            this.Load += new System.EventHandler(this.FrmPlayerView_Load);
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
        private System.Windows.Forms.Button btnPartyView;
        private System.Windows.Forms.Button btnTableEditor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMonster;
        private System.Windows.Forms.Button BtnPlayerView;
        private System.Windows.Forms.Button btnSpellView;
    }
}

