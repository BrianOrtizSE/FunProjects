using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace June_26_2023_CPractice
{
    public partial class frmMain : Form
    {
        Random rnd = new Random();
        int i = 0;

        int intMaxWidth;
        int intMaxHeight;

        //int intMaxScreenX = frmMain.Size.Height
        //int intMaxScreenY = 

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClickEnter(object sender, EventArgs e)
        {
            if (i < 5)
            {
                btnClick.Location = new Point(rnd.Next(0, intMaxWidth), rnd.Next(0, intMaxHeight));
                i++;

            }
            else
            {
                btnClick.Location = new Point(rnd.Next(0, intMaxWidth), rnd.Next(0, intMaxHeight));
                btnClick.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            intMaxHeight = this.Height - 100;
            intMaxWidth = this.Width - 100;
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            intMaxHeight = this.Height - 100;
            intMaxWidth = this.Width - 100;
        }
    }
}
