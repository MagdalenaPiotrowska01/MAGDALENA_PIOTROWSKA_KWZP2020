namespace KWZP_2020
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.chkButtonEnabled = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtButtonChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(45, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(232, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Nazwa nie ma znaczenia";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkButtonEnabled
            // 
            this.chkButtonEnabled.AutoSize = true;
            this.chkButtonEnabled.Location = new System.Drawing.Point(106, 129);
            this.chkButtonEnabled.Name = "chkButtonEnabled";
            this.chkButtonEnabled.Size = new System.Drawing.Size(136, 21);
            this.chkButtonEnabled.TabIndex = 1;
            this.chkButtonEnabled.Text = "Wł./Wył. przycisk";
            this.chkButtonEnabled.UseVisualStyleBackColor = true;
            this.chkButtonEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(28, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(261, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Laboratorium KWZP 2020";
            // 
            // txtButtonChange
            // 
            this.txtButtonChange.Location = new System.Drawing.Point(33, 78);
            this.txtButtonChange.Name = "txtButtonChange";
            this.txtButtonChange.Size = new System.Drawing.Size(256, 22);
            this.txtButtonChange.TabIndex = 3;
            this.txtButtonChange.TextChanged += new System.EventHandler(this.txtButtonChange_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 238);
            this.Controls.Add(this.txtButtonChange);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chkButtonEnabled);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkButtonEnabled;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtButtonChange;
    }
}

