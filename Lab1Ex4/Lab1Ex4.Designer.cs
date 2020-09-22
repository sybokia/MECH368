namespace Lab1Ex4
{
    partial class Lab1Ex4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtBytesToRead = new System.Windows.Forms.TextBox();
            this.txtTempStringLength = new System.Windows.Forms.TextBox();
            this.txtItemsInQueue = new System.Windows.Forms.TextBox();
            this.txtDataStream = new System.Windows.Forms.TextBox();
            this.cmbCOMPorts = new System.Windows.Forms.ComboBox();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.cbxSaveToFile = new System.Windows.Forms.CheckBox();
            this.btnFileName = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(6, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 32);
            label1.TabIndex = 2;
            label1.Text = "Serial bytes to read";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(6, 128);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(245, 32);
            label2.TabIndex = 3;
            label2.Text = "Temp. string length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 173);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(194, 32);
            label3.TabIndex = 4;
            label3.Text = "Items in queue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(6, 237);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(236, 32);
            label4.TabIndex = 8;
            label4.Text = "Serial data stream";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(263, 12);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(254, 40);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.Text = "Connect Serial";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtBytesToRead
            // 
            this.txtBytesToRead.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBytesToRead.Location = new System.Drawing.Point(263, 80);
            this.txtBytesToRead.Name = "txtBytesToRead";
            this.txtBytesToRead.Size = new System.Drawing.Size(254, 39);
            this.txtBytesToRead.TabIndex = 5;
            // 
            // txtTempStringLength
            // 
            this.txtTempStringLength.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempStringLength.Location = new System.Drawing.Point(263, 125);
            this.txtTempStringLength.Name = "txtTempStringLength";
            this.txtTempStringLength.Size = new System.Drawing.Size(254, 39);
            this.txtTempStringLength.TabIndex = 6;
            // 
            // txtItemsInQueue
            // 
            this.txtItemsInQueue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsInQueue.Location = new System.Drawing.Point(263, 170);
            this.txtItemsInQueue.Name = "txtItemsInQueue";
            this.txtItemsInQueue.Size = new System.Drawing.Size(254, 39);
            this.txtItemsInQueue.TabIndex = 7;
            // 
            // txtDataStream
            // 
            this.txtDataStream.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataStream.Location = new System.Drawing.Point(12, 272);
            this.txtDataStream.Multiline = true;
            this.txtDataStream.Name = "txtDataStream";
            this.txtDataStream.Size = new System.Drawing.Size(505, 345);
            this.txtDataStream.TabIndex = 9;
            // 
            // cmbCOMPorts
            // 
            this.cmbCOMPorts.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCOMPorts.FormattingEnabled = true;
            this.cmbCOMPorts.Location = new System.Drawing.Point(12, 12);
            this.cmbCOMPorts.Name = "cmbCOMPorts";
            this.cmbCOMPorts.Size = new System.Drawing.Size(239, 40);
            this.cmbCOMPorts.TabIndex = 10;
            this.cmbCOMPorts.Text = "Ports";
            this.cmbCOMPorts.DropDown += new System.EventHandler(this.cmbCOMPorts_DropDown);
            this.cmbCOMPorts.SelectedIndexChanged += new System.EventHandler(this.dropDownPorts_SelectedIndexChanged);
            // 
            // serCom
            // 
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 643);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Az";
            // 
            // txtAx
            // 
            this.txtAx.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAx.Location = new System.Drawing.Point(57, 640);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(100, 39);
            this.txtAx.TabIndex = 14;
            // 
            // txtAy
            // 
            this.txtAy.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAy.Location = new System.Drawing.Point(241, 640);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(100, 39);
            this.txtAy.TabIndex = 15;
            // 
            // txtAz
            // 
            this.txtAz.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAz.Location = new System.Drawing.Point(417, 640);
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(100, 39);
            this.txtAz.TabIndex = 16;
            // 
            // cbxSaveToFile
            // 
            this.cbxSaveToFile.AutoSize = true;
            this.cbxSaveToFile.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSaveToFile.Location = new System.Drawing.Point(12, 703);
            this.cbxSaveToFile.Name = "cbxSaveToFile";
            this.cbxSaveToFile.Size = new System.Drawing.Size(181, 36);
            this.cbxSaveToFile.TabIndex = 17;
            this.cbxSaveToFile.Text = "Save to file";
            this.cbxSaveToFile.UseVisualStyleBackColor = true;
            this.cbxSaveToFile.CheckedChanged += new System.EventHandler(this.cbxSaveToFile_CheckedChanged);
            // 
            // btnFileName
            // 
            this.btnFileName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileName.Location = new System.Drawing.Point(12, 755);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(223, 43);
            this.btnFileName.TabIndex = 18;
            this.btnFileName.Text = "Select file name";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(263, 755);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(254, 39);
            this.txtFileName.TabIndex = 19;
            // 
            // Lab1Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 818);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.cbxSaveToFile);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtAx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCOMPorts);
            this.Controls.Add(this.txtDataStream);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtItemsInQueue);
            this.Controls.Add(this.txtTempStringLength);
            this.Controls.Add(this.txtBytesToRead);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnConnection);
            this.Name = "Lab1Ex4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lab1Ex4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox txtBytesToRead;
        private System.Windows.Forms.TextBox txtTempStringLength;
        private System.Windows.Forms.TextBox txtItemsInQueue;
        private System.Windows.Forms.TextBox txtDataStream;
        private System.Windows.Forms.ComboBox cmbCOMPorts;
        private System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.CheckBox cbxSaveToFile;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.TextBox txtFileName;
    }
}

