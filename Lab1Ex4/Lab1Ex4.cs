using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Ex4
{
    public partial class Lab1Ex4 : Form
    {
        string serialDataString = "";
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        int dataState = 0;
        int serialBytesToReadDisplay;
        StreamWriter outputFile;
        
        public Lab1Ex4()
        {
            InitializeComponent();
        }


        private void Lab1Ex4_Load(object sender, EventArgs e)
        {
            btnConnection.Text = "Connect serial";
            timer.Enabled = true;
            updateSerial();
        }

        private void cmbCOMPorts_DropDown(object sender, EventArgs e)
        {
            updateSerial();
        }

        private void updateSerial()
        {
            cmbCOMPorts.Items.Clear();
            cmbCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (cmbCOMPorts.Items.Count == 0)
                cmbCOMPorts.Text = "No COM Ports!";
            else
                cmbCOMPorts.SelectedIndex = 0;
        }

        private void dropDownPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serCom.PortName = cmbCOMPorts.SelectedItem.ToString();
        }


        private void btnConnection_Click(object sender, EventArgs e)
        {

            if (serCom.IsOpen == true)
            {
                serCom.Close();
                btnConnection.Text = "Connect Serial";
            }
            else
            {
                serCom.Open();
                serCom.Write("A");
                btnConnection.Text = "Disconnect Serial";
            }
        }


        private void serCom_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int newByte;
            int bytesToRead;

            bytesToRead = serCom.BytesToRead;
            serialBytesToReadDisplay = bytesToRead;
            while (bytesToRead > 0 && serCom.IsOpen == true)
            {
                newByte = serCom.ReadByte();
                serialDataString += newByte.ToString() + ", ";
                dataQueue.Enqueue(newByte);
                bytesToRead = serCom.BytesToRead;
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (serCom.IsOpen)
            {
                txtBytesToRead.Text = serialBytesToReadDisplay.ToString();
                txtDataStream.AppendText(serialDataString);
                txtTempStringLength.Text = serialDataString.Length.ToString();
                txtItemsInQueue.Text = dataQueue.Count().ToString();

                serialDataString = "";

                while (dataQueue.Count() > 0)
                {
                    if (dataQueue.TryDequeue(out int nextByte))
                    {
                        if (nextByte == 255)
                            dataState = 1;
                        else if (dataState == 1)
                        {
                            dataState = 2;
                            txtAx.Text = nextByte.ToString();
                            if (cbxSaveToFile.Checked == true)
                                outputFile.Write(nextByte.ToString() + ", ");
                        }
                        else if (dataState == 2)
                        {
                            dataState = 3;
                            txtAy.Text = nextByte.ToString();
                            if (cbxSaveToFile.Checked == true)
                                outputFile.Write(nextByte.ToString() + ", ");
                        }
                        else if (dataState == 3)
                        {
                            dataState = 0;
                            txtAz.Text = nextByte.ToString();
                            if (cbxSaveToFile.Checked == true)
                                outputFile.Write(nextByte.ToString() + ", " + DateTime.Now.ToLongTimeString() + "\n");

                        }
                        // serialDataString += dequeueItem.ToString() + ", ";
                    } 
                }

            }
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            SaveFileDialog myDialogBox = new SaveFileDialog();
            myDialogBox.InitialDirectory = @"C:\Users\sibow\OneDrive\Documents\UBC\Year 3.5\MECH368\Lab 1\demo";
            myDialogBox.ShowDialog();
            txtFileName.Text = myDialogBox.FileName.ToString() + ".CSV";
        }

        private void cbxSaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSaveToFile.Checked == true)
            {
                outputFile = new StreamWriter(txtFileName.Text);
            }
            else
                outputFile.Close();
        }
    }
}
