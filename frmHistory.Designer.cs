namespace password {
    partial class frmHistory {
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
            this.listItems = new System.Windows.Forms.ListBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 24;
            this.listItems.Location = new System.Drawing.Point(12, 12);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(260, 196);
            this.listItems.TabIndex = 0;
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(12, 214);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 1;
            this.bntClear.Text = "Clear All";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(197, 214);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 2;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.listItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button bntClose;
    }
}