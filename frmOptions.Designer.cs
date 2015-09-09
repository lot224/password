namespace password {
    partial class frmOptions {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntCancel = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(12, 31);
            this.txtBank.Multiline = true;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(255, 43);
            this.txtBank.TabIndex = 3;
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character Bank:";
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(111, 115);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 4;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntSave
            // 
            this.bntSave.Enabled = false;
            this.bntSave.Location = new System.Drawing.Point(192, 115);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 5;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(110, 80);
            this.numLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(157, 20);
            this.numLength.TabIndex = 6;
            this.numLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password Length:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label1;
    }
}