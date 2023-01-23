namespace Island_Boi
{
    partial class frmLibMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBookCheckout = new System.Windows.Forms.Button();
            this.btnBookDonate = new System.Windows.Forms.Button();
            this.btnBookHold = new System.Windows.Forms.Button();
            this.btnBookReview = new System.Windows.Forms.Button();
            this.btnBookHistory = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelTopTitle = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelTopTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.panelMain.Controls.Add(this.btnBookCheckout);
            this.panelMain.Controls.Add(this.btnBookDonate);
            this.panelMain.Controls.Add(this.btnBookHold);
            this.panelMain.Controls.Add(this.btnBookReview);
            this.panelMain.Controls.Add(this.btnBookHistory);
            this.panelMain.Controls.Add(this.btnBookList);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(220, 557);
            this.panelMain.TabIndex = 0;
            // 
            // btnBookCheckout
            // 
            this.btnBookCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookCheckout.FlatAppearance.BorderSize = 0;
            this.btnBookCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCheckout.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookCheckout.ForeColor = System.Drawing.Color.White;
            this.btnBookCheckout.Image = global::Island_Boi.Properties.Resources.BookCheckoutSymbol;
            this.btnBookCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookCheckout.Location = new System.Drawing.Point(0, 380);
            this.btnBookCheckout.Name = "btnBookCheckout";
            this.btnBookCheckout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookCheckout.Size = new System.Drawing.Size(220, 60);
            this.btnBookCheckout.TabIndex = 7;
            this.btnBookCheckout.Text = "   Book Checkout";
            this.btnBookCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookCheckout.UseVisualStyleBackColor = true;
            this.btnBookCheckout.Click += new System.EventHandler(this.btnBookCheckout_Click);
            // 
            // btnBookDonate
            // 
            this.btnBookDonate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookDonate.FlatAppearance.BorderSize = 0;
            this.btnBookDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDonate.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDonate.ForeColor = System.Drawing.Color.White;
            this.btnBookDonate.Image = global::Island_Boi.Properties.Resources.BookDonateSymbol;
            this.btnBookDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookDonate.Location = new System.Drawing.Point(0, 320);
            this.btnBookDonate.Name = "btnBookDonate";
            this.btnBookDonate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookDonate.Size = new System.Drawing.Size(220, 60);
            this.btnBookDonate.TabIndex = 6;
            this.btnBookDonate.Text = "   Book Donate ";
            this.btnBookDonate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookDonate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookDonate.UseVisualStyleBackColor = true;
            this.btnBookDonate.Click += new System.EventHandler(this.btnBookDonate_Click);
            // 
            // btnBookHold
            // 
            this.btnBookHold.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookHold.FlatAppearance.BorderSize = 0;
            this.btnBookHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookHold.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookHold.ForeColor = System.Drawing.Color.White;
            this.btnBookHold.Image = global::Island_Boi.Properties.Resources.BookHoldSymbol;
            this.btnBookHold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookHold.Location = new System.Drawing.Point(0, 260);
            this.btnBookHold.Name = "btnBookHold";
            this.btnBookHold.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookHold.Size = new System.Drawing.Size(220, 60);
            this.btnBookHold.TabIndex = 5;
            this.btnBookHold.Text = "   Book Hold";
            this.btnBookHold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookHold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookHold.UseVisualStyleBackColor = true;
            this.btnBookHold.Click += new System.EventHandler(this.btnBookHold_Click);
            // 
            // btnBookReview
            // 
            this.btnBookReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookReview.FlatAppearance.BorderSize = 0;
            this.btnBookReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReview.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReview.ForeColor = System.Drawing.Color.White;
            this.btnBookReview.Image = global::Island_Boi.Properties.Resources.BookReviewSymbol;
            this.btnBookReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReview.Location = new System.Drawing.Point(0, 200);
            this.btnBookReview.Name = "btnBookReview";
            this.btnBookReview.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookReview.Size = new System.Drawing.Size(220, 60);
            this.btnBookReview.TabIndex = 4;
            this.btnBookReview.Text = "   Book Review";
            this.btnBookReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookReview.UseVisualStyleBackColor = true;
            this.btnBookReview.Click += new System.EventHandler(this.btnBookReview_Click);
            // 
            // btnBookHistory
            // 
            this.btnBookHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookHistory.FlatAppearance.BorderSize = 0;
            this.btnBookHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookHistory.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookHistory.ForeColor = System.Drawing.Color.White;
            this.btnBookHistory.Image = global::Island_Boi.Properties.Resources.BookHistSymbol;
            this.btnBookHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookHistory.Location = new System.Drawing.Point(0, 140);
            this.btnBookHistory.Name = "btnBookHistory";
            this.btnBookHistory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookHistory.Size = new System.Drawing.Size(220, 60);
            this.btnBookHistory.TabIndex = 3;
            this.btnBookHistory.Text = "   Book History";
            this.btnBookHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookHistory.UseVisualStyleBackColor = true;
            this.btnBookHistory.Click += new System.EventHandler(this.btnBookHistory_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookList.FlatAppearance.BorderSize = 0;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Image = global::Island_Boi.Properties.Resources.ghjhkjhgjfyujhgkj;
            this.btnBookList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookList.Location = new System.Drawing.Point(0, 80);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookList.Size = new System.Drawing.Size(220, 60);
            this.btnBookList.TabIndex = 2;
            this.btnBookList.Text = "   Book List";
            this.btnBookList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.panelTitle.BackgroundImage = global::Island_Boi.Properties.Resources.BookVaultOfficialLogoV2;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(220, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // panelTopTitle
            // 
            this.panelTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelTopTitle.Controls.Add(this.textBox1);
            this.panelTopTitle.Controls.Add(this.btnMinimize);
            this.panelTopTitle.Controls.Add(this.btnExpand);
            this.panelTopTitle.Controls.Add(this.btnClose);
            this.panelTopTitle.Controls.Add(this.lblSubTitle);
            this.panelTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTopTitle.Name = "panelTopTitle";
            this.panelTopTitle.Size = new System.Drawing.Size(763, 80);
            this.panelTopTitle.TabIndex = 1;
            this.panelTopTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopTitle_MouseDown);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(185, 24);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(102, 34);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "WELCOME";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(734, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(701, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(18, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "O";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(664, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 26);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(983, 557);
            this.panelBackground.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(459, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search...";
            // 
            // frmLibMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 557);
            this.Controls.Add(this.panelTopTitle);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(799, 476);
            this.Name = "frmLibMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmLibMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTopTitle.ResumeLayout(false);
            this.panelTopTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnBookCheckout;
        private System.Windows.Forms.Button btnBookDonate;
        private System.Windows.Forms.Button btnBookHold;
        private System.Windows.Forms.Button btnBookReview;
        private System.Windows.Forms.Button btnBookHistory;
        private System.Windows.Forms.Panel panelTopTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TextBox textBox1;
    }
}