using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Ex2
{
    public partial class Form1 : Form
    {
        Queue<Int32> dataQueue = new Queue<Int32>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            dataQueue.Enqueue(Convert.ToInt32(txtEnqueue.Text));
            txtEnqueue.Clear();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (dataQueue.Count == 0)
            {
                string errorMessage = "Error: queue is empty";
                string errorCaption = "Error";
                MessageBox.Show(errorMessage, errorCaption);
            } else
            {
                txtDequeue.Text = dataQueue.Dequeue().ToString();
            }
        }

        private void UpdateQueue()
        {
            txtNQueue.Text = dataQueue.Count.ToString();
            
            txtQueueContents.Clear();
            foreach (Object obj in dataQueue)
            {
                txtQueueContents.AppendText(obj.ToString() + Environment.NewLine);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateQueue();
        }

        private void btnAverageFirstN_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNDataPoints.Text);
            int sum = 0;

            if (n > dataQueue.Count)
            {
                string errorMessage = "Error: insuffcient data in queue";
                string errorCaption = "Error";
                MessageBox.Show(errorMessage, errorCaption);
            } else
            {
                for (int i = 0; i<n; i++) sum += dataQueue.Dequeue();

                double average = (double)sum / n;
                txtAverage.Text = average.ToString("0.000");
            }
        }
    }
}
