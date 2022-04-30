namespace WindyBellows.Views
{
    partial class SpellView
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
            this.components = new System.ComponentModel.Container();
            this.cboSpellLevel = new System.Windows.Forms.ComboBox();
            this.cbVerbal = new System.Windows.Forms.CheckBox();
            this.cbSomantic = new System.Windows.Forms.CheckBox();
            this.cbMaterialistic = new System.Windows.Forms.CheckBox();
            this.spellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSpellType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spellBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSpellLevel
            // 
            this.cboSpellLevel.FormattingEnabled = true;
            this.cboSpellLevel.Location = new System.Drawing.Point(217, 46);
            this.cboSpellLevel.Name = "cboSpellLevel";
            this.cboSpellLevel.Size = new System.Drawing.Size(151, 28);
            this.cboSpellLevel.TabIndex = 0;
            // 
            // cbVerbal
            // 
            this.cbVerbal.AutoSize = true;
            this.cbVerbal.Location = new System.Drawing.Point(65, 110);
            this.cbVerbal.Name = "cbVerbal";
            this.cbVerbal.Size = new System.Drawing.Size(40, 24);
            this.cbVerbal.TabIndex = 2;
            this.cbVerbal.Text = "V";
            this.cbVerbal.UseVisualStyleBackColor = true;
            // 
            // cbSomantic
            // 
            this.cbSomantic.AutoSize = true;
            this.cbSomantic.Location = new System.Drawing.Point(111, 110);
            this.cbSomantic.Name = "cbSomantic";
            this.cbSomantic.Size = new System.Drawing.Size(39, 24);
            this.cbSomantic.TabIndex = 3;
            this.cbSomantic.Text = "S";
            this.cbSomantic.UseVisualStyleBackColor = true;
            // 
            // cbMaterialistic
            // 
            this.cbMaterialistic.AutoSize = true;
            this.cbMaterialistic.Location = new System.Drawing.Point(156, 110);
            this.cbMaterialistic.Name = "cbMaterialistic";
            this.cbMaterialistic.Size = new System.Drawing.Size(44, 24);
            this.cbMaterialistic.TabIndex = 4;
            this.cbMaterialistic.Text = "M";
            this.cbMaterialistic.UseVisualStyleBackColor = true;
            // 
            // spellBindingSource
            // 
            this.spellBindingSource.DataSource = typeof(WindyBellows.Models.Spell);
            // 
            // cboSpellType
            // 
            this.cboSpellType.FormattingEnabled = true;
            this.cboSpellType.Location = new System.Drawing.Point(49, 46);
            this.cboSpellType.Name = "cboSpellType";
            this.cboSpellType.Size = new System.Drawing.Size(151, 28);
            this.cboSpellType.TabIndex = 5;
            // 
            // SpellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboSpellType);
            this.Controls.Add(this.cbMaterialistic);
            this.Controls.Add(this.cbSomantic);
            this.Controls.Add(this.cbVerbal);
            this.Controls.Add(this.cboSpellLevel);
            this.Name = "SpellView";
            this.Size = new System.Drawing.Size(422, 453);
            this.Load += new System.EventHandler(this.SpellView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spellBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSpellLevel;
        private System.Windows.Forms.CheckBox cbVerbal;
        private System.Windows.Forms.CheckBox cbSomantic;
        private System.Windows.Forms.CheckBox cbMaterialistic;
        private System.Windows.Forms.BindingSource spellBindingSource;
        private System.Windows.Forms.ComboBox cboSpellType;
    }
}
