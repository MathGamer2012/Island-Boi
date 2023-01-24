namespace Island_Boi.Forms
{
    partial class frmBookDonate
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
            this.panelBackDonate = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBackDonate
            // 
            this.panelBackDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackDonate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackDonate.Location = new System.Drawing.Point(0, 0);
            this.panelBackDonate.Name = "panelBackDonate";
            this.panelBackDonate.Size = new System.Drawing.Size(800, 450);
            this.panelBackDonate.TabIndex = 0;
            // 
            // frmBookDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackDonate);
            this.Name = "frmBookDonate";
            this.Text = "BOOK DONATE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackDonate;
    }
}