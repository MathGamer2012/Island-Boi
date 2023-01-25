using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Island_Boi
{
    public partial class frmLibMain : Form
    {
        public static frmLibMain inst;
        private Button currButton;
        private Form formOn;
        public frmLibMain()
        {
            InitializeComponent();
            inst = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnMoveMain.Visible = false;
            btnSearchButton.Visible = true;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLibMain_Load(object sender, EventArgs e)
        {

        }
        private Color SelectThemeColor()
        {
            string color = MainColour.colourMain;
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currButton = (Button)btnSender;
                    currButton.BackColor = color;
                    currButton.ForeColor = Color.White;
                    currButton.Font = new System.Drawing.Font("Nirmala UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnMoveMain.Visible = true;
                    btnSearchButton.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMain.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(9, 70, 125);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

       private void subFormEntry(Form subForm, object btnSender)
        {
            if( formOn!= null)
            {
                formOn.Close();
            }
            ActivateButton(btnSender);
            formOn = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            this.panelDisplayForm.Controls.Add(subForm);
            this.panelDisplayForm.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
            lblSubTitle.Text = subForm.Text;

        }
             
        private void btnBookList_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookList(), sender);
        }

        private void btnBookHistory_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookHistory(), sender);
        }

        private void btnBookReview_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookReview(), sender);
        }

        private void btnBookHold_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookReturn(), sender);
        }

        private void btnBookDonate_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookDonate(), sender);
        }

        private void btnBookCheckout_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookCheckList(), sender);
        }

        private void panelTopTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";

            

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "book list")
            {
                subFormEntry(new Forms.frmBookList(), sender);
            }

            if (txtSearchBar.Text == "book history")
            {
                subFormEntry(new Forms.frmBookHistory(), sender);
            }

            if (txtSearchBar.Text == "book review")
            {
                subFormEntry(new Forms.frmBookReview(), sender);
            }

            if (txtSearchBar.Text == "book hold")
            {
                subFormEntry(new Forms.frmBookReturn(), sender);
            }

            if (txtSearchBar.Text == "book donate")
            {
                subFormEntry(new Forms.frmBookDonate(), sender);
            }

            if (txtSearchBar.Text == "book checkout")
            {
                subFormEntry(new Forms.frmBookCheckList(), sender);
            }

            if (txtSearchBar.Text == "home" || txtSearchBar.Text == "menu" || txtSearchBar.Text == "main" || txtSearchBar.Text == "welcome")
            {
                if (formOn != null)
                {
                    formOn.Close();
                }
                Reset();
            }
        }

        private void btnMoveMain_Click(object sender, EventArgs e)
        {
            if(formOn != null)
            {
                formOn.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblSubTitle.Text = "WELCOME";
            currButton = null;
            btnMoveMain.Visible = false;
            btnSearchButton.Visible = true;
        }
    }
}
