using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECH368Lab1
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void txtDrawingWindow_MouseMove(object sender, MouseEventArgs e)
        {
            txtXPos.Text = e.X.ToString("0000");
            txtYPos.Text = e.Y.ToString("0000");
        }

        private void txtDrawingWindow_MouseClick(object sender, MouseEventArgs e)
        {
            string ClickCoordinate = "(" + e.X.ToString("0000") + ", " + e.Y.ToString("0000") + ")\n";
            txtRecordedClicks.AppendText(ClickCoordinate);
        }
    }
}
