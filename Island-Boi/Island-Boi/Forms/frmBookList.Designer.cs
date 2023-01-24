namespace Island_Boi.Forms
{
    partial class frmBookList
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
            this.panelBackList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBackList
            // 
            this.panelBackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackList.Location = new System.Drawing.Point(0, 0);
            this.panelBackList.Name = "panelBackList";
            this.panelBackList.Size = new System.Drawing.Size(800, 450);
            this.panelBackList.TabIndex = 0;
            // 
            // frmBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackList);
            this.Name = "frmBookList";
            this.Text = "BOOK LIST";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackList;
    }
}