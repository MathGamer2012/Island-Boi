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
        public frmLibMain()
        {
            InitializeComponent();
            inst = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

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

        private void btnBookList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBookHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBookReview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBookHold_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBookDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBookCheckout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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
    }
}
