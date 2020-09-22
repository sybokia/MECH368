using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Ex7
{
    public partial class Lab1Ex7 : Form
    {
        int gestureState = 0;
        int wait1 = 0;
        int wait2 = 0;
        int wait3 = 0;

        public Lab1Ex7()
        {
            InitializeComponent();
        }

        private void btnNewDataPoint_Click(object sender, EventArgs e)
        {
            int Ax = Convert.ToInt32(txtAx.Text);
            int Ay = Convert.ToInt32(txtAy.Text);
            int Az = Convert.ToInt32(txtAz.Text);

            if (gestureState == 0)
            {
                if (Ax > 180)
                {
                    gestureState = 1;
                    //display punch
                    wait1 = 10;
                }
                else if (Az > 180)
                {
                    gestureState = 2;
                    wait2 = 5;
                }
            }
            else if (gestureState == 1)
            {
                if (wait1 > 0)
                    wait1--;
                else
                    gestureState = 0;
            }
            else if (gestureState == 2)
            {
                if (Ax > 180)
                {
                    gestureState = 3;
                    wait3 = 10;
                }
                else if (wait2 > 0)
                    wait2--;
                else
                    gestureState = 0;
            }
            else if (gestureState == 3)
            {
                if (wait3 > 0)
                    wait3--;
                else
                    gestureState = 0;
            }

            txtCurrentState.Text = gestureState.ToString();
            txtDataHistory.AppendText("(" + Ax.ToString() + ", " + Ay.ToString() + ", " + Az.ToString() + ", " + gestureState.ToString() + "), ");
            
        }
    }
}
