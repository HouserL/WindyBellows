
namespace WindyBellows
{
    partial class frmMonster
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
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.rtbAC = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbSize = new System.Windows.Forms.RichTextBox();
            this.rtbSpeed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbHP = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbName
            // 
            this.rtbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbName.Location = new System.Drawing.Point(16, 10);
            this.rtbName.Multiline = false;
            this.rtbName.Name = "rtbName";
            this.rtbName.ReadOnly = true;
            this.rtbName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbName.Size = new System.Drawing.Size(100, 20);
            this.rtbName.TabIndex = 2;
            this.rtbName.Text = "Hello";
            this.rtbName.WordWrap = false;
            this.rtbName.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RtbReSize);
            this.rtbName.GotFocus += new System.EventHandler(this.RtbGotFocus);
            // 
            // rtbAC
            // 
            this.rtbAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAC.Location = new System.Drawing.Point(121, 74);
            this.rtbAC.Multiline = false;
            this.rtbAC.Name = "rtbAC";
            this.rtbAC.ReadOnly = true;
            this.rtbAC.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbAC.Size = new System.Drawing.Size(66, 20);
            this.rtbAC.TabIndex = 4;
            this.rtbAC.Text = "Hello";
            this.rtbAC.WordWrap = false;
            this.rtbAC.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RtbReSize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Armor Class";
            // 
            // rtbSize
            // 
            this.rtbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSize.Location = new System.Drawing.Point(16, 36);
            this.rtbSize.Multiline = false;
            this.rtbSize.Name = "rtbSize";
            this.rtbSize.ReadOnly = true;
            this.rtbSize.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbSize.Size = new System.Drawing.Size(78, 21);
            this.rtbSize.TabIndex = 5;
            this.rtbSize.Text = "Hello";
            this.rtbSize.WordWrap = false;
            this.rtbSize.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RtbReSize);
            // 
            // rtbSpeed
            // 
            this.rtbSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSpeed.Location = new System.Drawing.Point(74, 114);
            this.rtbSpeed.Multiline = false;
            this.rtbSpeed.Name = "rtbSpeed";
            this.rtbSpeed.ReadOnly = true;
            this.rtbSpeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbSpeed.Size = new System.Drawing.Size(67, 20);
            this.rtbSpeed.TabIndex = 7;
            this.rtbSpeed.Text = "Hello";
            this.rtbSpeed.WordWrap = false;
            this.rtbSpeed.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RtbReSize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Speed";
            // 
            // rtbHP
            // 
            this.rtbHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHP.Location = new System.Drawing.Point(101, 94);
            this.rtbHP.Multiline = false;
            this.rtbHP.Name = "rtbHP";
            this.rtbHP.ReadOnly = true;
            this.rtbHP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbHP.Size = new System.Drawing.Size(58, 20);
            this.rtbHP.TabIndex = 9;
            this.rtbHP.Text = "Hello";
            this.rtbHP.WordWrap = false;
            this.rtbHP.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RtbReSize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hit Points";
            // 
            // frmMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 509);
            this.Controls.Add(this.rtbHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSize);
            this.Controls.Add(this.rtbAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbName);
            this.Name = "frmMonster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMonster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.RichTextBox rtbAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbSize;
        private System.Windows.Forms.RichTextBox rtbSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbHP;
        private System.Windows.Forms.Label label3;
    }
}